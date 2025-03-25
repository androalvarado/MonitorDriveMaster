using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> CreateAsync(Vehicle vehicle);

        Task<List<Vehicle>> GetAllAsync();
    }
}
