using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        int d = 1;

        
        Image originalImage;

        public Form1()
        {
            InitializeComponent();

            
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Анимация бегущего человечка";

           
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Left = 0;
            pictureBox1.Top = 50;
            pictureBox1.Width = 80;
            pictureBox1.Height = 100;

            
            if (pictureBox1.Image != null)
            {
                originalImage = pictureBox1.Image;
            }
            else
            {
                
                originalImage = CreateDefaultImage();
                pictureBox1.Image = originalImage;
            }

          
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;

           
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 50;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;

            
            button1.Text = "Выход";
            button2.Text = "Стоп";
            button3.Text = "Старт";

            
            timer1.Enabled = false;
        }

       
        private Image CreateDefaultImage()
        {
            Bitmap bmp = new Bitmap(80, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.FillEllipse(Brushes.Blue, 25, 10, 30, 30); 
                g.FillRectangle(Brushes.Red, 35, 40, 10, 40); 
                g.FillRectangle(Brushes.Black, 20, 45, 40, 5); 
                g.FillRectangle(Brushes.Green, 35, 80, 5, 15); 
                g.DrawString("→", new Font("Arial", 20), Brushes.Black, 30, 20); 
            }
            return bmp;
        }

        
        private Image FlipImage(Image img)
        {
            if (img == null) return null;
            Bitmap bmp = new Bitmap(img);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX); 
            return bmp;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Left = pictureBox1.Left + d;

            
            int formWidth = this.ClientSize.Width;
            int pictureWidth = pictureBox1.Width;

            // ПРОВЕРКА ПРАВОГО КРАЯ ОКНА
            if (pictureBox1.Left >= formWidth - pictureWidth - 10)
            {
                // Фиксируем у правого края
                pictureBox1.Left = formWidth - pictureWidth - 10;

                // ОТРАЖАЕМ ИЗОБРАЖЕНИЕ (теперь бежит влево)
                pictureBox1.Image = FlipImage(originalImage);

                // Меняем направление на лево
                d = -Math.Abs(d);
            }
            // ПРОВЕРКА ЛЕВОГО КРАЯ ОКНА
            else if (pictureBox1.Left <= 0)
            {
                // Фиксируем у левого края
                pictureBox1.Left = 0;

                // ВОЗВРАЩАЕМ ОРИГИНАЛЬНОЕ ИЗОБРАЖЕНИЕ (бежит вправо)
                pictureBox1.Image = originalImage;

                // Меняем направление на право
                d = Math.Abs(d);
            }
        }

        // Событие TrackBar - изменение скорости
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Устанавливаем скорость движения в зависимости от положения ползунка
            int speed = trackBar1.Value;
            if (d >= 0)
                d = speed;
            if (d < 0)
                d = -speed;
        }

        // Кнопка "Старт" - запуск таймера
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = true;
        }

        // Кнопка "Стоп" - остановка таймера
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        // Кнопка "Выход" - закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Обработчики событий
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Не используется в данной программе
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Не используется в данной программе
        }
    }
}