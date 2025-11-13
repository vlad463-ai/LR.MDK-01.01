using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA__2
{
    class ShearchingModuke
    {
        static public int FindIndexteam(string userQuery, string[] numberofteams) // нахождение индекса команды
        {

            for (int index = 0; index < numberofteams.Length; ++index)
            {
                string team = numberofteams[index].ToLower();
                if (team == userQuery.ToLower())
                {
                    return index;
                }
            }
            return -1;

        }
        static public (List<int>, List<string>, List<int>) FindingEverythingForTheTeam(int indexteam, List<string>[] players, List<int>[] spast, List<int>[] goalsplauers) // нахождение всего для команды
        {
            List<int> teamspast = new List<int>(); //колво очков команды
            List<string> teamnamess = new List<string>(); // игроки команды
            List<int> goal = new List<int>(); // колво мячей у человека
            teamnamess = players[indexteam];
            teamspast = spast[indexteam];
            goal = goalsplauers[indexteam];
            return (teamspast, teamnamess, goal);
        }
    }
}
