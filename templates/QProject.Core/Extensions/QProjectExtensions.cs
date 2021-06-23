using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QProject.Core.Data;
#if (IncludeSample)
using QProject.Core.Repositories;
using QProject.Core.Services;
#endif

namespace QProject.Core.Extensions
{
  public static class QProjectExtensions
  {
    public static void AddQProject(this IServiceCollection services, IConfiguration config)
    {
      AddRepositories(services);
      AddServices(services);

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

    private static void AddServices(IServiceCollection services)
    {
#if (IncludeSample)
      services.AddTransient<ISampleService, SampleService>();
#endif
    }
  }
}
