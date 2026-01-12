using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PAWPALme.Enums;

namespace PAWPALme.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pet Name is required")]
        [StringLength(80, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Species { get; set; } = string.Empty; // e.g., "Dog", "Cat"

        [Required]
        [StringLength(80)]
        public string Breed { get; set; } = string.Empty;

        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30")]
        public int Age { get; set; }

        [Required]
        public PetGender Gender { get; set; }

        [Required]
        public PetStatus Status { get; set; } = PetStatus.Available;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [StringLength(400)]
        public string? ImageUrl { get; set; }

        // --- RELATIONS ---
        [Required]
        [Display(Name = "Shelter")]
        public int ShelterId { get; set; }

        [ForeignKey("ShelterId")]
        public virtual Shelter? Shelter { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}