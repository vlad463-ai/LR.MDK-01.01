

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DZ_struct
{
    internal class functions
    {
        static public List<Sale> InputSaleDate() //Заполняем список продаж
        {
            List<Sale> sales = new List<Sale>();

            sales.Add(new Sale { Name = "Iphone 8", Price = 15000, Date = new DateTime(2025, 01, 01), Quantity = 2 });
            sales.Add(new Sale { Name = "Iphone 8", Price = 15000, Date = new DateTime(2025, 01, 02), Quantity = 1 });
            sales.Add(new Sale { Name = "Iphone 9", Price = 20000, Date = new DateTime(2025, 01, 02), Quantity = 5 });
            sales.Add(new Sale { Name = "Iphone 10", Price = 25000, Date = new DateTime(2025, 01, 02), Quantity = 7 });
            sales.Add(new Sale { Name = "Iphone 11", Price = 30000, Date = new DateTime(2025, 01, 03), Quantity = 1 });
            sales.Add(new Sale { Name = "Iphone 12", Price = 35000, Date = new DateTime(2025, 01, 03), Quantity = 12 });
            sales.Add(new Sale { Name = "Iphone 13", Price = 40000, Date = new DateTime(2025, 01, 03), Quantity = 3 });
            sales.Add(new Sale { Name = "Iphone 14", Price = 45000, Date = new DateTime(2025, 01, 03), Quantity = 8 });
            sales.Add(new Sale { Name = "Iphone 15", Price = 70000, Date = new DateTime(2025, 01, 04), Quantity = 4 });
            sales.Add(new Sale { Name = "Iphone 16", Price = 75000, Date = new DateTime(2025, 01, 05), Quantity = 6 });
            sales.Add(new Sale { Name = "Iphone 17", Price = 100000, Date = new DateTime(2025, 01, 05), Quantity = 90 });
            sales.Add(new Sale { Name = "Iphone 17", Price = 1000, Date = new DateTime(2025, 01, 06), Quantity = 2 });
            sales.Add(new Sale { Name = "Iphone 17", Price = 1000, Date = new DateTime(2025, 01, 04), Quantity = 5 });

            return sales;
        }
        static public List<Sale> FindSalesForPeriod(List<Sale> sale, DateTime start, DateTime end) // Нахождение продаж за период
        {
            List<Sale> sales = new List<Sale>();
            foreach (Sale s in sale)
            {
                if (s.Date >= start && s.Date <= end)
                {
                    sales.Add(s);
                }
            }

            return sales;

        }
        static public double CalcSaleCost(Sale sale) // Цена купленного телефона
        {
            double cost = sale.Price * sale.Quantity;
            return cost;
        }
        static public double FindSalesPrice(List<Sale> sales) // Вывод общей суммы за период
        {
            double salePrice = 0;
            foreach (Sale s in sales)
            {
                salePrice += CalcSaleCost(s);
            }
            return salePrice;
        }
        static public Dictionary<string, int> CheckDictionary(List<Sale> sales) // заполнение словаря
        {
            Dictionary<string, int> phoneCount = new Dictionary<string, int>();
            foreach (Sale s in sales)
            {
                if (phoneCount.ContainsKey(s.Name))
                {
                    phoneCount[s.Name]++;
                }
                else
                {
                    phoneCount.Add(s.Name, 1);
                }
            }
            return phoneCount;
        }
        static public string FindMaxSellPhone(List<Sale> sales) // Поиска самого продаваемого телефона
        {
            Dictionary<string, int> phoneCount = CheckDictionary(sales);

            int max = 0;
            string name = null;
            foreach (var s in phoneCount)
            {
                if (max < s.Value)
                {
                    max = s.Value;
                    name = s.Key;
                }
            }
            return name;
        }
        static public string FindMinSellPhone(List<Sale> sales) // Поиска самого  наименее продаваемого телефона
        {
            Dictionary<string, int> phoneCount = CheckDictionary(sales);

            int max = 0;
            string name = null;
            foreach (var s in phoneCount)
            {
                if (max == 0)
                {
                    max = s.Value;
                    name = s.Key;
                }
                if (max > s.Value)
                {
                    max = s.Value;
                    name = s.Key;
                }
            }
            return name;
        }
        static public Dictionary<string, double> InputcostDictionary(List<Sale> sales) // заполнение словаря(телефон, цена)
        {
            
            Dictionary<string, double> phoneSale = new Dictionary<string, double>();
            foreach (Sale s in sales)
            {

                if (phoneSale.ContainsKey(s.Name))
                {
                    phoneSale[s.Name] += s.Quantity * s.Price;
                }
                else
                {
                    phoneSale.Add(s.Name, s.Quantity * s.Price);
                }
            }
            return phoneSale;
        }
        static public string [] FindBothPhone(List<Sale> sales) // Первый телефон приносящий наибольшую прибыль
        {
            string[] findPhone = new string[2];
            Dictionary<string, double> phoneSale = InputcostDictionary(sales);
            double max = 0;
            string name = "";
            foreach(string s in phoneSale.Keys)
            {
                if(max < phoneSale[s])
                {
                    max= phoneSale[s];
                    name = s;
                }
                
            }
            findPhone[0] = name;
            phoneSale.Remove(name);
            max = 0;
            foreach (string s in phoneSale.Keys)
            {
                if (max < phoneSale[s])
                {
                    max = phoneSale[s];
                    name = s;
                }

            }
            findPhone[1] = name;
            return findPhone;

        }
        
    }
}
