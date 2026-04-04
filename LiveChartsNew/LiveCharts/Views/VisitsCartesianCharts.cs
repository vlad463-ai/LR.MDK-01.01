using LiveCharts.Wpf;
using LiveChartsLibrary;
using LiveChartsLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LiveCharts.Views
{
    public class VisitsCartesianCharts : LiveCharts.WinForms.CartesianChart,
                                       IVisitView
    {
        private LineSeries seriesData_;
        public VisitsCartesianCharts()
        {
            seriesData_ = new LineSeries
            {
                Title = "Посещение",

                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                        System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                        System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                        90)
            };

            /// Ось Y
            AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    IsEnabled = false,
                },

                MinValue = 0
            }
            );


            /// Ось X
            AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }
        public void Show(List<Visit> visits)
        {
            if (visits == null || visits.Count == 0) return;

            var X = AxisX[0];
            var Y = AxisY[0];

            {
                int maxValue = visits.Max(visit => visit.Count);
                Y.MaxValue = maxValue + 1;
            }

            X.Labels = new string[visits.Count];
            seriesData_.Values = new ChartValues<int>();
            for (int index = 0; index < visits.Count; ++index)
            {
                X.Labels[index] = visits[index].Date.ToShortDateString();
                seriesData_.Values.Add(visits[index].Count);
            }

            Series = new SeriesCollection { seriesData_ };
        }
    }
}
