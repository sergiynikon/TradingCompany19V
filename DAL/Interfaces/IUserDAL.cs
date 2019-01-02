using DTO;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        int AddUser(UserDTO user);
        UserDTO ValidateLogin(string login, string password);
    }
}
