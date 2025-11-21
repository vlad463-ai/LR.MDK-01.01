

using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace DZ_struct
{
    internal class Program
    {
        static void Main()
        {
            DateTime start = new DateTime(2025, 01, 01);
            DateTime end = new DateTime(2025, 01, 31);
            List <Sale> sale = functions.InputSaleDate();
            List<Sale> sales = functions.FindSalesForPeriod(sale, start, end);
            double salePrice = functions.FindSalesPrice(sales);            
            string maxPhone = functions.FindMaxSellPhone(sales);
            string minPhone = functions.FindMinSellPhone(sales);
            string[] findPhone = functions.FindBothPhone(sales);
            Console.WriteLine("Сумма за период Х: " + salePrice);
            Console.WriteLine();
            Console.WriteLine("Самый продаваемый телефон: " + maxPhone);
            Console.WriteLine("Самый мало продаваемый телефон: " + minPhone);
            Console.WriteLine();
            Console.WriteLine("Первый телефон, приносящий наибольшую прибыль: " + findPhone[0]);
            Console.WriteLine("Второй телефон, приносящий наибольшую прибыль: " + findPhone[1]);
            Console.WriteLine();
            






        }
    }
}
