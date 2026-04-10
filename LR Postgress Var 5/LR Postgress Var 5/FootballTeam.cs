using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Postgress_Var_5
{
    public class FootballTeam
    {
        public string fio;
        public int gameNumber;
        public int numberOfGoalsScored;
        public int numberOfGears;
        [DisplayName("ФИО")]
        public string Fio { get { return fio; } set { fio = value; OnPropertyChanged(nameof(fio)); } }
        [DisplayName("Игровой номер")]
        public int GameNumber { get { return gameNumber; } set { gameNumber = value; OnPropertyChanged(nameof(gameNumber)); } }
        [DisplayName("Забитые голы")]
        public int NumberOfGoalsScored { get { return numberOfGoalsScored; } set { numberOfGoalsScored = value; OnPropertyChanged(nameof(numberOfGoalsScored)); } }
        [DisplayName("Число передач")]
        public int NumberOfGears { get { return numberOfGears; } set { numberOfGears = value; OnPropertyChanged(nameof(numberOfGears)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
