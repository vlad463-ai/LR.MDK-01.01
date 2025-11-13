using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation
{
    public struct SalePhone
    {
        public int Sold;
        public string PhoneModel;
        public DateTime Date;

        static public void FindBestAndworstSelling(List<SalePhone> sale_phones) // функция находа лучшего и худшего
        {
            List<string> Model = new List<string>();
            List<int> Sold = new List<int>();

            foreach (SalePhone sale in sale_phones)
            {
                for (int i = 0; i < sale_phones.Count; i++)
                {
                    Model.Add(sale.PhoneModel);
                    Sold.Add(sale.Sold);
                }
            }
            string BestSellingPhone = " "; // самый продаваемый телефон
            int phoneSald = 0;
            for (int i = 0; i < Model.Count; i++)
            {
                if (Sold[i] > phoneSald)
                {
                    phoneSald = Sold[i];
                    BestSellingPhone = Model[i];
                }
            }
            string UnsoldPhone = " "; // с наименьшим количеством продаж
            int PhoneSald = 100;
            for (int i = 0; i < Model.Count; i++)
            {
                if (Sold[i] < PhoneSald)
                {
                    PhoneSald = Sold[i];
                    UnsoldPhone = Model[i];
                }
            }

            Console.WriteLine("Самый продаваемый телефон: " + BestSellingPhone);
            Console.WriteLine("Телефон с маньшим кол-вом продаж: " + UnsoldPhone);

        }
    }
}
