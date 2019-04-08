using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonBotan.Models
{
    public class AdminVM
    {
        [Required]
        public string Emailadres { get; set; }
        [Required]
        public string Wachtwoord { get; set; }
    }
}