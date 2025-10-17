

using System;

namespace enumeration
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Saturday;

            Console.WriteLine($"Сегодня: {today}");

            if (today == DayOfWeek.Saturday)
            {
                Console.WriteLine("Суббота! Скоро домой! ");
            }
        }
    }
}
