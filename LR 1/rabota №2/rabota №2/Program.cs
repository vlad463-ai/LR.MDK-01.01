using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Дана последовательность 3000 случайных чисел от 10 до 9999.
            //Сохранить в отдельной структуре данных сумму пар 
            //соседних элементов, находящихся на нечетных пози
            //циях(1 и 3, 3 и 5, 5 и 7 и т.д).Результат вывести на экран в 
            //формате: [a1, a2, a3, ….., an], где 
            //а – очередное найденное число.

            int[] array = new int[3000];
            Random ran = new Random();
            for(int i =0;i<array.Length;i++)
            {
                array[i] = ran.Next(10, 9999);
            }

            foreach(int element in array)
            {
                Console.Write(element + ",");
            }
        }
    }
}
