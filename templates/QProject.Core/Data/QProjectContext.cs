using Microsoft.EntityFrameworkCore;
using QProject.Core.Entities;

namespace QProject.Core.Data
{
  public class QProjectContext : DbContext
  {
#if (IncludeSample)
    public DbSet<SampleEntity> SampleEntities { get; set; }

#endif
    public QProjectContext(DbContextOptions<QProjectContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(QProjectContext).Assembly);
    }
  }
}
