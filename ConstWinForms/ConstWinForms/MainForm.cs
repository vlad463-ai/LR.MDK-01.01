using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConstWinForms
{
    public partial class MainForm: Form
    {
        private List<Student> listStudent_ = new List<Student>();
        public MainForm()
        {
            InitializeComponent();

            listStudent_.Add(new Student("Влад", 17, 4.63, 122, @"D:\\лица мужчин\\смирнров.jpg"));
            listStudent_.Add(new Student("Никита", 18, 4.2, 83, @"D:\\лица мужчин\\никита.jpg"));
            listStudent_.Add(new Student("Кирилл", 19, 4.83, 13, @"D:\\лица мужчин\\кирилл.jpg"));
            NameBox.DataSource = listStudent_;
            NameBox.DisplayMember = "Name";




        }

        private void NameBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Student s1=  NameBox.SelectedItem as Student;
            AgeLabel.Text = s1.Age.ToString();
            ScoreLabel.Text = s1.AvgScore.ToString();
            NumberLabel.Text = s1.NumberID.ToString();
            ImageBox1.Load(s1.Photo);

           



        }

        
    }
}
