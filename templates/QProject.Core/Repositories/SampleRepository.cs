using QProject.Core.Data;
using QProject.Core.Entities;
using QProject.Core.Repositories.Base;

namespace QProject.Core.Repositories
{
  public class SampleRepository : EntityRepository<SampleEntity>, ISampleRepository
  {
    public SampleRepository(QProjectContext context) : base(context)
    {
    }
  }
}
