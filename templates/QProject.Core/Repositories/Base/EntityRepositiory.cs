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
      return await query.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> Get(int id)
    {
      return await Includer(_context.Set<TEntity>()).FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task Add(TEntity entity)
    {
      await _context.Set<TEntity>().AddAsync(entity);
    }

    public Task Delete(TEntity entity)
    {
      _context.Set<TEntity>().Remove(entity);
      return Task.FromResult(default(object));
    }

    public Task Update(TEntity entity)
    {
      _context.Entry(entity).State = EntityState.Modified;
      return Task.FromResult(default(object));
    }

    public async Task Commit()
    {
      await _context.SaveChangesAsync();
    }

    protected virtual IQueryable<TEntity> Includer(IQueryable<TEntity> query)
    {
      return query;
    }
  }
}
