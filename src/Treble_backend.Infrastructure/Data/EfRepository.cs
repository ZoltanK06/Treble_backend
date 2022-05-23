using Ardalis.Specification.EntityFrameworkCore;
using Treble_backend.SharedKernel.Interfaces;

namespace Treble_backend.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
