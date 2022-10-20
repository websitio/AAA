using Server.Entities;
using Microsoft.EntityFrameworkCore;
using Server.Interfaces;
using Server.DtoModels;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using System.Linq;

namespace Server.DataServices
{
    public class AppUserRepository : IUserRepository
    {
        private DataContext _context;        private readonly IMapper _mapper;
        public AppUserRepository(DataContext context, IMapper mapper)
        {             _context = context;     _mapper = mapper;     }


/*⚡*/
        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {               return await _context.AppUsers.
                        Include(costs=>costs.CostAmounts).
                        ToListAsync();
        
             }



/*⚡*/
        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.AppUsers.FindAsync(id);
        }


/*⚡*/
public async Task <MemberDto>GetUserByUsernameAsync(string username)
{
  return await _context.AppUsers
                .Where(x => x.UserName == username)
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
}



/*⚡*/
        #region 091@5 EFinternal
        public async Task<bool> SaveAllChangesAsync()
        { return await _context.SaveChangesAsync() > 0;  }



/*⚡*/
        public void UpdateUser(AppUser user)
        {                     _context.Entry(user).State = EntityState.Modified;     }


      /*⚡*/  public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
          return await _context.AppUsers.ProjectTo<MemberDto>(_mapper.ConfigurationProvider).ToListAsync();
        }


      /*⚡*/  public async Task<MemberDto> GetMemberAsync(string username)
        {
         //   throw new NotImplementedException();
                        return await _context.AppUsers
                                                .Where(x=> x.UserName==username)
        /*097@5m*/                      .Select(user=> new MemberDto
                          {
                                        Id=user.Id,
                                        Username=user.UserName
                        }
                        
                        ).SingleOrDefaultAsync();
                                

        }


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
