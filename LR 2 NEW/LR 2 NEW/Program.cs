

using System;
using System.Collections.Generic;

namespace LR_2_NEW
{
    class Program
    {
        static public void Print(List<catalog> Yearthese, int count)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Yearthese[i].name);
            }
            Console.WriteLine("Cреднее количество обращений: " + count);
            ;
        }
        static void Main()
        {

            List<catalog> C = new List<catalog>();


            C.Add( new catalog { name = "Пользователь", yearCreation = 2020, numberRequests = 10 }); // идет заполнение диска C
            C.Add( new catalog { name = "User", yearCreation = 2021, numberRequests = 15 });
            C.Add( new catalog { name = "Admin", yearCreation = 2022, numberRequests = 25 });
            C.Add( new catalog { name = "Intel", yearCreation = 2025, numberRequests = 40 });
            C.Add( new catalog { name = "Tanki", yearCreation = 2025, numberRequests = 5 });

            List<catalog> D = new List<catalog>();

            D.Add( new catalog { name = "Vertigo", yearCreation = 2022, numberRequests = 60 });// идет заполнение диска D
            D.Add( new catalog { name = "Kompas", yearCreation = 2024, numberRequests = 90 });
            D.Add( new catalog { name = "Android", yearCreation = 2025, numberRequests = 100 });
            D.Add( new catalog { name = "Windows", yearCreation = 2025, numberRequests = 1 });
            D.Add( new catalog { name = "Steam", yearCreation = 2025, numberRequests = 1000 });


            Disk diskC = new Disk();
            diskC.Name = "Диск С";
            diskC.catalogs = C;
            Disk diskD = new Disk();
            diskC.Name = "Диск Д";
            diskC.catalogs = D;

            string user = userRequest.InputUserRequest();
            List<catalog> Yearthese = AnalisisDateModule.СataloguesThisНear(diskC, diskD, user);
            AnalisisDateModule.SortDescendingOrder(Yearthese);
            int countRequest = AnalisisDateModule.AverageNumberRequest(Yearthese);
            Print(Yearthese, countRequest);





        }
    }
}
