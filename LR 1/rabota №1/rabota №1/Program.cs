using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace rabota__1
{
    class Program
    {
        static void Main(string[] args)
        {
            // С клавиатуры ввести массив из n целых чисел.Подсчитать количество четных и нечетных элементов.
            Console.WriteLine("Введите размер массива");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[sizeArray];
            int evenNumbers = 0;
            int oddNumbers = 0;
            Console.WriteLine("Введите целые числа массива");
            for (int index = 0; index<array.Length;index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumbers++;

                }
                else oddNumbers++;

            }
            Console.WriteLine();
            Console.WriteLine("сумма четный чисел " + evenNumbers);
            Console.WriteLine();
            Console.WriteLine("сумма четный чисел " + oddNumbers);
            Console.WriteLine();
            Console.WriteLine("Полученный массив");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            


        }
    }
}
