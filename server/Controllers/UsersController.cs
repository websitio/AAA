using Microsoft.AspNetCore.Mvc;
using server.Controllers.BaseControllers;
using server.Interfaces;
using server.Models;

namespace server.Controllers
{
    public class UsersController : UserControllerBase
    {

        private readonly IUserRepository _userRepository;

                public UsersController(IUserRepository userRepository )
                {
                    _userRepository=userRepository;
                }



                 [HttpGet]
               public async Task<ActionResult<IEnumerable<AppUserDto>>> GetUsers()
                {
                  var users = await _userRepository.GetUsersAsync();
                  return Ok(users);
                }

    }
}
