using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VsaArchitecture.Application.Common;

namespace VsaArchitecture.Infrastructure.Persistence.Configurations;

public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : AuditableEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(x => x.CreatedOn).IsRequired();
        builder.Property(x=>x.CreatedBy).IsRequired().HasMaxLength(50);
        builder.Property(x=>x.LastModifiedBy).HasMaxLength(50);
    }
}
