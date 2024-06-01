using SigmaBackend.Domain;

namespace SigmaBackend.Infrastructure.Repositories;

public interface IRepository<TEntity>
    where TEntity : IEntity
{
    Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default);
}