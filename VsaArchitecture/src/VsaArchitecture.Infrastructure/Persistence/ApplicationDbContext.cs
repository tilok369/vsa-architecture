using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VsaArchitecture.Application.Entities;

namespace VsaArchitecture.Infrastructure.Persistence;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
    {
        
    }


    public DbSet<User> Users { get; set; }
    public DbSet<UserLoginHistory> UserLoginHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
