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
        public static List<Turnover> Turnovers = new List<Turnover>()
        {
            new Turnover(){Id = 1 ,Name ="tejarat" , Credit = 1000 , Description = "First" , userId = 1 , TransactionTime = DateTime.Parse("2015-05-16") },
            new Turnover(){Id = 2 ,Name ="tejarat" , Credit = 500 , Description = "secound" , userId = 1 , TransactionTime = DateTime.Parse("2015-05-17") },
            new Turnover(){Id = 3 ,Name ="melat" , Credit = 2000 , Description = "First" , userId = 2 , TransactionTime = DateTime.Parse("2015-05-18") },
            new Turnover(){Id = 4 ,Name ="melat" , Credit = 1000 , Description = "secound" , userId = 2 , TransactionTime = DateTime.Parse("2015-05-19") },
            new Turnover(){Id = 5 ,Name ="tejarat" , Credit = 1000 , Description = "First" , userId = 3 , TransactionTime = DateTime.Parse("2015-05-20") },
        };
    }
}
