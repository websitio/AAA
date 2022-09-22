using Server.Entities;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.BaseControllers;
using Server.Interfaces;

namespace API.Controllers
{
    public class UsersController : UserControllerBase
    {
        public IUserRepository _repo { get; }
        
        public UsersController(IUserRepository repo)
        {       _repo = repo;          }

        [HttpGet]
       public async Task<ActionResult<List<AppUser>>> GetUsers()
            {   var users=   await _repo.GetUsersAsync();
                return Ok(users);
            }

           [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _repo.GetUserByIdAsync(id);
        }
    }
}