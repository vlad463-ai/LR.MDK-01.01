using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massiv = new string[3];
            massiv [0] = "Gu";
            massiv [1] = "RA";
            massiv [2] = "Fa";

            massiv[1] = "OG";
            foreach(string n in massiv)
            {
                Console.WriteLine("Элемет массива" + " "+ n);
            }

            string[] array = new string[3];
            array[2] = massiv[0];
            array[1] = massiv[1];
            array[0] = massiv[2];

            int[] mass = new int[10000];
            for(int i = 0; i<mass.Length;i++)
            {
                mass[i] = 1+i;

            }
            Console.Write("[");
            for (int i = 0; i < mass.Length-1; i++)
            {
                Console.Write(mass[i] + ",");

            }
            Console.Write(mass.Length);
            Console.WriteLine("]");












        }
    }
}
