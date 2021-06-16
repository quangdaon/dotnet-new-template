using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QProject.Core.Data;
using QProject.Core.Models.Base;

namespace QProject.Core.Repositories.Base
{
  public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : Entity
  {
    protected readonly QProjectContext _context;
    public EntityRepository(QProjectContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
      var query = Includer(_context.Set<TEntity>());
      return await query.ToListAsync();
    }

    public async Task<TEntity> Get(int id)
    {
      return await Includer(_context.Set<TEntity>()).FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task Add(TEntity entity)
    {
      await BeforeCreateAsync(entity);
      await BeforeSaveAsync(entity);
      await _context.Set<TEntity>().AddAsync(entity);
    }

    public async Task Delete(int id)
    {
      var entity = await _context.Set<TEntity>().FindAsync(id);
      if (entity == null)
      {
        return;
      }

      _context.Set<TEntity>().Remove(entity);
    }

    public async Task Update(TEntity entity)
    {
      await BeforeSaveAsync(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task Commit()
    {
      await _context.SaveChangesAsync();
    }

    protected virtual IQueryable<TEntity> Includer(IQueryable<TEntity> query)
    {
      return query;
    }

    protected virtual Task BeforeCreateAsync(TEntity model)
    {
      return Task.FromResult(default(object));
    }

    protected virtual Task BeforeSaveAsync(TEntity model)
    {
      return Task.FromResult(default(object));
    }
  }
}
