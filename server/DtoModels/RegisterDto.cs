using System.ComponentModel.DataAnnotations;

namespace Server.DtoModels
{
    public class RegisterDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
