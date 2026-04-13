using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB2Variant6
{
    class Program
    {
        // Выводит названия блюд через запятую
        static void Print(List<string> dishes)
        {
            Console.WriteLine("Блюда: " + String.Join(", ", dishes));
        }

        // Выводит количество заказов через запятую
        static void Prints(List<int> counts)
        {
            Console.WriteLine("Количество заказов: " + String.Join(", ", counts));
        }

        static void Main()
        {
            string[] catalog = { "Супы", "Салаты", "Выпечка", "Гарниры" };

            // 1. Ввод
            var (dishsByCatalog, countsByCatalog) = InputModule.InputDishByCentre();

            // 2. Запрос категории
            string userQuery = InputModule.InputUserQuery();

            // 3. Поиск индекса
            int indexCatalog = SearchingModule.FindIndexCatalog(userQuery, catalog);
            if (indexCatalog < 0)
            {
                Console.WriteLine("Указана несуществующая категория");
                return;
            }

            // 4. Поиск данных по категории
            var (selectedDishes, selectedCounts) = SearchingModule.FindAllDishsByCenre(indexCatalog, dishsByCatalog, countsByCatalog);

            // 5. Анализ и сортировка
            AnalysisDataModule.SortDishs(selectedDishes, selectedCounts);

            // 6. Вывод результата
            Console.WriteLine($"\n--- Отчет по категории: {catalog[indexCatalog]} ---");
            Print(selectedDishes);
            Prints(selectedCounts);

            double average = AnalysisDataModule.CalculateAverage(selectedCounts);
            Console.WriteLine($"Среднее число заказов: {average:F2}");
        }
    }
}
