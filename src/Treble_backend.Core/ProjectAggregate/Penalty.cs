using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treble_backend.SharedKernel;

namespace Treble_backend.Core.ProjectAggregate;
public class Penalty : BaseEntity
{
  public int Id { get; set; }
  public string Player { get; set; }
  public string Match { get; set; }
  public string Shot { get; set; }
}
