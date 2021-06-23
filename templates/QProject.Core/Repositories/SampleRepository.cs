using QProject.Core.Data;
using QProject.Core.Models;
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
