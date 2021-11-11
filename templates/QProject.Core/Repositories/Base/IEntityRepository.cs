using System.Collections.Generic;
using System.Threading.Tasks;
using QProject.Core.Entities.Base;

namespace QProject.Core.Repositories.Base
{
  public interface IEntityRepository<TEntity> where TEntity: Entity
  {
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> Get(int id);
    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
    Task Commit();
  }
}