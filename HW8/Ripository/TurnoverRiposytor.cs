using HW8.Models;

namespace HW8.Ripository
{
    public class TurnoverRiposytor : ITurnoverRiposytory
    {
        public bool AddTurnover(Turnover turnover)
        {
            if (turnover == null)
            {
                return false;
            }
            int TId= Database.Turnovers.Max(x => x.Id);
            var tempTurnover = new Turnover()
            {
                Id = TId+1,
                Credit = turnover.Credit,
                Debit = turnover.Debit,
                Description = turnover.Description,
                Name = turnover.Name,
                TransactionTime = DateTime.Now,
                userId = turnover.userId
                
            };
            Database.Turnovers.Add(tempTurnover);
            return true;


        }

        public List<Turnover>? Turnovers(int userid)
        {
            var Turnovers = Database.Turnovers.Where(x => x.userId == userid).ToList();
            if (Turnovers != null)
            {
                return Turnovers;
            }
            return null;

        }

        public double? remaining (int userid)
        {
            var Turnovers = Database.Turnovers.Where(x => x.userId == userid).ToList();
            if (Turnovers != null)
            {
                double tempRemaining = 0;
                foreach (var turnover in Turnovers)
                {
                    tempRemaining += turnover.Credit;
                    tempRemaining -= turnover.Debit;
                }
                return tempRemaining;
            }
            return null;
        }
    }
}
