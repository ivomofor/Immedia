using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Immedia.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Hit
    {
        [Key]
        public int HitId { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string tags { get; set; }
        public string webformatURL { get; set; }
        public int webformatWidth { get; set; }
        public int webformatHeight { get; set; }
        public string largeImageURL { get; set; }
        public int imageWidth { get; set; }
        public int imageHeight { get; set; }
        public int imageSize { get; set; }
        public int views { get; set; }
        public int downloads { get; set; }
        public int favorites { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public string user { get; set; }
    }

    public class RootImage
    {
        [Key]
        public int RootImageId { get; set; }
        //public int total { get; set; }
        public List<Hit> hits { get; set; }
        [NotMapped]
        public string ResponseData { get; set; }

    }


}
