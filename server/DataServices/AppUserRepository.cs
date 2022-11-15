using Server.Entities;
using Microsoft.EntityFrameworkCore;
using Server.Interfaces;
using Server.DtoModels;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace Server.DataServices
{
    public class AppUserRepository : IUserRepository
    {
        private DataContext _context;        
        private readonly IMapper _mapper;
        
        public AppUserRepository(DataContext context, IMapper mapper)
        {             _context = context;     _mapper = mapper;     }




     public async Task<IEnumerable<AppUser>> 
     GetUsersAsync() 
          {               return await _context.Users
                                         .Include(cat=>cat.UserCategories)
                                         .ThenInclude(co=>co.CostAmounts)
                                         .ToListAsync();       
          }






              public async Task<AppUser>
              GetUserByIdAsync(int id)
                      {  return await _context.Users
                                         .FindAsync(id);   }

#region later new option
            //   public async Task<IEnumerable<AppUser>> 
            //   GetUsersAsync() 
            //           {               return await _context.Users
            //                              .Include(cat=>cat.UserCategories)
            //                              .ToListAsync();        }



        //       public async Task <MemberDto>
        //       GetUserByUsernameAsync(string username)    
        //       {  return await _context.Users.Where(x => x.UserName == username)
        //                                  .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
        //                                  .SingleOrDefaultAsync();              }
#endregion
     
     
     
     public async Task <AppUser>
                   GetUserByUsernameAsync(string username)    
                   {  return await _context.Users
                      .Include(cat=>cat.UserCategories)
                                         .SingleOrDefaultAsync(x => x.UserName == username);              }



              public async Task<bool> 
              SaveAllChangesAsync()  
                      { return await _context
                                         .SaveChangesAsync() > 0;  }

              public void 
              UpdateUser(AppUser user) 
                      {  _context.Entry(user).State = EntityState.Modified;     }

              public async Task<IEnumerable<MemberDto>> 
              GetMembersAsync() 
                      {   return await _context.Users
                                         .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                                         .ToListAsync();   }

              public async Task<MemberDto> 
              GetMemberAsync(string username) 
                      {  return await _context.Users
                                        .Where(x=> x.UserName==username)
                                        .Select(user=>  
                                            new MemberDto {Id=user.Id, Username=user.UserName})
                                        .SingleOrDefaultAsync();
                      }

                

                      #region pre async stubs
                      //public IEnumerable<AppUser> GetUsers()
                      //{
                      //    return _context.Users.OrderBy(u => u.UserName).ToList();
                      //}

                      //public AppUser GetUser(int id)
                      //{
                      //    throw new NotImplementedException();
                      //}
                          /*097@5m*/  
                      #endregion
                  }
              }
