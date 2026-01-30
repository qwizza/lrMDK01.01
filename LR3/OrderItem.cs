using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class OrderItem
    {
        public string DishName { get; set; }
        public string GroupName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int TotalPrice => Price * Quantity;

        public override string ToString()
        {
            return $"{DishName} - {Quantity} шт.";
        }
    }
}
