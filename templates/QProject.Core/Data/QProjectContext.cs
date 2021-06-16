using Microsoft.EntityFrameworkCore;
using QProject.Core.Models;

namespace QProject.Core.Data
{
  public class MainContext : DbContext
  {
    public DbSet<SampleEntity> SampleEntities { get; set; }

    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);
    }
  }
}
