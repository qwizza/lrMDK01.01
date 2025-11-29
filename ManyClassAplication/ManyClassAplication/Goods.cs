using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    class Goods
    {
        private string name_;
        private double price_;
        //Устанвка имени
        public void SetName(string name)
        {
            name_ = name;
        }
        //Получение имени
        public string GetName()
        {
            return name_;
        }

        public void SetPrice(double price)
        {
            price_ = price;
        }

        public double GetPrice()
        {
            return price_;
        }
    }
}
