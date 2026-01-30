using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class MainForm : Form
    {
        List <CharacteristicsFilms> horror = new List <CharacteristicsFilms> ();
        List<CharacteristicsFilms> fantastic = new List<CharacteristicsFilms>();

        public MainForm()
        {
            InitializeComponent();
            horror.Add(new CharacteristicsFilms ("Пятница 13", "Виктор Миллер", "Клей Миллер", 1000, new DateTime(2026, 01, 20)));
            horror.Add(new CharacteristicsFilms("сихиатрическая больница", "Пак Сан Мин ", "Ви Ха Джун", 500, new DateTime(2026, 02, 19)));
            fantastic.Add(new CharacteristicsFilms("Главный герой", "Шон Леви", "Джоди Комер", 100, new DateTime(2026, 05, 10)));
            fantasticБ.Add(new CharacteristicsFilms("Эра выживания", "Кристина Буожите ", "Эдди Марсан", 5000, new DateTime(2026, 01, 15)));

        }

        
    }
}
