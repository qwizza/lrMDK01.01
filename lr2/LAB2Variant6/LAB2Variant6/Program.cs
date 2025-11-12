using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB2Variant6
{
    class Program
    {
        private static string[] catalog;
        private static List<string>[] dishs;
        private static List<int>[] counts;

        static void Print(List<string> dishes, List<int> counts, double average, string category)
        {
            Console.WriteLine($"Отчет по категории: {category} \nБлюда в порядке убывания популярности:");

            for (int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {dishes[i]}: {counts[i]} заказов");
            }

            Console.WriteLine($"Среднее число заказов: {average:F2}");
        }

        static void Main()
        {
            string[] catalog = new string[] { "Супы", "Салаты", "Выпечка", "Гарниры" };

            var result = InputModule.InputDishByCentre();
            List<string>[] dishs = result.Item1;
            List<int>[] counts = result.Item2;

            string userQuery = InputModule.InputUserQuery();

            int indexCatalog = SearchingModule.FindIndexCatalog(userQuery, catalog);
            if (indexCatalog < 0)
            {
                Console.WriteLine("Указан несуществующий категория");
                return;
            }

            if (dishs == null || counts == null || indexCatalog >= dishs.Length)
            {
                Console.WriteLine("Ошибка: данные не загружены");
                return;
            }

            (List<string> dishsUserCatalog, List<int> countsUserCatalog) = SearchingModule.FindAllDishsByCenre(indexCatalog, dishs, counts);

           AnalysisDataModule.SortDishs(dishsUserCatalog, countsUserCatalog);

           double average = AnalysisDataModule.CalculateAverage(countsUserCatalog);

           Print(dishsUserCatalog, countsUserCatalog, average, catalog[indexCatalog]);
        }
    }
}
