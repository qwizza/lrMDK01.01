using System;
using System.Collections.Generic;

namespace LAB2Variant6
{
    public class InputModule
    {
        static public (List<string>[], List<int>[]) InputDishByCenre()
        {
            List<string>[] dishsByCatalog = new List<string>[4] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };

            List<int>[] counts = new List<int>[4]{ new List<int>(),
                                                   new List<int>(),
                                                   new List<int>(),
                                                   new List<int>()
            };

            /// Заполняем суповые блюда (нулевой индекс)
            dishsByCatalog[0].Add("Харчо");
            counts[0].Add(10);
            dishsByCatalog[0].Add("Борщ");
            counts[0].Add(9);
            dishsByCatalog[0].Add("Солянка");
            counts[0].Add(4);
            dishsByCatalog[0].Add("Щи");
            counts[0].Add(6);

            /// Заполняем салатные блюда (первый индекс)
            dishsByCatalog[1].Add("Греческий салат");
            counts[1].Add(2);
            dishsByCatalog[1].Add("Олевье");
            counts[1].Add(25);
            dishsByCatalog[1].Add("Селедка под шубой");
            counts[1].Add(2);
            dishsByCatalog[1].Add("Фруктовый");
            counts[1].Add(25);

            /// Заполняем выпечку (второй индекс)
            dishsByCatalog[2].Add("Сосиска в тесте");
            counts[2].Add(30);
            dishsByCatalog[2].Add("перог с курицей и грибами");
            counts[2].Add(30);
            dishsByCatalog[2].Add("Перог с картошкой");
            counts[2].Add(30);
            dishsByCatalog[2].Add("Перог с капустой");
            counts[2].Add(30);

            /// Заполняем ггарнирные блюда (третий индекс)
            dishsByCatalog[3].Add("Пюре");
            counts[3].Add(10);
            dishsByCatalog[0].Add("Гречневая каша с грибами и тыквой");
            counts[3].Add(5);
            dishsByCatalog[0].Add("Макароны с овщами и сыром");
            counts[3].Add(1);
            dishsByCatalog[0].Add("Рис с овощами и яйцом");
            counts[3].Add(1);

            return (dishsByCatalog, counts);
        }

        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, категорию (Супы/Салаты/Выпечка/Гарниры): ");
            return Console.ReadLine();
        }

    }
}
