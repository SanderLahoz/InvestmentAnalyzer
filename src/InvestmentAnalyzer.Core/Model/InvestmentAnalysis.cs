namespace InvestmentAnalyzer.Core.Model
{
    public class InvestmentAnalysis
    {
        public Guid InvestmentAnalysisId { get; set; }
        public decimal EstimatedValue { get; set; }
        public decimal AvgPricePerM2Area { get; set; }
        public decimal ExpectedRentMonthly { get; set; }
        public decimal OperatingCostMonthly { get; set; }
        public decimal NetYield { get; set; }
        public decimal GrossYield { get; set; }
        public decimal CashFlow { get; set; }
        public decimal InvestmentScore { get; set; }
        public decimal RiskScore { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = null!;
    }
}