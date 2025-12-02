

using System.Collections.Generic;
using System;

namespace MenyClassesApplications
{
    class Report // Создал класс 
    {
        private List<ReportRow> rows_ = new List<ReportRow>(); // Поле класса
        public void AddRecord(ReportRow row) // Добавление в список rows_
        {
            rows_.Add(row);
        }
        public string ConvertReportToString(ReportRow row) // Вывод на консоль продукта количества и цены
        {
            return row.Product + ";" + row.Quantity + ";" + row.Price;
        }
        public void ToString()
        {
            foreach (ReportRow row in rows_)
            {
                ConvertReportToString(row);
            }
        }
        public void CalculateSum() // Создал метод для подсчета суммы
        {
            double sum = 0;
            foreach (ReportRow row in rows_)
            {
                sum += row.Quantity * row.Price;
            }
            Console.WriteLine("Сумма  - " + sum);
        }
    }
}
