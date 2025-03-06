using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        (string Token, bool IsCached) loginBL(LoginDTO loginDTO);

        bool RegisterUser(UserDTO user);
    }
}
