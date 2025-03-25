using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public interface IPhoneRepository
    {
        Task<Phone> CreateAsync(Phone phone);

        Task<List<Phone>> GetAllAsync();

        Task<Phone?> GetByIdAsync(Guid id);

        Task<Phone?> UpdateAsync(Guid id, Phone phone);

        Task<Phone?> DeleteAsync(Guid id);

    }
}
