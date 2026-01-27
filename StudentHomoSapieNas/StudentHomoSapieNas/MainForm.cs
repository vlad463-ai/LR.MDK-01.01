using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHomoSapieNas
{
    public partial class MainForm: Form
    {
        private List<HomaSappiens> allPeople_ = new List<HomaSappiens>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            allPeople_.Add(new HomaSappiens("Майк Вазовски", 200));
            allPeople_.Add(new HomaSappiens("Тайлер Дёрден", 30));
            allPeople_.Add(new Student(12412));

            foreach (HomaSappiens people in allPeople_)
            {
                HomoSappiensInfoRichTextBox.AppendText(people.ToString() + "\n");
            }

            StudentInfoRichTextBox.Text = string.Join(",", AllStudeent());
        }

        public List<string> AllStudeent()
        {
            List<string> result = new List<string>();
            foreach (HomaSappiens peaple in allPeople_)
            {
                Student st = peaple as Student;
                if ( st != null)
                {
                    result.Add(st.ToString());
                }
            }
            return result;
        }

        
    }
}
