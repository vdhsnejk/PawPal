using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PawPal.Data;

namespace PawPal.Domain
{
    public class Shelter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string ContactNumber { get; set; } = string.Empty;

        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Description { get; set; }

        // Link to User System
        public string? ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public PawPalUser? ApplicationUser { get; set; }

        public ICollection<Pet>? Pets { get; set; }
    }
}