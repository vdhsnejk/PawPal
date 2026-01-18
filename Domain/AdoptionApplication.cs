namespace PawPal.Domain;

public class AdoptionApplication : BaseDomainModel
{
    public int PetId { get; set; }
    public string AdopterId { get; set; } = "";

    public DateTime ApplicationDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Pending";
    public string? Remarks { get; set; }

    // Contact
    public string FullName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";

    // Home suitability
    public string HousingType { get; set; } = "";            // HDB/Condo/Landed/Rental
    public bool HasLandlordOrFamilyApproval { get; set; }    // approval
    public bool AnyoneAllergic { get; set; }                 // allergies
    public int AvgHoursAlone { get; set; }                   // hours pet alone per day

    // Ownership experience
    public bool CurrentlyOwnPets { get; set; }               // currently own pets
    public string? CurrentPetsDetails { get; set; }          // describe what pets (if any)
    public string? PetExperienceDetails { get; set; }        // briefly describe experience

    // Motivation & caregiving
    public string ReasonForAdoption { get; set; } = "";      // why adopt
    public string PrimaryCaregiver { get; set; } = "";       // who is primary caregiver
    public bool PreparedForVetCare { get; set; }             // vet care readiness

    // Admin notes (optional)
    public string? AdminRemarks { get; set; }
    public string? ReviewedByAdminId { get; set; }
    public DateTime? ReviewedDateTime { get; set; }
}
