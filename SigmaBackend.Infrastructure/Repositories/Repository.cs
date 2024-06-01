using Microsoft.EntityFrameworkCore;
using SigmaBackend.Domain;

namespace SigmaBackend.Infrastructure.Repositories;

public abstract class Repository<TEntity, TId>(DbContext context) : IRepository<TEntity>
    where TEntity : Entity<TId>
{
    public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    { 
        var entityEntry = await context.Set<TEntity>()
            .AddAsync(entity, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        
        return entityEntry.Entity;
    }
}