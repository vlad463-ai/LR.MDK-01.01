using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA__2
{
    class AnalysisDataModules
    {
        static public void SortPlayers(List<string> players, List<int> goals) // сортировка игроков
        {
            for (int i = 0; i < goals.Count; i++)
            {
                for (int j = 0; j < goals.Count - 1; j++)
                {
                    bool condition = goals[j + 1] > goals[j];
                    if (condition)
                    {
                        int temp_goals = goals[j];
                        goals[j] = goals[j + 1];
                        goals[j + 1] = temp_goals;

                        string temp_players = players[j];
                        players[j] = players[j + 1];
                        players[j + 1] = temp_players;
                    }
                }
            }
        }
    }
}
