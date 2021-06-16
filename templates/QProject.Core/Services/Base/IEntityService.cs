using System.Collections.Generic;
using System.Threading.Tasks;
using QProject.Core.Models.Base;

namespace QProject.Core.Services.Base
{
  public interface IEntityService<TEntity> where TEntity: Entity
  {
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> Get(int id);
    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(int id);
  }
}