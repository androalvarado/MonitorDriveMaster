namespace MonitorDriveAPI.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string  Password { get; set; }
        public string? Image { get; set; }
        
        public DateTime? Created_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}
