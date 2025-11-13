

using System.Collections.Generic;
using System;

namespace LABA__2
{
    class Program
    {
        static void PrintPlayer(List<string> players)
        {
            Console.WriteLine(String.Join(", ", players));
        }
        static void PrintGoalsOrScore(List<int> teamspast)
        {
            Console.WriteLine(String.Join(", ", teamspast));
        }
        static void Main()
        {
            string[] commands = new string[] { "1 команда", "2 команда", "3 команда", "4 команда", "5 команда", "6 команда" };
            var (spast, name, goals) = functions_command.Comandinputdata();

            string userQuery = functions_command.InputUserQuery();
            int indexcommand = ShearchingModuke.FindIndexteam(userQuery, commands);

            if (indexcommand < 0)
            {
                Console.WriteLine("Указана несуществующая команда");
                return;
            }
        }
    }
}
