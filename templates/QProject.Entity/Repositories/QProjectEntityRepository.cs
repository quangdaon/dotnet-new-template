using QProject.Core.Data;
using QProject.Core.Entities;
using QProject.Core.Repositories.Base;

namespace QProject.Core.Repositories
{
  public class QProjectEntityRepository : EntityRepository<QProjectEntity>, IQProjectEntityRepository
  {
    public QProjectEntityRepository(QProjectContext context) : base(context)
    {
    }
  }
}
