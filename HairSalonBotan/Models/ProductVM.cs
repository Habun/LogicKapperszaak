using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonBotan.Models
{
    public class ProductVM
    {
        [Required]
        public int productId { get; set; }
        [Required]
        public string titel { get; set; }
        [Required]
        public string omschrijving { get; set; }
        [Required]
        public string image { get; set; }
    }
}