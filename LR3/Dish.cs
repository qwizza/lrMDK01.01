using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Dish
    {
        public string nameDish_ { get; set; }
        public string descriptionDish_ { get; set; }
        public int priceDish_ { get; set; }
        public string ingredients_ { get; set; }
        public string imagePath_ { get; set; }

        public Dish(string nameDish, string descriptionDish, int priceDish, string ingredients, string imagePath)
        {
            nameDish_ = nameDish;
            descriptionDish_ = descriptionDish;
            priceDish_ = priceDish;
            ingredients_ = ingredients;
            imagePath_ = imagePath;

        }
        public override string ToString()
        {
            return $"{nameDish_} - {priceDish_}";
        }
    }
}
