namespace HW8.Models
{
    public class Turnover
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string Name { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public DateTime TransactionTime { get; set; }
        public string Description { get; set; }
    }
}
