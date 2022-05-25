using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treble_backend.SharedKernel;

namespace Treble_backend.Core.ProjectAggregate;
public class Quiz : BaseEntity
{
  public int Id { get; set; }
  public string Question { get; set; }
  public string Answer { get; set; }
  public string Image { get; set; }
}
