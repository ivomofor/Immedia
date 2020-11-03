using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Immedia.Models
{
    [DataContract]
    public class Icon
    {
        public int IconId { get; set; }
        [DataMember(Name = "prefix")]
        public string Prefix { get; set; }
        [DataMember(Name = "suffix")]
        public string Suffix { get; set; }
    }
}
