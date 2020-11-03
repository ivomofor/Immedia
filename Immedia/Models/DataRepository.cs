using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Immedia.Data;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Immedia.Models
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext context;
        public DataRepository(DataContext cxt)
        {
            context = cxt;
        }
        public IEnumerable<Response> GetResponses => context.Responses;
        public IEnumerable<Venue> GetVenues => context.Venues; 
    }
}
