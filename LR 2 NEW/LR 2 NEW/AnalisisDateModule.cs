

using System;
using System.Collections.Generic;

namespace LR_2_NEW
{
    class AnalisisDateModule
    {
        static public List<catalog> СataloguesThisНear(Disk diskС, Disk diskD, string user) // каталоги этого года
        {
            List<catalog> Yearthese = new List<catalog>(); // список в котором будут лежать каталоги этого года
            if (diskС.Name.ToLower() == user.ToLower())
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
        static public void SortDescendingOrder(List<catalog> Yearthese) // сортировка по убыванию
        {
            catalog temp;
            for (int i = 0; i < Yearthese.Count; i++)
            {
                for (int j = 0; j < Yearthese.Count - 1; j++)
                {
                    if (Yearthese[j].numberRequests > Yearthese[j + 1].numberRequests)
                    {
                        temp = Yearthese[j];
                        Yearthese[j] = Yearthese[j + 1];
                        Yearthese[j + 1] = temp;
                    }
                }
                
            }
        }
        static public int AverageNumberRequest(List<catalog> Yearthese) // среднее количество обращений
        {
            int temp = 0;
            foreach (catalog catalog in Yearthese)
            {
                temp += catalog.numberRequests;
            }
            int result = temp / 5;
            return result;

        }
    }
}
