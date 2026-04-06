using InvestmentAnalyzer.Core.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvestmentAnalyzer.Infrastructure.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Investment> Investments => Set<Investment>();
    public DbSet<Loan> Loans => Set<Loan>();
    public DbSet<Cash> Cash => Set<Cash>();
    public DbSet<CashFlow> CashFlows => Set<CashFlow>();
    public DbSet<InvestmentAnalysis> InvestmentAnalyses => Set<InvestmentAnalysis>();
    public DbSet<AreaStatistics> AreaStatistics => Set<AreaStatistics>();
    public DbSet<UserSavedInvestment> UserSavedInvestments => Set<UserSavedInvestment>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Picks up all IEntityTypeConfiguration<T> classes in this assembly automatically
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}