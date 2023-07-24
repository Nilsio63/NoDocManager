using Microsoft.EntityFrameworkCore;
using NoDocManager.Abstractions.Models;
using NoDocManager.Data.Abstractions.Repositories;
using NoDocManager.Data.Context;

namespace NoDocManager.Data.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly NoDocManagerContext _dbContext;

    protected IQueryable<TEntity> BaseQuery => _dbContext.Set<TEntity>();

    protected BaseRepository(NoDocManagerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity?> GetByIdAsync(string id, CancellationToken ct = default)
    {
        return await BaseQuery
            .Where(o => o.Id == id)
            .FirstOrDefaultAsync(ct);
    }

    public async Task<List<TEntity>> GetAllAsync(CancellationToken ct = default)
    {
        return await BaseQuery.ToListAsync(ct);
    }
}
