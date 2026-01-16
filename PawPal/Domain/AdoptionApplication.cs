namespace PawPal.Domain;

public class AdoptionApplication : BaseDomainModel
{
    public int AdopterId { get; set; }
    public int PetId { get; set; }
    public DateTime ApplicationDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Pending";
    public string? Remarks { get; set; }

    public int? ReviewedByAdminId { get; set; }
    public DateTime? ReviewedDateTime { get; set; }
}
