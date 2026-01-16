namespace PawPal.Domain;

public class Pet : BaseDomainModel
{
    public int ShelterId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public string? Breed { get; set; }
    public int Age { get; set; }
    public string Size { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string? Temperament { get; set; }
    public string? MedicalInfo { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; } = "Available";
}
