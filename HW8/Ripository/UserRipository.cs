using HW8.Models;
using HW8.Ripository;

namespace HW8
{
    public class UserRipository : IUserRipository
    {
        public User GetUserById(int id)
        {
            var user = GetUsers().FirstOrDefault(x => (x.Id == id));
            if (user != null)
                return user;
            return null;
        }

        public List<User> GetUsers()
        {
            return Database.users;
        }

        public User? Login(string username, string password)
        {
            var user = GetUsers().FirstOrDefault(x=> (x.Natnalcode == username && x.PhoneNumber==password));
            if (user != null)
                return user;
            return null;
        }

    }
}
