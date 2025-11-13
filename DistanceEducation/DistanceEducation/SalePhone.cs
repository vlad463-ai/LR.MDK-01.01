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

        static public void FindMostProfitablePhones(List<SalePhone> Sale_phones, List<Phone> Phones) // найти самые прибыльные телефоны
        {
            string firstBest = ""; //1 место
            string secondbest = "";// 2 место
            int firstRevenue = 0; // прибыль на 1 месте
            int secontrevenue = 0;//прибыль на 2 месте



            foreach (var phone in Phones)
            {
                foreach (var phone2 in Sale_phones)
                {
                    int profit = phone.Price * phone2.Sold;

                    if (profit > firstRevenue)
                    {
                        secontrevenue = firstRevenue;
                        secondbest = firstBest;

                        firstRevenue = profit;
                        firstBest = phone.Model;
                    }

                    else if (profit > secontrevenue)
                    {
                        secontrevenue = profit;
                        secondbest = phone.Model;
                    }
                }




            }
            Console.WriteLine("Телефоны с наибольшей выручкойx: ");
            Console.WriteLine($"Телефон на первом месте: {firstBest} - его цена:  {firstRevenue}");
            Console.WriteLine($"Телефон на втором месте:{secondbest} - его цена:  {secontrevenue}");



        }
    }
}
