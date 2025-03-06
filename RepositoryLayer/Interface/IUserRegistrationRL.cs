using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        bool RegisterUser(UserDTO user);
        (string Token, bool IsCached) Login(LoginDTO loginDTO);

    }
}
