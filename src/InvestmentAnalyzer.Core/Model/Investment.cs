namespace InvestmentAnalyzer.Core.Model
{
    public class Investment
    {
        public Guid InvestmentId { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Currency { get; set; } = string.Empty;

        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = null!;

        public Loan? Loan { get; set; }
        public Cash? Cash { get; set; }

        public ICollection<CashFlow> CashFlows { get; set; } = [];
        public ICollection<UserSavedInvestment> SavedByUsers { get; set; } = [];
    }
}