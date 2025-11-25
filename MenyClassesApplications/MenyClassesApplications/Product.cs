using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenyClassesApplications
{
    public class Product //класс продукт с его двумя полями
    {
        private string name_;
        private double price_;

        public void SetName(string name) // Задать имя
        {
            name_ = name;
        }
        public void SetPrice(double price) // Задать цену
        {
            price_ = price;
        }
        public string GetName() //Показать имя
        {
            return name_;
        }
        public double GetPrice() //Показать цену
        {
            return price_;
        }
    }
}


