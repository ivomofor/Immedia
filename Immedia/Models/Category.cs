using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    [DataContract]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [DataMember(Name ="id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "pluralName")]
        public string PluralName { get; set; }
        [DataMember(Name = "shortName")]
        public string ShortName { get; set; }
        [DataMember(Name = "icon ")]
        public Icon Icon { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}
