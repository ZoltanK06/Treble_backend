using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treble_backend.Core.ProjectAggregate;
using Treble_backend.Core.ProjectAggregate.Specifications;
using Treble_backend.SharedKernel.Interfaces;

namespace Treble_backend.Core.Services;
public class PenaltyService : IPenaltyService
{
  public IReadRepository<Penalty> _readRepository;
  public IRepository<Penalty> _repository;
  public PenaltyService(IReadRepository<Penalty> readRepository, IRepository<Penalty> repository)
  {
    _readRepository = readRepository;
    _repository = repository;
  }

  public async Task<List<Penalty>> GetPenalties()
  {
    //var spec = new RandomPenalties();
    return await _readRepository.ListAsync();
  }
}
