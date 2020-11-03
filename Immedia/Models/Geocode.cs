using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    
    public class Geocode
    {
        public int GeocodeId { get; set; }
        [DataMember(Name = "where")]
        public string Where { get; set; }
        public Feature feature { get; set; }
    }
}
