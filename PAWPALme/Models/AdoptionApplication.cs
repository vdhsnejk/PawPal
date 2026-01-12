using System.ComponentModel.DataAnnotations;
using PAWPALme.Data;

namespace PAWPALme.Models
{
    // STUB: Nicole owns this. You need it for Foreign Keys.
    public class AdoptionApplication
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; } // Adopter
        public virtual ApplicationUser? User { get; set; }

        public int PetId { get; set; } // The Pet requested
        public virtual Pet? Pet { get; set; }

        // Nicole will add Status, Date, etc. here later.
    }
}
