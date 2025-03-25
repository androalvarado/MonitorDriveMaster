using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public interface IDriverRepository
    {
        Task<Driver> CreateAsync(Driver driver);
        Task<Driver?> GetByIDAsync(Guid id);
        Task<List<Driver>> GetAllAsync();
        Task<Driver?> UpdateAsync(Guid id, Driver driver);
        Task<Driver?> DeleteAsync(Guid id);
    }
}
