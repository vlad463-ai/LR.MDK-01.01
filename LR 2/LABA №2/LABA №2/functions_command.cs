using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA__2
{
    class functions_command
    {
        static public (List<int>[], List<string>[], List<int>[]) Comandinputdata()
        {

            List<int>[] teamшspast = new List<int>[6] //кол-во очков
            {
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>()
            };
            List<string>[] players = new List<string>[6] // игроки команды
            {
              new List<string>(),
              new List<string>(),
              new List<string>(),
              new List<string>(),
              new List<string>(),
              new List<string>()
            };
            List<int>[] goalsplauers = new List<int>[6] // мячи каждого игрока
            {
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>(),
              new List<int>()
            };
            // Заполняем команды очками и именами

            teamшspast[0].Add(3);
            players[0].Add("Ира");
            goalsplauers[0].Add(10);
            players[0].Add("Юля");
            goalsplauers[0].Add(6);
            players[0].Add("Уля");
            goalsplauers[0].Add(8);

            teamшspast[1].Add(15);
            players[1].Add("Гога");
            goalsplauers[1].Add(15);
            players[1].Add("Иван");
            goalsplauers[1].Add(19);
            players[1].Add("Петя");
            goalsplauers[1].Add(20);

            teamшspast[2].Add(12);
            players[2].Add("Влад");
            goalsplauers[2].Add(14);
            players[2].Add("Кирилл");
            goalsplauers[2].Add(16);
            players[2].Add("Артем");
            goalsplauers[2].Add(22);

            teamшspast[3].Add(19);
            players[3].Add("Юля");
            goalsplauers[3].Add(2);
            players[3].Add("Галя");
            goalsplauers[3].Add(4);
            players[3].Add("Вика");
            goalsplauers[3].Add(25);

            teamшspast[4].Add(11);
            players[4].Add("Денчик");
            goalsplauers[4].Add(5);
            players[4].Add("Игорь");
            goalsplauers[4].Add(10);
            players[4].Add("Валим");
            goalsplauers[4].Add(12);

            teamшspast[5].Add(16);
            players[5].Add("Валера");
            goalsplauers[5].Add(24);
            players[5].Add("Серега");
            goalsplauers[5].Add(30);
            players[5].Add("Олег");
            goalsplauers[5].Add(29);
            return (teamшspast, players, goalsplauers);
        }
        static public string InputUserQuery() // входной пользовательский запрос
        {
            Console.Write("Введите, пожалуйста, название команды: ");
            return Console.ReadLine();
        }
    }
}
