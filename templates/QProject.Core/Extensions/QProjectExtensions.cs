using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QProject.Core.Data;

namespace QProject.Core.Extensions
{
  public static class QProjectExtensions
  {
    public static void AddQProject(this IServiceCollection services, IConfiguration config)
    {
      AddRepositories(services);

      services.AddDbContext<QProjectContext>(opt =>
        opt.UseSqlServer(
              config.GetConnectionString("QProjectDb"),
              b => b.MigrationsAssembly(typeof(QProjectContext).Assembly.FullName)),
                ServiceLifetime.Transient);
    }

    private static void AddRepositories(IServiceCollection services)
    {
#if (IncludeSample)
      services.AddTransient<ISampleRepository, SampleRepository>();
#endif
    }
  }
}
