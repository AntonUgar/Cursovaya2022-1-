using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.ViewModels
{
   public  class OrderToListViewModel
    {
        [Display(Name = "Курьер")]
        public string Coirer { get; set; }
        [Display(Name = "Заказчик")]
        public string Customer { get; set; }
        [Display(Name = "Товар")]
        public string Tovar { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "Дата")]
        public DateTime Data { get; set; }
    }
}
