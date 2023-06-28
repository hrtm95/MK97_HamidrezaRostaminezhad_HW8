using HW8.Models;

namespace HW8.Ripository
{
    public class TurnoverRiposytor : ITurnoverRiposytory
    {
        public List<Turnover>? Turnovers(int userid)
        {
            var Turnovers = Database.Turnovers.Where(x => x.userId == userid).ToList();
            if (Turnovers != null)
            {
                return Turnovers;
            }
            return null;

        }
    }
}
