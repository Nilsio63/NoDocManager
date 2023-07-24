using Microsoft.EntityFrameworkCore;

namespace NoDocManager.Data.Context;

public class NoDocManagerContext : DbContext
{
    public NoDocManagerContext(DbContextOptions<NoDocManagerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
