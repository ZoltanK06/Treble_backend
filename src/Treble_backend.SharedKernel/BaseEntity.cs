using Treble_backend.SharedKernel.Interfaces;

namespace Treble_backend.SharedKernel;

// This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
public abstract class BaseEntity : IAggregateRoot
{
  public int Id { get; set; }

  public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
}
