using API.Entities;
using Microsoft.AspNetCore.Mvc;
using server.Controllers.BaseControllers;
using server.DataServices;
using server.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace server.Controllers
{
    public class AccountController : AccountControllerBase
    {

        //   private readonly IAccountRepository _accountRespository;
        private readonly DataContext _context;


        public AccountController(DataContext context)
        {
            _context=context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(string username, string password)
                    {

            using var hmac = new HMACSHA512();

            var user = new AppUser
            {
                UserName = username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key

            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }

    }
}
