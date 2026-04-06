using InvestmentAnalyzer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentAnalyzer.Infrastructure.Database.Configurations;

public class UserSavedInvestmentConfiguration : IEntityTypeConfiguration<UserSavedInvestment>
{
    public void Configure(EntityTypeBuilder<UserSavedInvestment> builder)
    {
        builder.HasKey(us => new { us.UserId, us.InvestmentId });

        builder.Property(us => us.SavedAt).IsRequired();

        builder.HasOne(us => us.User)
            .WithMany(u => u.SavedInvestments)
            .HasForeignKey(us => us.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(us => us.Investment)
            .WithMany(i => i.SavedByUsers)
            .HasForeignKey(us => us.InvestmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}