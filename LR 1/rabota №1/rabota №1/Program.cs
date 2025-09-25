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
            int razMas = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[razMas];
            int sumChet = 0;
            int sumNechet = 0;
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
                    sumChet++;

                }
                else sumNechet++;

            }
            Console.WriteLine("сумма четный чисел" + sumChet);
            Console.WriteLine("сумма четный чисел" + sumNechet);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            


        }
    }
}
