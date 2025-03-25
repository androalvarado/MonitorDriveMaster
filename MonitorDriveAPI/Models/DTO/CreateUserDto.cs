namespace MonitorDriveAPI.Models.DTO
{
    public class CreateUserDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Image { get; set; }
    }
}
