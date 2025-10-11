

using System.Collections.Generic;

namespace LAB2Variant6
{
    public class SearchingModule
    {
        static public int FindIndexCatalog(string userQuery, string[] сatalog)
        {
            for (int index = 0; index < сatalog.Length; ++index)
            {
                string valueCatalog = сatalog[index].ToLower();
                if (valueCatalog == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }
        static public (List<string>, List<int>) FindAllDishsByCenre(int indexCatalog,
                                                            List<string>[] allDishs,
                                                            List<int>[] counts)
        {
            List<string> dishsByCatalog = new List<string>();
            List<int> countsByCatalog = new List<int>();

            dishsByCatalog = alldishs[indexCatalog];
            countsByCatalog = counts[indexCatalog];

            return (dishsByCatalog, countsByCatalog);
        }
    }
}
        
    
