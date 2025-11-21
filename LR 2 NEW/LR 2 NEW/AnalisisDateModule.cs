

using System;
using System.Collections.Generic;

namespace LR_2_NEW
{
    class AnalisisDateModule
    {
        static public List<catalog> СataloguesThisНear(Disk diskС, Disk diskD, string user) // каталоги этого года
        {
            List<catalog> Yearthese = new List<catalog>(); // список в котором будут лежать каталоги этого года
            if (diskС.Name == user)
            {
                foreach (catalog catalog in diskС.catalogs)
                {
                    if (catalog.yearCreation == 2025)
                    {
                        Yearthese.Add(catalog);
                    }
                }
            }
            else if (diskD.Name == user)
            {
                foreach (catalog catalog in diskD.catalogs)
                {
                    if (catalog.yearCreation == 2025)
                    {
                        Yearthese.Add(catalog);
                    }
                }
            }
            else
            {
                Console.WriteLine("Указан несуществующий диск выберите один из предложенных: (Диск C, Диск D)");
            }
            return Yearthese;
        }
    }
}
