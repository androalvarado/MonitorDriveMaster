using Microsoft.EntityFrameworkCore;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public SqlUserRepository(ApplicationDbContext _context) 
        { 
            this._context = _context;
        }

        public async Task<User> CreateAsync(User user)
        {
            user.Created_at = DateTime.Now;
            user.Update_at = DateTime.Now;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User?> DeleteAsync(Guid id)
        {
            var existinUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (existinUser == null)
                return null;

            _context.Users.Remove(existinUser);
            await _context.SaveChangesAsync();
            return existinUser;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User?> UpdateAsync(Guid id, User user)
        {
            var existUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (existUser == null)
                return null;

            existUser.Name = user.Name;
            existUser.Password = user.Password;
            existUser.Image = user.Image;
            existUser.Update_at = DateTime.Now;

            await _context.SaveChangesAsync();
            return existUser;

        }
    }
}
 