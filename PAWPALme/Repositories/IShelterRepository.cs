using PAWPALme.Models;

namespace PAWPALme.Repositories
{
    public interface IShelterRepository
    {
        Task<Shelter?> GetByIdAsync(int id);
        Task<Shelter?> GetByUserIdAsync(string userId);
        Task AddAsync(Shelter shelter);
        Task UpdateAsync(Shelter shelter);
        Task<bool> UserHasShelterAsync(string userId);

        // REQUIRED for the list page
        Task<IEnumerable<Shelter>> GetAllAsync();
    }
}