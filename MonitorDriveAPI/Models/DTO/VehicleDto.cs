namespace MonitorDriveAPI.Models.DTO
{
    public class VehicleDto
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

        public DriverDto Driver { get; set; }

        public DateTime? Created_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}
