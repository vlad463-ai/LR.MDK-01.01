using System;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsTest
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                pictureArea.Load(FileNamesListBox.SelectedItem.ToString());
                pictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD1 = new OpenFileDialog();
            OFD1.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            string text = "";
            if(OFD1.ShowDialog() == DialogResult.OK)
            {
                text = OFD1.FileName;
                FileNamesListBox.Items.Add(text);
                
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeletButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Вы действительно хотите удалить ?", "Уверены?",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                FileNamesListBox.Items.RemoveAt(FileNamesListBox.SelectedIndex);
                pictureArea.Image = null;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD2 = new OpenFileDialog();
            OFD2.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            string text = "";
            if (OFD2.ShowDialog() == DialogResult.OK)
            {
                text = OFD2.FileName;
                FileNamesListBox.Items.выа


            }
        }
    }
}
