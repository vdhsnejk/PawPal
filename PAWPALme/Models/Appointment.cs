using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAWPALme.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; } = DateTime.Now.AddDays(1);

        [Required]
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Rejected, Completed

        // --- ADOPTER DETAILS ---
        [Required(ErrorMessage = "Please enter your name")]
        public string AdopterName { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string AdopterEmail { get; set; } = "";

        // --- RELATIONS ---

        // Link to the Registered User (Nullable, in case we allow guest checkout, 
        // but for high marks we prefer logged in users)
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual PAWPALme.Data.ApplicationUser? User { get; set; }

        public int PetId { get; set; }

        [ForeignKey("PetId")]
        public virtual Pet? Pet { get; set; }
    }
}