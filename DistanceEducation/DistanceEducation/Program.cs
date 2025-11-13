using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> Phones = new List<Phone>(); // лист для хранения телефонов

            Phone Iphone_11 = new Phone(); // Создаем телефоны в размере 5 штук
            Iphone_11.Model = "Iphone_11";
            Iphone_11.Price = 1000;
            Phones.Add(Iphone_11);

            Phone Iphone_12 = new Phone();
            Iphone_12.Model = "Iphone_12";
            Iphone_12.Price = 1500;
            Phones.Add(Iphone_12);

            Phone Iphone_13 = new Phone();
            Iphone_13.Model = "Iphone_13";
            Iphone_13.Price = 2000;
            Phones.Add(Iphone_13);

            Phone Iphone_14 = new Phone();
            Iphone_14.Model = "Iphone_14";
            Iphone_14.Price = 2500;
            Phones.Add(Iphone_14);

            Phone Iphone_15 = new Phone();
            Iphone_15.Model = "Iphone_15";
            Iphone_15.Price = 3000;
            Phones.Add(Iphone_15);

            List<SalePhone> Sale_phones = new List<SalePhone>(); //лист для хранения продаж телефонов

            SalePhone Sale_1 = new SalePhone(); // продажа телефонов  в данном случае за пять дней
            Sale_1.Sold = 5;
            Sale_1.PhoneModel = "Iphone_11";
            Sale_1.Date = new DateTime(2024, 11, 1);
            Sale_phones.Add(Sale_1);

            SalePhone Sale_2 = new SalePhone();
            Sale_2.Sold = 6;
            Sale_2.PhoneModel = "Iphone_12";
            Sale_2.Date = new DateTime(2024, 11, 2);
            Sale_phones.Add(Sale_2);

            SalePhone Sale_3 = new SalePhone();
            Sale_3.Sold = 7;
            Sale_3.PhoneModel = "Iphone_13";
            Sale_3.Date = new DateTime(2024, 11, 3);
            Sale_phones.Add(Sale_3);

            SalePhone Sale_4 = new SalePhone();
            Sale_4.Sold = 20;
            Sale_4.PhoneModel = "Iphone_14";
            Sale_4.Date = new DateTime(2024, 11, 4);
            Sale_phones.Add(Sale_4);

            SalePhone Sale_5 = new SalePhone();
            Sale_5.Sold = 9;
            Sale_5.PhoneModel = "Iphone_15";
            Sale_5.Date = new DateTime(2024, 11, 5);
            Sale_phones.Add(Sale_5);

            Phone.CalculateTotalSales(Sale_phones, Phones);
            SalePhone.FindBestAndworstSelling(Sale_phones);
            SalePhone.FindMostProfitablePhones(Sale_phones, Phones);
        }
    }
}
