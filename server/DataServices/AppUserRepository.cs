using API.Entities;
using server.Interfaces;

namespace server.DataServices
{
    public class AppUserRepository : IUserRepository
    {
          public IEnumerable<AppUser> GetUsers()
        {
            throw new NotImplementedException();
        }
        
        public AppUser GetUser(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
