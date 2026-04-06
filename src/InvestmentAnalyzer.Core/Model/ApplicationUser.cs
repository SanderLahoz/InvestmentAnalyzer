using Microsoft.AspNetCore.Identity;

namespace InvestmentAnalyzer.Core.Model
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserSavedInvestment> SavedInvestments { get; set; } = [];
    }
}