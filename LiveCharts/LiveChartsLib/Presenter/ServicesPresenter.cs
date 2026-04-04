using LiveChartsLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LiveChartsLib.View.ServicesLibrary;

namespace LiveChartsLib.Presenter
{
    public class ServicesPresenter
    {
        private Salon model;
        private List<IServicesView> views;

        public ServicesPresenter(List<IServicesView> viewsList)
        {
            views = viewsList;
            model = new Salon();
            model.Load();
        }

        public void ShowProvisionsForService(string serviceName)
        {
            var provisions = model.GetProvisionsForService(serviceName);
            foreach (var view in views)
            {
                view.Show(provisions);
            }
        }

        public List<Service> GetAllServices()
        {
            return model.GetAllService();
        }

        public double GetRevenuePercent(Service service)
        {
            return Math.Round(Analysis.CalculateRevenuePercent(service.Name, model), 2);
        }

        
        public Dictionary<Service, double> GetAllRevenuePercents()
        {
            return Analysis.CalculateAllPercentages(model);
        }
    }
}
