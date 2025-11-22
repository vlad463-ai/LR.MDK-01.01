

using System;
using System.Runtime.InteropServices;


namespace NFS_console
{
    class Program
    {
        static public void Print(Car auto)
        {
            Console.WriteLine(auto.GetModel());
        }
        static void Main()
        {
            Car auto = new Car();
            auto.SetModel("Лада");
            auto.SetSpeed(1150);
            Console.WriteLine(auto.GetModel());

            Car merc = new Car();
            merc.SetModel("Мерс");
            merc.SetSpeed(300);
            Print(merc);

        }
    }
}
