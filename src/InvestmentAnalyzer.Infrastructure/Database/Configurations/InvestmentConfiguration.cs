using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
{
    public void Configure(EntityTypeBuilder<Investment> builder)
    {
        builder.HasKey(i => i.InvestmentId);

        builder.Property(i => i.PurchasePrice).HasPrecision(18, 2).IsRequired();
        builder.Property(i => i.Currency).IsRequired().HasMaxLength(3);

        builder.HasOne(i => i.Loan)
            .WithOne(l => l.Investment)
            .HasForeignKey<Loan>(l => l.InvestmentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Cash)
            .WithOne(c => c.Investment)
            .HasForeignKey<Cash>(c => c.InvestmentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(i => i.CashFlows)
            .WithOne(cf => cf.Investment)
            .HasForeignKey(cf => cf.InvestmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}