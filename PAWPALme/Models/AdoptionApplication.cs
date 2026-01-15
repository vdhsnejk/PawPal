using System.ComponentModel.DataAnnotations;
using PAWPALme.Data;

namespace PAWPALme.Models
{
    public class AdoptionApplication
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        public int PetId { get; set; }
        public virtual Pet? Pet { get; set; }

        // --- STUB PROPERTIES FOR YIXIANG'S TESTING ---
        // We store applicant details here so your Appointment form works
        // without waiting for Nicole's full User System.
        public string? ApplicantName { get; set; }
        public string? ApplicantEmail { get; set; }
    }
}