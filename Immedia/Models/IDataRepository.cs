using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Immedia.Models
{
    public interface IDataRepository
    {
        IEnumerable<Response> GetResponses { get; }
        IEnumerable<Venue> GetVenues { get; }
    }
}
