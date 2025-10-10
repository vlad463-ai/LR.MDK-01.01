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
            int[] array = new int[3000];
            Random ran = new Random();
            for(int i =0;i<array.Length;i++)
            {
                array[i] = ran.Next(10, 10000);
                
            }

            int[] summa = new int[1500];
            for(int index =0;index<summa.Length;index++)
            { 
               for(int i=1 ;i < summa.Length; i++)
               {
                  for(int j =i+2; j< summa.Length ;j++)
                  {
                    summa[i] = array[i] + array[j];
                  }
               }
            
            }
            Console.WriteLine();
            Console.WriteLine();
            //Массив исходный
            foreach (int element in array)
            {
                Console.Write(element + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            // массив с суммой
            foreach (int element in summa)
            {
                Console.Write(element + ",");
            }
        }
    }
}
