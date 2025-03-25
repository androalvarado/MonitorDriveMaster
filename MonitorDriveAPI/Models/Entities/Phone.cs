namespace MonitorDriveAPI.Models.Entities
{
    public class Phone
    {
        public Guid Id { get; set; }
        public required string Model { get; set; }
        public required double Value { get; set; }
        public required double Line_bill { get; set; }
        public required string Percent_usage { get; set; }
        public required double Depreciation { get; set; }
        //Navigation Properties
        public Guid DriverId { get; set; }
        public Driver? Driver { get; set; }
        // Time Control
        public DateTime? Created_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}
