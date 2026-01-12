using PAWPALme.Models;
using PAWPALme.Enums;

namespace PAWPALme.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetAllAsync();
        Task<IEnumerable<Pet>> SearchAsync(string? searchTerm, string? species, string? breed, int? minAge);
        Task<Pet?> GetByIdAsync(int id);
        Task<IEnumerable<Pet>> GetPetsByShelterAsync(int shelterId);
        Task AddAsync(Pet pet);
        Task UpdateAsync(Pet pet);
        Task DeleteAsync(int id);
        Task<IEnumerable<string>> GetBreedsAsync();
    }
}