namespace MonitorDriveAPI.Models.DTO
{
    public class UpdateUserDto
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public string? Image { get; set; }
    }
}
