using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PAWPALme.Enums;

namespace PAWPALme.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan AppointmentTime { get; set; }

        [Required]
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;

        [StringLength(500)]
        public string? Notes { get; set; }

        // --- RELATIONS ---
        // An appointment MUST be linked to an application.
        // This is the "Handshake" with Nicole's side.
        [Required]
        public int AdoptionApplicationId { get; set; }

        [ForeignKey("AdoptionApplicationId")]
        public virtual AdoptionApplication? AdoptionApplication { get; set; }

        // This tracks WHO (Shelter Staff) managed/updated this appointment
        public string? ManagedByUserId { get; set; }
    }
}