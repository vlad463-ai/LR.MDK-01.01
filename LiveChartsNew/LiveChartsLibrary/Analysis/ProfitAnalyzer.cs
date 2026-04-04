using LiveChartsLibrary.Modesl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLibrary.Analysis
{
    public class ProfitAnalyzer
    {
        public static double CalculateProfitPercentBySection(string sectionName, VisitModel model) // расчет процента прибыли
        {
            List<Visit> sectionVisits = model.LoadVisitsForService(sectionName);
            Service targetService = model.GetService(sectionName);
            if (targetService == null)
            {
                return 0.0;
            }
            double serviceTotal = sectionVisits.Sum(visit => visit.Count * targetService.Price);

            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return serviceTotal / total * 100.0;
        }
    }
}
