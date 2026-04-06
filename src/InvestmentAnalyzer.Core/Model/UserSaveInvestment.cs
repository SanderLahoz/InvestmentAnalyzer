namespace InvestmentAnalyzer.Core.Model
{
    public class UserSavedInvestment
    {
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        public Guid InvestmentId { get; set; }
        public Investment Investment { get; set; } = null!;

        public DateTime SavedAt { get; set; }
    }
}