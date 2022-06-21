using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class Product : Entity
    {
        [Display(Name = "Наименование")]
        public string NameTovar { get; set; }

        [Display(Name = "Цена")]
        public int PriceOne { get; set; }
    }
}
