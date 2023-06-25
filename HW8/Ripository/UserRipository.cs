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

        public User Login(string username, string password)
        {
            var user = GetUsers().FirstOrDefault(x=> (x.Natnalcode == username && x.PhoneNumber==password));
            if (user != null)
                return user;
            return null;
        }
    }
}
