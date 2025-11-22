

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


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
            auto.SetSpeed(1150);
            Print(auto);

            Car merc = new Car(); // объект merc
            merc.SetModel("Мерс");
            merc.SetSpeed(300);
            Print(merc);

            List<Car> cars = new List<Car>(); // список для хранения объектов
            cars.Add(auto);
            cars.Add(merc);

        }
    }
}
