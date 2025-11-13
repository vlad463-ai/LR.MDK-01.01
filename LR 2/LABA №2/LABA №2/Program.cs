

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
            var (teamspast, teamnamess, goal) = ShearchingModuke.FindingEverythingForTheTeam(indexcommand, name, spast, goals);
            Console.Write("Имена  игроков команды: ");
            PrintPlayer(teamnamess);
            Console.Write("Очки выбраной команды: ");
            PrintGoalsOrScore(teamspast);
            Console.Write("Голы каждого игрока: ");
            PrintGoalsOrScore(goal);
            int maxNumder = AnalysisDataModules.MaxScoreTeams(spast);
            int backlog = AnalysisDataModules.LaggingBehindFirstPlace(teamspast, maxNumder);
            Console.WriteLine("Отставание от первого места: " + backlog + " очков");
            AnalysisDataModules.SortPlayers(teamnamess, goal);
        }
    }
}
