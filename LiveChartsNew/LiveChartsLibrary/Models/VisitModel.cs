using System.Collections.Generic;
using System.Linq;

namespace LiveChartsLibrary.Modesl
{
    public class VisitModel
    {
        private Dictionary<Service, List<Visit>> visitByService_ = new Dictionary<Service, List<Visit>>();

        public void AddVisit(Service service, List<Visit> visit) // добавление посещения услуги
        {
            if (visitByService_.ContainsKey(service))
            {
                visitByService_[service].AddRange(visit);
            }
            else
            {
                visitByService_.Add(service, visit);
            }
        }

        public List<Visit> LoadVisitsForService(string sectionName) // вывод посещений для определенной услуги
        {
            List<Service> allItems = visitByService_.Keys.ToList();
            Service targetService = allItems.Find(section => section.Name == sectionName);
            if (targetService != null)
            {
                return visitByService_[targetService];
            }

            return new List<Visit>();
        }

        public bool Load() // Добавление данных
        {
            AddVisit(new Service { Name = "Стрижка", Price = 800 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 10 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 20 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 30 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 40 },
                    new Visit {Date = new System.DateTime(2026, 2, 5), Count = 50 },
                });

            AddVisit(new Service { Name = "Окрашивание", Price = 2500 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 2 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 3 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 4 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 1 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 15 },
               });
            AddVisit(new Service { Name = "Маникюр", Price = 1200 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 99 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 1 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 21 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 25 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 55 },
               });
            AddVisit(new Service { Name = "Педикюр", Price = 1500 },
                new List<Visit>() {
                    new Visit {Date = new System.DateTime(2026, 2, 1), Count = 15 } ,
                    new Visit {Date = new System.DateTime(2026, 2, 2), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 2, 3), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 2, 4), Count = 15 },
                    new Visit {Date = new System.DateTime(2026, 3, 5), Count = 15 },
               });

            return true;
        }
        public List<Service> GetAllService() // получение всех ключей(услуг)
        {
            return visitByService_.Keys.ToList();
        }
        public Service GetService(string serviceName) // получение услуги
        {
            foreach (KeyValuePair<Service, List<Visit>> keyValue in visitByService_)
            {
                Service service = keyValue.Key;
                if (service.Name == serviceName)
                {
                    return service;
                }
            }

            return null;
        }
        public double GetTotalProfit() // получение общей прибыли
        {
            double result = 0.0;
            foreach (KeyValuePair<Service, List<Visit>> keyValue in visitByService_)
            {
                Service section = keyValue.Key;
                result += keyValue.Value.Sum(visit => visit.Count * section.Price);
            }

            return result;
        }
    }
}
