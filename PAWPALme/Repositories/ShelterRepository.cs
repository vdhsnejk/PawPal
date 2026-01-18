using Microsoft.EntityFrameworkCore;
using PAWPALme.Data;
using PAWPALme.Models;

namespace PAWPALme.Repositories
{
    public class ShelterRepository : IShelterRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _factory;

        public ShelterRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            _factory = factory;
        }

        public async Task<Shelter?> GetByIdAsync(int id)
        {
            using var context = _factory.CreateDbContext();
            return await context.Shelter.FindAsync(id);
        }

        public async Task<Shelter?> GetByUserIdAsync(string userId)
        {
            using var context = _factory.CreateDbContext();
            return await context.Shelter.FirstOrDefaultAsync(s => s.OwnerUserId == userId);
        }

        public async Task AddAsync(Shelter shelter)
        {
            using var context = _factory.CreateDbContext();
            context.Shelter.Add(shelter);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Shelter shelter)
        {
            using var context = _factory.CreateDbContext();
            context.Shelter.Update(shelter);
            await context.SaveChangesAsync();
        }

        public async Task<bool> UserHasShelterAsync(string userId)
        {
            using var context = _factory.CreateDbContext();
            return await context.Shelter.AnyAsync(s => s.OwnerUserId == userId);
        }

        // NEW: Fetch all shelters for the public list
        public async Task<IEnumerable<Shelter>> GetAllAsync()
        {
            using var context = _factory.CreateDbContext();
            return await context.Shelter.ToListAsync();
        }
    }
}