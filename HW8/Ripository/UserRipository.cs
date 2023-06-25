using HW8.Models;
using HW8.Ripository;

namespace HW8
{
    public class UserRipository : IUserRipository
    {
        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return Database.users;
        }

        public bool Login(string username, string password)
        {
            var users = GetUsers().FirstOrDefault(x=> x.Natnalcode == username && x.Mobile=password);
            if (users != null)
                return true;
            return false;
        }
    }
}
