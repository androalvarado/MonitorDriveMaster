namespace MonitorDriveAPI.Models.DTO
{
    public class CreateVehicleDto
    {
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public float Miles { get; set; }
        public float Percent_usage { get; set; }
        public float Insurage { get; set; }
        public string? Image { get; set; }
        public float Mpg { get; set; }
        public float Autonomy { get; set; }

        public Guid DriverId { get; set; }
    }
}
