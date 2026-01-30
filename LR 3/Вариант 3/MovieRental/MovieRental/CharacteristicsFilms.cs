using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    internal class CharacteristicsFilms
    {
        private string name_;
        
        private string director_;
        private string actors_;
        private int cost_;
        private DateTime endDate_;

        public CharacteristicsFilms (string name, string director, string actors, int cost, DateTime endDate)
        {
            name_ = name;
            director_ = director;
            actors_ = actors;
            cost_ = cost;
            endDate_ = endDate;
        }

        public string Name
        {
            get { return name_; }
        }
        
        public string Director
        {
            get { return director_; }
        }
        public string Actors
        {
            get { return actors_; }
        }
        public int Cost
        {
            get { return cost_; }
        }
        public DateTime EndDate
        {
            get { return endDate_; }
        }

    }
}
