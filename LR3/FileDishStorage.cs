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

            using (StreamReader reader = new StreamReader("C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\bin\\Debug\\data.csv"))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] drugInfo = line.Split(';');

                    string category = drugInfo[0];
                    string name = drugInfo[1];
                    string description = drugInfo[2];
                    string price = drugInfo[3];
                    string ingredients = drugInfo[4];
                    string imagePath = drugInfo[5];

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
