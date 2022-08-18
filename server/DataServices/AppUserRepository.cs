using Server.Entities;
using Microsoft.EntityFrameworkCore;
using Server.Interfaces;
using System.Linq;

namespace Server.DataServices
{
    public class AppUserRepository : IUserRepository
    {
        private DataContext _context;
        public AppUserRepository(DataContext context)
        {
            _context = context;
        }

      
        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        #region 091@5 EFinternal
        public async Task<bool> SaveAllChangesAsync()
        { return await _context.SaveChangesAsync() > 0;  }

        public void UpdateUser(AppUser user)
        {                     _context.Entry(user).State = EntityState.Modified;     }
        #endregion



        #region pre async stubs
        //public IEnumerable<AppUser> GetUsers()
        //{
        //    return _context.Users.OrderBy(u => u.UserName).ToList();
        //}

        //public AppUser GetUser(int id)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
