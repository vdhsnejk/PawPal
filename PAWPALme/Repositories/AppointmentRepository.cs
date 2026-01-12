using Microsoft.EntityFrameworkCore;
using PAWPALme.Data;
using PAWPALme.Models;
using PAWPALme.Enums;

namespace PAWPALme.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _factory;

        public AppointmentRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<Appointment>> GetByShelterIdAsync(int shelterId)
        {
            using var context = _factory.CreateDbContext();
            // Complex Query: Get appointments where the linked Pet belongs to this Shelter
            return await context.Appointment
                .Include(a => a.AdoptionApplication)
                .ThenInclude(app => app.Pet)
                .Include(a => a.AdoptionApplication)
                .ThenInclude(app => app.User) // Get Adopter info
                .Where(a => a.AdoptionApplication != null &&
                            a.AdoptionApplication.Pet != null &&
                            a.AdoptionApplication.Pet.ShelterId == shelterId)
                .OrderBy(a => a.AppointmentDate)
                .ToListAsync();
        }

        public async Task<Appointment?> GetByIdAsync(int id)
        {
            using var context = _factory.CreateDbContext();
            return await context.Appointment
                .Include(a => a.AdoptionApplication)
                .ThenInclude(app => app.Pet)
                .Include(a => a.AdoptionApplication)
                .ThenInclude(app => app.User)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAsync(Appointment appointment)
        {
            using var context = _factory.CreateDbContext();
            context.Appointment.Add(appointment);
            await context.SaveChangesAsync();
        }

        public async Task UpdateStatusAsync(int id, AppointmentStatus status)
        {
            using var context = _factory.CreateDbContext();
            var appt = await context.Appointment.FindAsync(id);
            if (appt != null)
            {
                appt.Status = status;
                await context.SaveChangesAsync();
            }
        }
    }
}