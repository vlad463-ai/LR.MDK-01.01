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
            //Создание массива
            int[] array = new int[10];
            Random random = new Random();
            for(int i = 0;i<array.Length;i++)
            {
                array[i] = random.Next(10, 10000);
                
            }
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");
            List<int> pairsSum = new List<int>();
            int leftNumber = 1;
            int rightNumber = 3;

            while(rightNumber<array.Length)
            {
                pairsSum.Add(array[leftNumber] + array[rightNumber]);
                leftNumber = rightNumber; ;
                rightNumber = leftNumber + 2;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма пар нечетных чисел");
            Console.Write("[ ");
            for (int i = 0; i < pairsSum.Count; i++)
            {
                Console.Write(pairsSum[i] + " ");
            }
            Console.Write("]");




        }
    }
}
