
using System;
using System.Collections.Generic;

namespace MenyClassesApplications
{
    class Storage //класс (место хранения склад)
    {
        private int identifier_; // идентификатор
        private string location_; // место локации
        private Dictionary<Product,int> Products_ = new Dictionary<Product, int>(); // словарь с ключом Product(имя и цена) а значение это количество 
        
        public void  SetIdentifier(int identifier) // Метод добавления идентификатора
        {
            identifier_ = identifier;
        }
        public void SetLocation(string location) // мотод добавления локации
        {
            location_ = location;
        }
        public void SetProductQuantity(Product product, int quantity) // метод добавления товара(имя и цена) и  его количества
        {
            Products_.Add(product, quantity);
        }

        public void Print() // Сделал вывод машина - её количество
        {
            foreach(Product key in Products_.Keys)
            {
                Console.WriteLine(key.GetName() + " "+  Products_[key] + " шт.");
            }
        }

        public void PrintAllMoney() // реализовал вывод на консоль общей  суммы
        {
            double summ = 0;
            foreach (Product key in Products_.Keys)
            {
                summ += Products_[key] * key.GetPrice();
                
            }
            Console.WriteLine(summ);
        }
    }
}
