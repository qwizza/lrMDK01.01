using System;
using System.Collections.Generic;
using System.Data;


namespace PhoneSale
{
    public class InputModule
    {
        static public List<PhoneSale> CreateSalesData()
        {
            return new List<PhoneSale>();
            {
                new PhoneSale() { Date = new DateTime(2025, 11, 10), PhoneModel = "iPhone 17 Pro", Quantity = 5, Price = 1099.99, Cost = 899.99},
                new PhoneSale() { Date = new DateTime(2025, 11, 10), PhoneModel = "Samsung S25 Ultra", Quantity = 2, Price = 11299.99, Cost = 900.00},
                new PhoneSale() { Date = new DateTime(2025, 11, 11), PhoneModel = "iPhone 17 Pro", Quantity = 2, Price = 1099.99, Cost = 899.99 },
                new PhoneSale() { Date = new DateTime(2025, 11, 11), PhoneModel = "Xiaomi 17 Pro Max", Quantity = 7, Price = 1136.99, Cost = 835.99 },
                new PhoneSale() { Date = new DateTime(2025, 11, 12), PhoneModel = "Samsung S25 Ultra", Quantity = 4, Price = 11299.99, Cost = 900.00 },
                new PhoneSale() { Date = new DateTime(2025, 11, 12), PhoneModel = "Google Pixel 9 Pro XL", Quantity = 1, Price = 1099.99, Cost = 799.99},
                new PhoneSale() { Date = new DateTime(2025, 11, 13), PhoneModel = "iPhone 17 Pro", Quantity = 6, Price = 1099.99, Cost = 899.99 },
                new PhoneSale() { Date = new DateTime(2025, 11, 13), PhoneModel = "Xiaomi 17 Pro Max", Quantity = 3, Price = 1136.99, Cost = 835.99},
            }
        }
    }
}
