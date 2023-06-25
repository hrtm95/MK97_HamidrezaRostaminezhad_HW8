using HW8.Models;

namespace HW8
{
    public static class Database
    {
       public static List<User> users = new List<User>()
        {
            new User(){Id = 1 ,Name = "Hamid",LastName = "Rostami",PhoneNumber = "1",Natnalcode = "1" },
            new User(){Id = 2 ,Name = "mamad",LastName = "reza",PhoneNumber = "2",Natnalcode = "2"  },
            new User(){Id = 3 ,Name = "ahmad",LastName = "hosyeni",PhoneNumber = "3",Natnalcode = "3"  },
            new User(){Id = 4 ,Name = "jafar",LastName = "gholami",PhoneNumber = "4",Natnalcode = "4" },
            new User(){Id = 5 ,Name = "akbar",LastName = "bagheri",PhoneNumber = "5",Natnalcode = "5"  }
        };
    }
}
