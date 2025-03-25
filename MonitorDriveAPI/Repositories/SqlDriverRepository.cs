using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public class SqlDriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _context;

        public SqlDriverRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<Driver> CreateAsync(Driver driver)
        {
            driver.Created_at = DateTime.Now;
            driver.Update_at = DateTime.Now;
            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver?> DeleteAsync(Guid id)
        {
           var existingDriver = await _context.Drivers.FirstOrDefaultAsync(x => x.Id == id);

            if (existingDriver == null) 
            { 
                return null;
            }

            _context.Drivers.Remove(existingDriver);
            await _context.SaveChangesAsync();
            return existingDriver;
        }

        public async Task<List<Driver>> GetAllAsync()
        {
            return await _context.Drivers.Include("User").ToListAsync();
        }

        public async Task<Driver?> GetByIDAsync(Guid id)
        {
            return await _context.Drivers
                .Include("User")
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Driver?> UpdateAsync(Guid id, Driver driver)
        {
            var existingDriver = await _context.Drivers.FirstOrDefaultAsync(x => x.Id == id);

            if (existingDriver == null)
                return null;

            existingDriver.Country = driver.Country;
            existingDriver.Language = driver.Language;
            existingDriver.Currency = driver.Currency;
            existingDriver.Stars = driver.Stars;
            existingDriver.Metrics = driver.Metrics;
            existingDriver.Target = driver.Target;
            existingDriver.Noun = driver.Noun;
            existingDriver.Update_at = DateTime.Now;

            await _context.SaveChangesAsync();

            return existingDriver;
        }
    }
}
