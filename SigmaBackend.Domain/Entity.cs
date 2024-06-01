namespace SigmaBackend.Domain;

public abstract class Entity<TId> : IEntity
{
    public TId Id { get; set; }
}