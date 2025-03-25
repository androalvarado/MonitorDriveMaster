using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public class SqlVehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public SqlVehicleRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<Vehicle> CreateAsync(Vehicle vehicle)
        {
            vehicle.Created_at = DateTime.Now;
            vehicle.Updated_at = DateTime.Now;
            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<List<Vehicle>> GetAllAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }
    }
}
