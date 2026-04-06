namespace InvestmentAnalyzer.Core.Model
{
    public class Cash
    {
        public Guid CashId { get; set; }
        public decimal CashAmount { get; set; }

        public Guid InvestmentId { get; set; }
        public Investment Investment { get; set; } = null!;
    }
}