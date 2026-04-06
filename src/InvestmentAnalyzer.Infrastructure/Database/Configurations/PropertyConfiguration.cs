using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.HasKey(p => p.PropertyId);

        builder.Property(p => p.Address).IsRequired().HasMaxLength(200);
        builder.Property(p => p.City).IsRequired().HasMaxLength(100);
        builder.Property(p => p.ZipCode).IsRequired().HasMaxLength(20);
        builder.Property(p => p.EnergyLabel).HasMaxLength(5);
        builder.Property(p => p.PropertyType).IsRequired().HasMaxLength(50);

        builder.HasOne(p => p.Investment)
            .WithOne(i => i.Property)
            .HasForeignKey<Investment>(i => i.PropertyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.InvestmentAnalyses)
            .WithOne(a => a.Property)
            .HasForeignKey(a => a.PropertyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}