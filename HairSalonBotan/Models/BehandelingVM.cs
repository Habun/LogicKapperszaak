﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InterfaceUI;
using FactoryUI;
using System.ComponentModel.DataAnnotations;

namespace HairSalonBotan.Models
{
    public class BehandelingVM
    {
        public CategorieVM categorieVM = new CategorieVM();

        [Required]
        public int Id { get; set; }
        [Required]
        public string omschrijving { get; set; }
        [Required]
        public decimal bedrag { get; set; }
        [Required]
        public List<IBehandelingUi> behandelingUI = new List<IBehandelingUi>();
        public List<IBehandelingUi> geefAlleBehandelingVoorCategorie = new List<IBehandelingUi>();
    }
}
