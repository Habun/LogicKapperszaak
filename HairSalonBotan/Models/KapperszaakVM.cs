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
        public ProductVM productvm = new ProductVM();

        [Required]
        public int kapperszaakId { get; set; }
        [Required]
        public string naam { get; set; }
        
        [Required]
        public List<IProductUi> producten = new List<IProductUi>();
        [Required]
        public List<IAfspraakUi> afspraken = new List<IAfspraakUi>();
        [Required]
        public List<ICadeauKaartUi> cadeaukaarten  = new List<ICadeauKaartUi>();


    }
}