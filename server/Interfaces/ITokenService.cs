using API.Entities;

namespace server.Interfaces
{
    public interface ITokenService
    {
        string CreateJWT(AppUser appUser);
    }
}
