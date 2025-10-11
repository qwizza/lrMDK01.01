

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
        }
    }
}
