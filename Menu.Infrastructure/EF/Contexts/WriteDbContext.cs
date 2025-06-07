using Menu.Domain.Entities;
using Menu.Domain.ValueObjects;
using Menu.Infrastructure.EF.Config;
using Microsoft.EntityFrameworkCore;

namespace Menu.Infrastructure.EF.Contexts;

internal sealed class WriteDbContext : DbContext
{
    public DbSet<SampleEntity> SampleEntities { get; set; }



    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("SampleEntity");

        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<SampleEntity>(configuration);
        modelBuilder.ApplyConfiguration<SampleEntityItem>(configuration);
    }
}
