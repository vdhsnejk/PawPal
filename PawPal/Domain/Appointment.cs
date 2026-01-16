namespace PawPal.Domain;

public class Appointment : BaseDomainModel
{
    public int ApplicationId { get; set; }
    public DateOnly AppointmentDate { get; set; }
    public TimeOnly AppointmentTime { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Status { get; set; } = "Scheduled";
    public string? Notes { get; set; }

    public int? ScheduledByAdminId { get; set; }
}

