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
        [Required]
        public string omschrijving { get; set; }

        [Required]
        public decimal bedrag { get; set; }

        [Required]
        public List<BehandelingsInfoUI> behandelingUI = new List<BehandelingsInfoUI>();
    }
}           