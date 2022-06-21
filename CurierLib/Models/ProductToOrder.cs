using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class ProductToOrder:Entity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
