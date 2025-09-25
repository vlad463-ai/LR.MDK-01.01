using System;
using System.Collections.Generic;
using System.Linq;
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
            
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
            

        }
    }
}
