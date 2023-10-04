using VsaArchitecture.Application.Entities;

namespace VsaArchitecture.Infrastructure.Persistence.Configurations.Users;

public class UserTypeConfiguration: BaseEntityTypeConfiguration<User>
{
    public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);
        builder.Property(x=>x.UserName)
               .IsRequired(true).HasMaxLength(50);
        builder.Property(x => x.Password)
               .IsRequired(true).HasMaxLength(15);
        builder.Property(x => x.Email)
               .HasMaxLength(100);
        builder.Property(x => x.Phone)
               .HasMaxLength(20);

        builder.HasMany(x=>x.UserLoginHistory);
    }
}
