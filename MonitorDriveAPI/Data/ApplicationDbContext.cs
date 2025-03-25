using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data for User
            var users = new List<User>()
            {
                new User()
                {
                    Id = Guid.Parse("d68c8b1d-2cf4-4f16-8dab-f6b49a5fce47"),
                    Name = "Andrew",
                    Password = "d*fTcq9w%qJ",
                    Email = "andrew@email.com",
                    Image = "https://images.pexels.com/photos/697509/pexels-photo-697509.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Created_at = DateTime.Now,
                    Update_at = DateTime.Now,
                },
                new User()
                {
                    Id = Guid.Parse("3e7be918-25ea-4407-9fcc-a6c0608b71af"),
                    Name = "Sara",
                    Password = "V4Z9!yQUG!k",
                    Email = "sara@email.com",
                    Image = "https://images.pexels.com/photos/3779760/pexels-photo-3779760.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Created_at = DateTime.Now,
                    Update_at = DateTime.Now,
                },
                new User()
                {
                    Id = Guid.Parse("e4eb9db7-793d-41cf-803f-755e7a495ab5"),
                    Name = "Roger",
                    Password = "Fr5XQvQ&gbT",
                    Email = "roger@email.com",
                    Image = "https://images.pexels.com/photos/3760260/pexels-photo-3760260.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Created_at = DateTime.Now,
                    Update_at = DateTime.Now,
                }
            };

            // Seed Data to the database
            modelBuilder.Entity<User>().HasData(users);

        }
    }
}
