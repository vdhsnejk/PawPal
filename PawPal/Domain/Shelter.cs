namespace PawPal.Domain;

public class Shelter : BaseDomainModel
{
    public string ShelterName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Email { get; set; }
}
