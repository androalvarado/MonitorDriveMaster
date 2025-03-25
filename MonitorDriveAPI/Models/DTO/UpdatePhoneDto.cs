namespace MonitorDriveAPI.Models.DTO
{
    public class UpdatePhoneDto
    {
        public required string Model { get; set; }
        public required double Value { get; set; }
        public required double Line_bill { get; set; }
        public required string Percent_usage { get; set; }
        public required double Depreciation { get; set; }
    }
}
