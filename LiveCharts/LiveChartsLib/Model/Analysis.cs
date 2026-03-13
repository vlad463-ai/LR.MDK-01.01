

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LiveChartsLib.Model
{
    public class Analysis
    {

        public static double CalculateRevenuePercent(string serviceName, Salon model) // расчет проента выручки для конкретной услуги
        {
            var service = model.GetService(serviceName);
            if (service == null) return 0;

            var provisions = model.GetProvisionsForService(serviceName);
            double serviceRevenue = provisions.Sum(p => p.Count * service.Price);
            double totalRevenue = model.GetTotalRevenue();

            if (totalRevenue == 0) return 0;
            return serviceRevenue / totalRevenue * 100.0;
        }
        public static Dictionary<Service, double> CalculateAllPercentages(Salon model) // pасчет процентов для всех услуг
        {
            var result = new Dictionary<Service, double>();
            var services = model.GetAllService();
            double totalRevenue = model.GetTotalRevenue();

            foreach (var service in services)
            {
                var provisions = model.GetProvisionsForService(service.Name);
                double serviceRevenue = provisions.Sum(p => p.Count * service.Price);

                double percent = totalRevenue > 0 ? serviceRevenue / totalRevenue * 100.0 : 0;
                result.Add(service, percent);
            }

            return result;
        }

    }   }   
