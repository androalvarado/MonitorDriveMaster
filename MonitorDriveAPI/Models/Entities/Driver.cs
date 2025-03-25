namespace MonitorDriveAPI.Models.Entities
{
    public class Driver
    {
        public Guid Id { get; set; }
        public required string Country { get; set; }
        public required string Language { get; set; }
        public required string Currency { get; set; }
        public double? Stars { get; set; }
        public required string Metrics { get; set; }
        public required double Target { get; set; }
        public required string Noun { get; set; }
        
        public Guid UserId { get; set; }
        public required User User { get; set; }
        
        public DateTime? Created_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}
