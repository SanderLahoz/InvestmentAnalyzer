using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class CashConfiguration : IEntityTypeConfiguration<Cash>
{
    public void Configure(EntityTypeBuilder<Cash> builder)
    {
        builder.HasKey(c => c.CashId);
        builder.Property(c => c.CashAmount).HasPrecision(18, 2).IsRequired();
    }
}