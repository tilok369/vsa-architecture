using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VsaArchitecture.Application.Entities;

namespace VsaArchitecture.Infrastructure.Persistence.Configurations.Users;

public class UserLoginHistoryTypeConfiguration : IEntityTypeConfiguration<UserLoginHistory>
{
    public void Configure(EntityTypeBuilder<UserLoginHistory> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.IPAddress).HasMaxLength(128);
        builder.Property(x => x.UserAgent).HasMaxLength(128);

        builder.HasOne(x => x.User)
               .WithMany(x => x.UserLoginHistory)
               .HasForeignKey(x => x.UserId);
    }
}
