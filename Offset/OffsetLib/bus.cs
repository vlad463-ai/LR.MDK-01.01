using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetLib
{
    public class bus
    {
        private string name_;
        private double price_;
        private string manufacturer_;

        public bus( string name,double price, string manufacturer)
        {
            name_ = name;
            price_ = price;
            manufacturer_ = manufacturer;
        }

        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }


    }
}
