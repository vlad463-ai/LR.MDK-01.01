using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace ChartTest.Views
{
    public class SalesPieChart : LiveCharts.WinForms.PieChart
    {
        
        private SalesPresenter presenter_;
        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Item> salles = presenter_.GetAllItems();
            SeriesCollection seriesViews = new SeriesCollection();
            foreach (var item in salles)
            {
                seriesViews.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double>() { presenter_.GetProfitPercentByItem(item) }
                });
            }
            Series = seriesViews;


        }
    }
}
