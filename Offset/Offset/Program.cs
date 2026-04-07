using OffsetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Offset
{
    public class Program
    {
        static void Main(string[] args)
        {
            bus b = new bus("Мас-10", 100000, "Торжок");
            Console.WriteLine(b.GetName());

            List<bus> buses = new List<bus>
            {
                new bus("Мас-15",150000,"Торжок"),
                new bus("Мас-20",200000,"Торжок"),
                new bus("Мас-25",250000,"Торжок")
            };
            Console.WriteLine(buses[2].GetName());

            List<bus> buses1 = allBusesAreSmaller(buses);
            foreach(var n in buses1)
            {
                Console.WriteLine(n.GetName());
            }
        }
        static public List<bus> allBusesAreSmaller(List<bus> buses)
        {
            List<bus> busss = new List<bus>();
            int x = 199000;
            foreach(var m in buses)
            {
                if(x > m.GetPrice())
                {
                    busss.Add(m);
                }
            }
            return busss;
           
        }
    }
}
