

using System;
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

            dishsByCatalog = allDishs[indexCatalog];
            countsByCatalog = counts[indexCatalog];

            return (dishsByCatalog, countsByCatalog);
        }

        internal static int FindIndexCatalog(string userQuery, object сatalog)
        {
            throw new NotImplementedException();
        }

        internal static (List<string> dishsUserCatalog, List<int> countsUserCatalog) FindAllDishsByCenre(int indexCatalog, object dishs, object counts)
        {
            throw new NotImplementedException();
        }

        internal static (List<string> dishsUserCatalog, List<int> countsUserCatalog) FindAllDishsByCenre(int indexCatalog, List<string>[] dishs, object counts)
        {
            throw new NotImplementedException();
        }
    }
}
        
    
