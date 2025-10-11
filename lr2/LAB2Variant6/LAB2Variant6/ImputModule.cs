using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class InputModule
    {
        static public (List<string>[], List<int>[]) InputDishByCenre()
        {
            List<string>[] dishsByGenre = new List<string>[4] { new List<string>(),
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
            dishsByGenre[0].Add("Харчо");
            counts[0].Add(10);
            dishsByGenre[0].Add("Борщ");
            counts[0].Add(9);
            dishsByGenre[0].Add("Солянка");
            counts[0].Add(4);
            dishsByGenre[0].Add("Щи");
            counts[0].Add(6);

            /// Заполняем салатные блюда (первый индекс)
            dishsByGenre[1].Add("Греческий салат");
            counts[1].Add(2);
            dishsByGenre[1].Add("Олевье");
            counts[1].Add(25);
            dishsByGenre[1].Add("Селедка под шубой");
            counts[1].Add(2);
            dishsByGenre[1].Add("Фруктовый");
            counts[1].Add(25);

            /// Заполняем выпечку (второй индекс)
            dishsByGenre[2].Add("Сосиска в тесте");
            counts[2].Add(30);
            dishsByGenre[2].Add("перог с курицей и грибами");
            counts[2].Add(30);
            dishsByGenre[2].Add("Перог с картошкой");
            counts[2].Add(30);
            dishsByGenre[2].Add("Перог с капустой");
            counts[2].Add(30);

            /// Заполняем ггарнирные блюда (третий индекс)
            dishsByGenre[3].Add("Пюре");
            counts[3].Add(10);
            dishsByGenre[0].Add("Гречневая каша с грибами и тыквой");
            counts[3].Add(5);
            dishsByGenre[0].Add("Макароны с овщами и сыром");
            counts[3].Add(1);
            dishsByGenre[0].Add("Рис с овощами и яйцом");
            counts[3].Add(1);

            return (dishsByGenre, counts);
        }

        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, категорию (Супы/Салаты/Выпечка/Гарниры): ");
            return Console.ReadLine();
        }

    }
}
