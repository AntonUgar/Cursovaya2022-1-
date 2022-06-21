using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class Order : Entity
    {
        [Display(Name="Дата заказа")]
        public DateTime TimeOrder { get; set; }

        [Display(Name = "Курьер")]
        public int IdEmployer { get; set; }

        [Display(Name = "Заказчик")]
        public int IdPokypatel { get; set; }

        [Display(Name = "Итоговая стоимость")]
        public int PriceOrder { get; set; }

    }
}
