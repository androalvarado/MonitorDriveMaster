namespace MonitorDriveAPI.Models.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public float Miles { get; set; }
        public float Percent_usage { get; set; }
        public float Insurage { get; set; }
        public string? Image { get; set; }
        public float Mpg { get; set; }
        public float Autonomy { get; set; }
        // Navigation Properties
        public Guid DriverId { get; set; }
        public Driver? Driver { get; set; }
        // Timestamps
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
