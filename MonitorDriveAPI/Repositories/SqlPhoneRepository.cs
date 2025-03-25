using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public class SqlPhoneRepository : IPhoneRepository
    {
        private readonly ApplicationDbContext _context;

        public SqlPhoneRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<Phone> CreateAsync(Phone phone)
        {
            phone.Created_at = DateTime.Now;
            phone.Update_at = DateTime.Now;
            await _context.Phones.AddAsync(phone);
            await _context.SaveChangesAsync();
            return phone;
        }

        public async Task<Phone?> DeleteAsync(Guid id)
        {
            var exist = await _context.Phones.FirstOrDefaultAsync(x => x.Id == id);
            if (exist == null)
                return null;

            _context.Phones.Remove(exist);
            await _context.SaveChangesAsync();
            return exist;
        }

        public async Task<List<Phone>> GetAllAsync()
        {
            return await _context.Phones.ToListAsync();
        }

        public async Task<Phone?> GetByIdAsync(Guid id)
        {
            return await _context.Phones
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Phone?> UpdateAsync(Guid id, Phone phone)
        {
            var checkIfExist = await _context.Phones.FirstOrDefaultAsync(x => x.Id == id);

            if (checkIfExist == null)
                return null;

            checkIfExist.Update_at = DateTime.Now;
            checkIfExist.Model = phone.Model;
            checkIfExist.Value = phone.Value;
            checkIfExist.Line_bill = phone.Line_bill;
            checkIfExist.Percent_usage = phone.Percent_usage;
            checkIfExist.Depreciation = phone.Depreciation;

            await _context.SaveChangesAsync();

            return checkIfExist;
        }
    }
}
