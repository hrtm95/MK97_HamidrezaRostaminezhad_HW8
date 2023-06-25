using HW8.Models;

namespace HW8.Ripository
{
    public interface IUserRipository
    {
        List<User> GetUsers();
        User GetUserByEmail(string email);
        User Login(string username, string password);
        


    }
}
