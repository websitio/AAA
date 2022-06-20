using API.Entities;

namespace server.Interfaces
{
    public interface Interface
    {
    }



    public interface IUserRepository {

    IEnumerable<AppUser>  GetUsers();
            

    AppUser GetUser(int id);





    // IQueryable<AppUser> GetUsersQ();


    }

    


}
