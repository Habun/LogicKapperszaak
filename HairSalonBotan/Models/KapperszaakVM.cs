using InterfaceUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonBotan.Models
{
    public class KapperszaakVM
    {
        public AdminVM adminvm = new AdminVM();

        [Required]
        public string titel { get; set; }
        [Required]
        public string omschrijving { get; set; }
        [Required]
        public decimal prijs { get; set; }
        [Required]
        public string image { get; set; }
        [Required]
        public List<ProductInfoUI> producten = new List<ProductInfoUI>();
        [Required]
        public List<AfspraakInfoUI> afspraken = new List<AfspraakInfoUI>();
        [Required]
        public List<CadeauKaartInfoUI> cadeaukaarten  = new List<CadeauKaartInfoUI>();


    }
}