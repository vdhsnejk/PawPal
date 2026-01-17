namespace PawPal.Domain;

public class AdoptionApplication : BaseDomainModel
{
    public int PetId { get; set; }
    public string AdopterId { get; set; } = "";

    public DateTime ApplicationDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Pending";
    public string? Remarks { get; set; }

    // meaningful fields (instead of stuffing into Remarks)
    public string FullName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public string Reason { get; set; } = "";
    public string Experience { get; set; } = "";

    // optional admin fields (for admin review later)
    public string? AdminRemarks { get; set; }
    public string? ReviewedByAdminId { get; set; }
    public DateTime? ReviewedDateTime { get; set; }
}
