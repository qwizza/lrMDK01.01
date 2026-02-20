using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class FileDishStorage : IDish
    {
        public Dictionary<string, List<Dishs>> LoadDataFromCsv()
        {
            Dictionary<string, List<Dishs>> result = new Dictionary<string, List<Dishs>>();

            using (StreamReader reader = new StreamReader("data.csv"))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] dishInfo = line.Split(';');

                    string category = dishInfo[0];
                    string name = dishInfo[1];
                    string description = dishInfo[2];
                    string price = dishInfo[3];
                    string ingredients = dishInfo[4];
                    string imagePath = dishInfo[5];

                    Dishs dish = new Dishs(name, description, price, ingredients, imagePath);

                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Dishs>();
                    }

                    result[category].Add(dish);
                }
            }
            return result;
        }
    }
}
