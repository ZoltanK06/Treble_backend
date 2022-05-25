using Treble_backend.Core.ProjectAggregate;

namespace Treble_backend.Core.Services;

public interface IPenaltyService
{
  Task<List<Penalty>> GetPenalties();
}