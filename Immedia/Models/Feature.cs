using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    [DataContract]
    public class Feature
    {
        public int FeatureId { get; set; }
        [DataMember(Name = "cc")]
        public string CC { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }
        [DataMember(Name = "matchedName")]
        public string MatchedName { get; set; }
        [DataMember(Name = "highlightedName")]
        public string HighlightedName { get; set; }
        [DataMember(Name = "woeType")]
        public int WoeType { get; set; }
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "longId")]
        public string longId { get; set; }
        public int GeocodeId { get; set; }
        public Geocode Geocode { get; set; }
    }
}
