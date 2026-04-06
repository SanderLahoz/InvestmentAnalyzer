using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class AreaStatisticsConfiguration : IEntityTypeConfiguration<AreaStatistics>
{
    public void Configure(EntityTypeBuilder<AreaStatistics> builder)
    {
        builder.HasKey(a => a.AreaStatisticsId);

        builder.Property(a => a.ZipCode).IsRequired().HasMaxLength(20);
        builder.HasIndex(a => a.ZipCode).IsUnique();

        builder.Property(a => a.AvgPricePerM2).HasPrecision(18, 2);
        builder.Property(a => a.AvgRentPerM2).HasPrecision(18, 2);
        builder.Property(a => a.PriceGrowth1Y).HasPrecision(5, 4);
        builder.Property(a => a.PriceGrowth5Y).HasPrecision(5, 4);
        builder.Property(a => a.LastUpdated).IsRequired();
    }
}