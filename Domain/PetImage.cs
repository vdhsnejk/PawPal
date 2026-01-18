namespace PawPal.Domain;

public class PetImage : BaseDomainModel
{
    public int PetId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public bool IsPrimary { get; set; }
}
