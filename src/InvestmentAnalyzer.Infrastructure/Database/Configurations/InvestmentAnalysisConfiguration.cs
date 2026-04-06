using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class InvestmentAnalysisConfiguration : IEntityTypeConfiguration<InvestmentAnalysis>
{
    public void Configure(EntityTypeBuilder<InvestmentAnalysis> builder)
    {
        builder.HasKey(a => a.InvestmentAnalysisId);

        builder.Property(a => a.EstimatedValue).HasPrecision(18, 2);
        builder.Property(a => a.AvgPricePerM2Area).HasPrecision(18, 2);
        builder.Property(a => a.ExpectedRentMonthly).HasPrecision(18, 2);
        builder.Property(a => a.OperatingCostMonthly).HasPrecision(18, 2);
        builder.Property(a => a.NetYield).HasPrecision(5, 4);
        builder.Property(a => a.GrossYield).HasPrecision(5, 4);
        builder.Property(a => a.CashFlow).HasPrecision(18, 2);
        builder.Property(a => a.InvestmentScore).HasPrecision(5, 2);
        builder.Property(a => a.RiskScore).HasPrecision(5, 2);
        builder.Property(a => a.CreatedAt).IsRequired();
    }
}