using LiveChartsLibrary;
using LiveChartsLibrary.Presenters;
using LiveChartsLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCharts
{
    public partial class MainForm : Form
    {
        private VisitsPresenter presenter_;
        void FillCartesianChart()
        {
            SectionListBox.DataSource = presenter_.GetAllSections();
            SectionListBox.DisplayMember = "Name";
            if (SectionListBox.Items.Count > 0)
            {
                presenter_.ShowVisitsBySection(((Section)SectionListBox.Items[0]).Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new VisitsPresenter(new List<IVisitView> { cartesian });

            FillCartesianChart();
            pie.SetPresenter(presenter_);
            pie.UpdateView();
        }

        private void SectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Section selectedSection = ((Section)(SectionListBox.SelectedItem));
            if (selectedSection == null)
            {
                return;
            }

            presenter_.ShowVisitsBySection(selectedSection.Name);
            //double percent = Math.Round(
            //presenter_.GetProfitPercentByItem(selectedSection), 2);
        }

    }
}
