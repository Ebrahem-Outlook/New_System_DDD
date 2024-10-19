namespace New_System_DDD.Domain.Core.Event;

public interface IDomainEvent
{
    Guid EventId { get; }
    DateTime OccuredOn { get; }
}

public abstract record DomainEvent : IDomainEvent
{
    protected DomainEvent()
    {
        EventId = Guid.NewGuid();
        OccuredOn = DateTime.UtcNow;
    }

    public Guid EventId { get; }

    public DateTime OccuredOn { get; }
}

