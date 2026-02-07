using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    internal class StorageFilm : IFilm
    {
        public List<CharacteristicsFilms> Film()
        {
            List<CharacteristicsFilms> films = new List<CharacteristicsFilms>();
            string pach = @"C:\REPOO\LR 3\Вариант 3\MovieRental\Фильмы\Фильмы.csv";
            StreamReader sw = new StreamReader(pach);
            string line;
            while ((line = sw.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                films.Add(new CharacteristicsFilms (lines[0], lines[1], lines[2], Convert.ToInt32 (lines[3]),Convert.ToDateTime( lines[4]), lines[5]));
            }
            sw.Close();
            return films;



        }
    }
}
