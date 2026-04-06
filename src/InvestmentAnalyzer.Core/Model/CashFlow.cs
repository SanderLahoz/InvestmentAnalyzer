namespace InvestmentAnalyzer.Core.Model
{
    public class CashFlow
    {
        public Guid CashFlowId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CashFlowType { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public decimal CashFlowAmount { get; set; }

        public Guid InvestmentId { get; set; }
        public Investment Investment { get; set; } = null!;
    }
}