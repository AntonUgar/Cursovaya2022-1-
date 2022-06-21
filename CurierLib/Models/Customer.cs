using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class Customer : Entity
    {
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
