using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Primitives;

public abstract class AggregateRoot
{
    
    private readonly List<DomainEvents.DomainEvent> _domainEvents = new();

    [NotMapped] public ICollection<DomainEvents.DomainEvent> GetDomainEvents => _domainEvents;

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public Guid? DeletedBy { get; set; }

    protected void Raise(DomainEvents.DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}