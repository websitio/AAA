using Microsoft.AspNetCore.Mvc;
using Server.Controllers.BaseControllers;
using Server.Interfaces;
using AutoMapper;
using Server.Entities;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : UserControllerBase
    {
        public IUserRepository _repo { get; }
        private readonly IMapper _mapper;
        
        public UsersController(IUserRepository repo, IMapper mapper)
        {       _repo = repo;          _mapper = mapper; }

#region old newer way
    //  [HttpGet]  /*⚡*/
    //  public async Task<ActionResult<IEnumerable<MemberDto>>> 
    //  GetUsers()
    //         { 
    //       /*   var users = await _repo.GetMembersAsync();   return Ok(users);*/
                
    //           var users=   await _repo.GetUsersAsync();
    //           var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
    //              return Ok(usersToReturn); 
    //         }
#endregion

[HttpGet]  
public async Task<ActionResult<IEnumerable<AppUser>>> 
     GetUsers()
            { var users= await _repo.GetUsersAsync();
               return Ok(users);
            }


 [HttpGet("{username}")] 
       public async Task<ActionResult<AppUser>> 
       GetUser(string username)
        {
            return await _repo.GetUserByUsernameAsync(username);
      
        }
    }
}