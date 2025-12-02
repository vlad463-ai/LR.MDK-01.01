
using System;

namespace MenyClassesApplications
{
    class Program
    {
        static void Main()
        {
            Storage storage = new Storage(); // Создали объект экземпляра Storage
            storage.SetIdentifier(123);
            storage.SetLocation("город Торжок, Студенческая 3");
            
            Product mercedesBens = new Product(); // Создали объект mercedesBens
            mercedesBens.SetName("Мерседес Бенс");
            mercedesBens.SetPrice(1000000);

            Product UAZ = new Product(); // Создали объект UAZ
            UAZ.SetName("Уазик");
            UAZ.SetPrice(10000000);

            storage.SetProductQuantity(mercedesBens, 2); //Добавили в словарь 2 записи
            storage.SetProductQuantity(UAZ, 5);

            storage.Print();
            storage.PrintAllMoney(); //Сделал вывод на консоль двух функций для печати


            Console.WriteLine();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Product = "ШЫШУЛЯ";
            row1.Quantity = 500;
            row1.Price = 100;

            ReportRow row2 = new ReportRow();
            row2.Product = "ШУШАРИКИ";
            row2.Quantity = 100;
            row2.Price = 5192;

            ReportRow row3 = new ReportRow();
            row3.Product = "Puss in boots";
            row3.Quantity = 70;
            row3.Price = 412;

            report.AddRecord(row1);
            report.AddRecord(row2);
            report.AddRecord(row3);

            report.ToString();
            Console.WriteLine();

            report.CalculateSum();


        }
    }
}
