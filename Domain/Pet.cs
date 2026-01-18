using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawPal.Domain
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Breed { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Size { get; set; } = string.Empty; // Small, Medium, Large

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsAdopted { get; set; } = false;

        // Relationships
        public int ShelterId { get; set; }
        [ForeignKey("ShelterId")]
        public Shelter? Shelter { get; set; }
    }
}