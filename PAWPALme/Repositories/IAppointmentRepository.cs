using PAWPALme.Models;
using PAWPALme.Enums;

namespace PAWPALme.Repositories
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetByShelterIdAsync(int shelterId);
        Task<Appointment?> GetByIdAsync(int id);
        Task AddAsync(Appointment appointment);
        Task UpdateStatusAsync(int id, AppointmentStatus status);
    }
}