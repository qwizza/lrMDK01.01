using System;

namespace PhoneSale
{
    public class PhoneSales
    {
        public DateTime Date { get; set; }
        public string PhoneModel { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public double Profit => Price - Cost;
        public double TotalRevenue => Price * Quantity;
        public double TotalProfit => Profit * Quantity;
    }
}
