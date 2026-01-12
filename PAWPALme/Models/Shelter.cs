using System.ComponentModel.DataAnnotations;

namespace PAWPALme.Models
{
    public class Shelter
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Shelter Name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // Links this Shelter profile to a Login Account (Admin)
        public string? OwnerUserId { get; set; }
    }
}



