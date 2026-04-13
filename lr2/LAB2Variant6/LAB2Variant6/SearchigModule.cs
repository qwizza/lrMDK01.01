using System;
using System.Collections.Generic;

namespace LAB2Variant6
{
    public class SearchingModule
    {
        // Ищем индекс категории в массиве (Супы, Салаты и т.д.)
        static public int FindIndexCatalog(string userQuery, string[] catalog)
        {
            for (int index = 0; index < catalog.Length; ++index)
            {
                // Приводим обе строки к нижнему регистру для сравнения
                if (catalog[index].ToLower() == userQuery.ToLower())
                {
                    return index;
                }
            }
            return -1; // Если ничего не нашли
        }

        // Извлекаем списки блюд и их количеств для выбранной категории
        static public (List<string>, List<int>) FindAllDishsByCenre(int indexCatalog,
                                                                  List<string>[] allDishs,
                                                                  List<int>[] counts)
        {
            // ВАЖНО: Создаем новые списки (new List), чтобы при сортировке 
            // не перемешать данные в основном каталоге.
            List<string> dishsByCatalog = new List<string>(allDishs[indexCatalog]);
            List<int> countsByCatalog = new List<int>(counts[indexCatalog]);

            return (dishsByCatalog, countsByCatalog);
        }
    }
}
        
    
