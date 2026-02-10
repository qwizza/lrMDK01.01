using System;

namespace LR3
{
    public class Dishs
    {
        private string name_;
        private int price_;
        private string description_;
        private string ingredients_;
        private string imagePath_;

        public Dishs(string name, string description, string price, string ingredients, string imagePath)
        {
            name_ = name;
            if (!int.TryParse(price, out price_))
            {
                price_ = 0;
            }
            description_ = description;
            ingredients_ = ingredients;
            imagePath_ = imagePath;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString("0") + " руб."; }
        }

        public string Description
        {
            get { return description_; }
        }

        public string Ingredients
        {
            get { return ingredients_; }
        }

        public string ImagePath
        {
            get { return imagePath_; }
        }
    }
}
