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
        int totalShow = 0;


        public MainForm()
        {
            InitializeComponent();
            horror.Add(new CharacteristicsFilms ("Пятница 13", "Виктор Миллер", "Клей Миллер", 1000, new DateTime(2026, 01, 20), @".\картинки\13.jpg"));
            horror.Add(new CharacteristicsFilms("сихиатрическая больница", "Пак Сан Мин ", "Ви Ха Джун", 500, new DateTime(2026, 02, 19), @".\картинки\больница.jpg"));
            fantastic.Add(new CharacteristicsFilms("Главный герой", "Шон Леви", "Джоди Комер", 100, new DateTime(2026, 05, 10), @".\картинки\герой.jpg"));
            fantastic.Add(new CharacteristicsFilms("Эра выживания", "Кристина Буожите ", "Эдди Марсан", 5000, new DateTime(2026, 01, 15), @".\картинки\эра.jpg"));

            ListBoxGenre.Items.Add("Хоррор");
            ListBoxGenre.Items.Add("Фантастика");

        }

        private void ListBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMovie.Items.Clear();
            string genre = ListBoxGenre.SelectedItem.ToString();
            if (genre == "Хоррор")
            {
                foreach (CharacteristicsFilms films in horror)
                {
                    comboBoxMovie.Items.Add(films.Name);
                }
            }
            else if (genre == "Фантастика")
            {
                foreach (CharacteristicsFilms films in fantastic)
                {
                    comboBoxMovie.Items.Add(films.Name);
                }
            }
            if ( comboBoxMovie.Items.Count != 0 )
            {
                comboBoxMovie.SelectedIndex = 0;
            }
        }

        

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            
            if (comboBoxMovie.SelectedItem == null)
            {
                return;
            }

            string movieName = comboBoxMovie.SelectedItem.ToString();
            string genre = ListBoxGenre.SelectedItem.ToString();
            CharacteristicsFilms selectedFilm = null;
            if (genre == "Хоррор")
            {
                foreach (CharacteristicsFilms film in horror)
                {
                    if (film.Name == movieName)
                    {
                        selectedFilm = film;
                        break;
                    }
                }
            }
            else if (genre == "Фантастика")
            {
                foreach (CharacteristicsFilms film in fantastic)
                {
                    if (film.Name == movieName)
                    {
                        selectedFilm = film;
                        break;
                    }
                }
            }
            if (selectedFilm != null)
            {
                RichTextBoxInfo.Text = $"Название: {selectedFilm.Name}\n" +
                                      $"Режиссер: {selectedFilm.Director}\n" +
                                      $"Актеры: {selectedFilm.Actors}\n" +
                                      $"Стоимость: {selectedFilm.Cost} руб.\n" +
                                      $"До: {selectedFilm.EndDate:dd.MM.yyyy}";



            }
            if (selectedFilm != null)
            {

                RichTextBoxInfo.Text = selectedFilm.GetFullInfo();
            }

            totalShow = (int)NumericUpDownValue.Value;
            RichTextBoxInfo.Text += $"\nЗаказано показов: {totalShow}";
        }
     

        private void comboBoxMovie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string movieName = comboBoxMovie.Text;


            foreach (CharacteristicsFilms film in horror)
            {
                if (film.Name == movieName)
                {

                    pictureBoxFilm.Load(film.Photo);
                }
            }
                

            foreach (CharacteristicsFilms film in fantastic)
            {
                if (film.Name == movieName)
                {
                    pictureBoxFilm.Load(film.Photo);
                }
                   
            }
                
        }
    }
    
}
