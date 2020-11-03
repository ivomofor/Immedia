using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    [DataContract]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "crossStreet")]
        public string CrossStreet { get; set; }
        [DataMember(Name = "lat")]
        public double lat { get; set; }
        [DataMember(Name = "lng")]
        public double lng { get; set; }
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }
        [DataMember(Name = "cc")]
        public string CC { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "formattedAddress")]
        [NotMapped]
        public List<string> FormattedAddress { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
    } 
}
