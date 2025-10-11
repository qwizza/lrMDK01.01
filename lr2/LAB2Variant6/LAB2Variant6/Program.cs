

namespace LAB2Variant6
{
    class Program
    {
        static void Print(List<string> dishs)
        {
            Console.WriteLine(String.Join(", ", dishs));
        }

        static void Main()
        {
            string[] catalog = new string[] { "Суп", "Салат", "Выпечка", "Гарниры" };

            string userQuery = InputModule.InputUserQuery();

            int indexCatalog = SearchingModule.FindIndexCatalog(userQuery, сatalog);
            if (indexCatalog < 0)
            {
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }

            var (dishsUserCatalog, countsUserCatalog) = SearchingModule.FindAllDishsByCenre(indexCatalog, dishs, counts);

            AnalysisDataModule.SortDishs(dishsUserCatalog, countsUserCatalog);
            Print(dishsUserCatalog)
        }
    }
}
