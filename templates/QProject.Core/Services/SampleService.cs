using QProject.Core.Models;
using QProject.Core.Repositories.Base;
using QProject.Core.Services.Base;

namespace QProject.Core.Services
{
  public class SampleService : EntityService<SampleEntity>, ISampleService
  {
    public SampleService(IEntityRepository<SampleEntity> repo) : base(repo)
    {
    }
  }
}