using System;
using System.Windows.Forms;

namespace TextWinForm
{
    public partial class MainForm: Form
    {
        int number_;
        public MainForm()
        {
            InitializeComponent();
            Random r = new Random();
            number_ = r.Next(1, 101);
            timer1.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(InputBox.Text);
            if (a > number_)
            {
                MessageBox.Show("Ваше число больше загаданного ");
            }
            else if (a < number_)
            {
                MessageBox.Show("Ваше число меньше загаданного");
            }
            else
            {
                MessageBox.Show("ПОЗДРАВЛЯЮ!!! Вы угадали число ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = timer1..
        }
    }
}
