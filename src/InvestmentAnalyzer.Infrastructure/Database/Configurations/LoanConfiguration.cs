using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(l => l.LoanId);

        builder.Property(l => l.LoanAmount).HasPrecision(18, 2).IsRequired();
        builder.Property(l => l.Rate).HasPrecision(5, 4).IsRequired();
        builder.Property(l => l.LoanType).IsRequired().HasMaxLength(50);

        // Yield is a computed property — not mapped to a column
        builder.Ignore(l => l.Yield);
    }
}