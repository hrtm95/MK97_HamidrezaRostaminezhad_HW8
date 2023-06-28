using HW8.Models;

namespace HW8.Ripository
{
    public interface ITurnoverRiposytory
    {
        List<Turnover>? Turnovers(int id);
        bool AddTurnover(Turnover turnover);
        double? remaining(int userid);
    }
}
