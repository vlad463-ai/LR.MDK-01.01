

using System;
using System.Runtime.InteropServices;

namespace NFS_console
{
    class Program
    {
        static void Main()
        {
            Car auto = new Car();
            auto.SetModel("Лада");
            Console.WriteLine(auto.GetModel());

        }
    }
}
