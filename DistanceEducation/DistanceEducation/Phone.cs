using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation
{
    public struct Phone
    {
        public string Model;
        public int Price;

        static public void CalculateTotalSales(List<SalePhone> Sale_phones, List<Phone> Phones) //вычесляем общую сумму проданного за определенный период
        {
            DateTime start = new DateTime(2024, 11, 1);
            DateTime end = new DateTime(2024, 11, 5);

            int AmountSales = 0;
            foreach (SalePhone sale in Sale_phones)
            {
                if (sale.Date >= start && sale.Date <= end)
                {
                    foreach (Phone Phone in Phones)
                    {
                        if (Phone.Model == sale.PhoneModel)
                        {
                            AmountSales += Phone.Price * sale.Sold;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Общая сумма продаж: " + AmountSales);
        }
    }
}
