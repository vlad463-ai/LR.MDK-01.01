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
    }
}
