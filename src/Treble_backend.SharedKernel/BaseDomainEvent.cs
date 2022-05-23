using MediatR;

namespace Treble_backend.SharedKernel;

public abstract class BaseDomainEvent : INotification
{
  public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
