using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class CashFlowConfiguration : IEntityTypeConfiguration<CashFlow>
{
    public void Configure(EntityTypeBuilder<CashFlow> builder)
    {
        builder.HasKey(cf => cf.CashFlowId);

        builder.Property(cf => cf.Name).IsRequired().HasMaxLength(100);
        builder.Property(cf => cf.Description).HasMaxLength(500);
        builder.Property(cf => cf.CashFlowType).IsRequired().HasMaxLength(50);
        builder.Property(cf => cf.Currency).IsRequired().HasMaxLength(3);
        builder.Property(cf => cf.CashFlowAmount).HasPrecision(18, 2).IsRequired();
    }
}