using LiveChartsLibrary.Analysis;
using LiveChartsLibrary.Modesl;
using LiveChartsLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLibrary.Presenters
{
    public class VisitsPresenter
    {
        private VisitModel model_ = new VisitModel();
        private List<IVisitView> views_;
        public VisitsPresenter(List<IVisitView> views)
        {
            views_ = views;

            model_.Load();
        }
        public void ShowVisitsBySection(string sectionName) // показать раздел визит
        {
            List<Visit> visits = model_.LoadVisitsForService(sectionName);
            foreach (IVisitView view in views_)
            {
                view.Show(visits);
            }
        }
        public List<Service> GetAllService() // получение всех ключей
        {
            return model_.GetAllService();
        }
        public double GetProfitPercentByItem(Service selectedSection) // получение прибыли от объекта
        {
            double result = ProfitAnalyzer.CalculateProfitPercentBySection(selectedSection.Name,
                                                               model_);
            return Math.Round(result, 2);
        }
    }
}
