using InterfaceUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonBotan.Models
{
    public class CategorieVM
    {
        [Required]
        public int categorieId { get; set; }
        [Required]
        public string categorienaam { get; set; }

        public List<CategorieInfoUI> categorieInfoUI = new List<CategorieInfoUI>();

        public List<BehandelingsInfoUI> allebehandelingen = new List<BehandelingsInfoUI>();
    }
}