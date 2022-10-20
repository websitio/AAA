using Microsoft.AspNetCore.Mvc;
using Server.Controllers.BaseControllers;
using Server.Interfaces;
using Server.DtoModels;
using AutoMapper;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : UserControllerBase
    {
        public IUserRepository _repo { get; }
        private readonly IMapper _mapper;
        
        public UsersController(IUserRepository repo, IMapper mapper)
        {       _repo = repo;          _mapper = mapper; }





     [HttpGet]  /*⚡*/
     public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
            {   var users=   await _repo.GetUsersAsync();
                 var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
                 return Ok(usersToReturn);
            }










       [HttpGet("{id}")] /*⚡*/
       public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            var user =await _repo.GetUserByUsernameAsync(username);
            return _mapper.Map<MemberDto>(user);
        }
    }
}