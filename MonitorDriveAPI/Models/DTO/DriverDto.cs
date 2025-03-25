namespace MonitorDriveAPI.Models.DTO
{
    public class DriverDto
    {
        public Guid Id { get; set; }
        public required string Country { get; set; }
        public required string Language { get; set; }
        public required string Currency { get; set; }
        public double? Stars { get; set; }
        public required string Metrics { get; set; }
        public required double Target { get; set; }
        public required string Noun { get; set; }
        public UserDto User { get; set; }

        public DateTime? Created_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}
