using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Model
{
    public class BookItem
    {
        public string Genre { get; set; }
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is BookItem other)
            {
                return Genre == other.Genre;
            }
            return false;
        }
    }
}
