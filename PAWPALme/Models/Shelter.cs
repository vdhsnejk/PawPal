using System.ComponentModel.DataAnnotations;

namespace PAWPALme.Models
{
    public class Shelter
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";

        [Required]
        public string Phone { get; set; } = "";

        // NEW: For the "Details" you requested
        [StringLength(1000)]
        public string? Description { get; set; }

        // NEW: For a profile picture/logo
        public string? ImageUrl { get; set; }

        // Link to the Identity User (Login)
        public string? OwnerUserId { get; set; }
    }
}



