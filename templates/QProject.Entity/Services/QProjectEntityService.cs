using QProject.Core.Models;
using QProject.Core.Repositories.Base;
using QProject.Core.Services.Base;

namespace QProject.Core.Services
{
  public class QProjectEntityService : EntityService<QProjectEntity>, IQProjectEntityService
  {
    public QProjectEntityService(IEntityRepository<QProjectEntity> repo) : base(repo)
    {
    }
  }
}