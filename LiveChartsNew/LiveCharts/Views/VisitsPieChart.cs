using LiveCharts.Wpf;
using LiveChartsLibrary;
using LiveChartsLibrary.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCharts.Views
{
    public class VisitsPieChart : LiveCharts.WinForms.PieChart
    {
        private VisitsPresenter presenter_;

        public void SetPresenter(VisitsPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Section> allSections = presenter_.GetAllSections(); ;
            SeriesCollection seriesData = new SeriesCollection();
            foreach (Section s in allSections)
            {
                seriesData.Add(new PieSeries
                {
                    Title = s.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByItem(s) },
                    DataLabels = true,
                    //Fill = System.Windows.Media.Brushes.BlueViolet
                });
            }
            Series = seriesData;
            //LegendLocation = LegendLocation.Left;
        }
    }
}
