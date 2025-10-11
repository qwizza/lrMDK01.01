

using System.Collections.Generic;

namespace LAB2Variant6
{
    public class SearchingModule
    {
        static public int FindIndexGenre(string userQuery, string[] сatalog)
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

        
    }
}