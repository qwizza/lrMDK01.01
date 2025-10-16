
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

        static void Print(List<string> dishs)
        {
            Console.WriteLine(String.Join(", ", dishs));
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
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }

            if (dishs == null || counts == null || indexCatalog >= dishs.Length)
            {
                Console.WriteLine("Ошибка: данные не загружены");
                return;
            }

            (List<string> dishsUserCatalog, List<int> countsUserCatalog) = SearchingModule.FindAllDishsByCenre(indexCatalog, dishs, counts);
            LAB2Variant6.AnalysisDataModule.SortDishs(dishsUserCatalog, countsUserCatalog);
            Print(dishsUserCatalog);
        }
    }
}
