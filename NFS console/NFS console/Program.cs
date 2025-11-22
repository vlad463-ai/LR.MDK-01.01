

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
            int time = 0;
            int finish = 80;
            while (true)
            {
                foreach (Car auto in cars)
                {
                    double speed = (auto.GetSpeed() / 50) * time;
                     for (int i = 0; i < speed; i++)
                     {
                        Console.Write(" ");
                        if ( speed>= finish)
                        {
                            Console.Clear();
                            Console.WriteLine("Победитель" + auto.GetModel());
                            return;
                        }
                     }
                    Console.WriteLine(auto.GetModel());
                   
                    Console.WriteLine("----------------------------------------"); 
                    
                }
                time++;
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
