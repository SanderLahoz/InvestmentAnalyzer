namespace InvestmentAnalyzer.Core.Model
{
    public class Loan
    {
        public Guid LoanId { get; set; }
        public decimal LoanAmount { get; set; }
        public int LoanLifetime { get; set; }
        public string LoanType { get; set; } = string.Empty;
        public decimal Rate { get; set; }

        // Yield is derived (dashed in diagram) — calculated, not stored
        public decimal Yield => LoanAmount > 0 ? Rate / 100 * LoanAmount : 0;

        public Guid InvestmentId { get; set; }
        public Investment Investment { get; set; } = null!;
    }
}