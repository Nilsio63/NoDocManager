namespace NoDocManager.Data.Abstractions.Repositories;

public interface IBaseRepository<TEntity>
{
    Task<TEntity?> GetByIdAsync(string id, CancellationToken ct = default);
    Task<List<TEntity>> GetAllAsync(CancellationToken ct = default);
}
