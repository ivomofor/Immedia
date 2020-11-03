using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    public class Response
    {
        public int ResponseId { get; set; }
        [DataMember(Name = "venues")]
        public List<Venue> Venues { get; set; }
        [DataMember(Name = "geocode")]
        public Geocode Geocode { get; set; }
        public int RootId { get; set; }
        public Root Root { get; set; }
    }
}
