namespace server.Models
{
    public class RegisterDto
    {
        public string Username { get; set; }
        //no camel case required for Dto's
        public string Password { get; set; }

    }
}
