using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAWPALme.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Custom Fields
        [PersonalData]
        public string FullName { get; set; } = "";

        // Link this user to a specific Shelter
        // If null, they are a normal Adopter. If set, they are Shelter Staff.
        public int? ShelterId { get; set; }

        [ForeignKey("ShelterId")]
        public virtual PAWPALme.Models.Shelter? Shelter { get; set; }
    }
}

