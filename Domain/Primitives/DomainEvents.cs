using MediatR;

namespace Domain.Primitives;

public class DomainEvents
{
    public record DomainEvent(Guid Id) : INotification;
}