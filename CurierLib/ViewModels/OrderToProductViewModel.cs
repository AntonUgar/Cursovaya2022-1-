using CurierLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.ViewModels
{
    public class OrderToProductViewModel : Order
    {
        [Display(Name ="Продукты")]
        public int[] ProductIdsStrArray { get; set; }

       
    }
}
