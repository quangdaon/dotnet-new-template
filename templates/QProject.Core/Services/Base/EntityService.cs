using System.Collections.Generic;
using System.Threading.Tasks;
using QProject.Core.Models.Base;
using QProject.Core.Repositories.Base;

namespace QProject.Core.Services.Base
{
  public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : Entity
  {
    protected readonly IEntityRepository<TEntity> _repo;

    public EntityService(IEntityRepository<TEntity> repo)
    {
      _repo = repo;
    }

    virtual public async Task<IEnumerable<TEntity>> GetAll() => await _repo.GetAll();
    virtual public async Task<TEntity> Get(int id) => await _repo.Get(id);
    virtual public async Task Add(TEntity entity) => await _repo.Add(entity);
    virtual public async Task Update(TEntity entity) => await _repo.Update(entity);
    virtual public async Task Delete(int id)
    {
      var entity = await Get(id);
      if(entity == null) throw new System.Exception("Boo, you suck!"); // TODO
      
      await _repo.Delete(entity);
    }
  }
}