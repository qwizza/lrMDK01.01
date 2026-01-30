using System;

namespace LR3
{
    public class OrderItem
    {
        public Dish Dish_ { get; set; }
        public int Quantity_ { get; set; }

        public OrderItem(Dish dish, int quantity)
        {
            Dish_ = dish;
            Quantity_ = quantity;
        }
    }
}
