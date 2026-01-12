using Microsoft.EntityFrameworkCore;
using PAWPALme.Data;
using PAWPALme.Models;

namespace PAWPALme.Services
{
    public class ShelterService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;

        public ShelterService(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Shelter>> GetSheltersAsync()
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            return await db.Shelter
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<Shelter?> GetShelterAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            return await db.Shelter.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Shelter?> GetShelterByOwnerUserIdAsync(string ownerUserId)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            return await db.Shelter.FirstOrDefaultAsync(s => s.OwnerUserId == ownerUserId);
        }

        public async Task<int> CreateShelterAsync(Shelter shelter)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            db.Shelter.Add(shelter);
            await db.SaveChangesAsync();
            return shelter.Id;
        }

        public async Task UpdateShelterAsync(Shelter shelter)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            db.Shelter.Update(shelter);
            await db.SaveChangesAsync();
        }

        public async Task DeleteShelterAsync(int id)
        {
            await using var db = await _dbFactory.CreateDbContextAsync();
            var shelter = await db.Shelter.FirstOrDefaultAsync(s => s.Id == id);
            if (shelter is null) return;

            db.Shelter.Remove(shelter);
            await db.SaveChangesAsync();
        }
    }
}



