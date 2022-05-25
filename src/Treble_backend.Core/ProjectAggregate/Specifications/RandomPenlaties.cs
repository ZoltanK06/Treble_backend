using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Treble_backend.Core.ProjectAggregate.Specifications;
public class RandomPenalties : Specification<Penalty>, ISingleResultSpecification
{
  public RandomPenalties()
  {
    var rand = new Random();
    Query.OrderBy(x => rand.Next()).Take(10);
  }
}
