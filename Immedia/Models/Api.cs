using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Immedia.Models
{
    public class Api
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Search For A City")]
        public string City { get; set; }
        
    }
}
