using Server.DtoModels;
using Server.Entities;

namespace Server.Interfaces
{
 public interface IUserRepository 
 {
/*⚡*/  Task<IEnumerable<AppUser>>  GetUsersAsync();

  /*⚡*/ Task<AppUser> GetUserByIdAsync(int id);

 /*⚡*/ Task<MemberDto> GetUserByUsernameAsync(string username);
  
   /*⚡*/ Task<bool> SaveAllChangesAsync();

    /*⚡*/ void UpdateUser(AppUser user);
  
  
  
  
  // IQueryable<AppUser> GetUsersQ();


    }
}
