using HW8.Models;

namespace HW8.Ripository
{
    public interface IUserRipository
    {
        List<User> GetUsers();
        User GetUserById(int id);
        User Login(string username, string password);
        


    }
}
