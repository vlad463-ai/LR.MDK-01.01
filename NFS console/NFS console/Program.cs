

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;


namespace NFS_console
{
    class Program
    {
        static public void Print(Car automodile) // функция вывода на экран
        {
            Console.WriteLine(automodile.GetModel());
        }
        static void Main()
        {
            
            Car auto = new Car(); // объект auto
            auto.SetModel("Лада");
            auto.SetSpeed(150);
            //Print(auto);

            Car merc = new Car(); // объект merc
            merc.SetModel("Мерс");
            merc.SetSpeed(300);
            //Print(merc);

            List<Car> cars = new List<Car>(); // список для хранения объектов
            cars.Add(auto);
            cars.Add(merc);


            LadaVsMerc(cars);

        }
        static public void LadaVsMerc(List<Car> cars) // функция для гонок
        {
            int speed = 1;
            while (true)
            {
                foreach (Car auto in cars)
                {
                     for (int i = 0; i <auto.GetSpeed() / 50 * speed; i++)
                     {
                        Console.Write(" ");
                     }
                    Console.Write(auto.GetModel());
                    Console.WriteLine();
                    
                     speed++;
                }
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
