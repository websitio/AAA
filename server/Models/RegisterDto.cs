using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class RegisterDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
