

using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveChartsLib.Model
{
    public class Salon // Салон красоты
    {
        private Dictionary<Service,List <Provision>> provisionByService_ = new Dictionary<Service,List <Provision>>(); // предоставление услуг

        public void AddProvision (Service service, List<Provision> provisions) // проверка есть ли эти услуги и добавление
        {
            if (provisionByService_.ContainsKey (service))
            {
                provisionByService_ [service].AddRange (provisions);
            }
            else
            {
                provisionByService_.Add (service, provisions);
            }
        }
        public bool Load()
        {
          
            AddProvision(new Service { Name = "Стрижка", Price = 800 }, // стрижка, 800 рублей 
                new List<Provision> {
                    new Provision { Date = new DateTime(2026, 3, 1), Count = 5 },
                    new Provision { Date = new DateTime(2026, 3, 2), Count = 7 },
                    new Provision { Date = new DateTime(2026, 3, 3), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 4), Count = 6 },
                    new Provision { Date = new DateTime(2026, 3, 5), Count = 8 },
                    new Provision { Date = new DateTime(2026, 3, 6), Count = 5 },
                    new Provision { Date = new DateTime(2026, 3, 7), Count = 9 },
                    new Provision { Date = new DateTime(2026, 3, 8), Count = 7 },
                    new Provision { Date = new DateTime(2026, 3, 9), Count = 6 },
                    new Provision { Date = new DateTime(2026, 3, 10), Count = 4 }
                });
          
            AddProvision(new Service { Name = "Окрашивание", Price = 2500 }, // окрашивание, 2500 рублей
                new List<Provision> {
                    new Provision { Date = new DateTime(2026, 3, 1), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 2), Count = 1 },
                    new Provision { Date = new DateTime(2026, 3, 3), Count = 3 },
                    new Provision { Date = new DateTime(2026, 3, 4), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 5), Count = 3 },
                    new Provision { Date = new DateTime(2026, 3, 8), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 9), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 10), Count = 1 }
                });

           
            AddProvision(new Service { Name = "Маникюр", Price = 1200 }, // маникюр, 1200 рублей
                new List<Provision> {
                    new Provision { Date = new DateTime(2026, 3, 1), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 2), Count = 3 },
                    new Provision { Date = new DateTime(2026, 3, 3), Count = 5 },
                    new Provision { Date = new DateTime(2026, 3, 4), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 5), Count = 6 },
                    new Provision { Date = new DateTime(2026, 3, 6), Count = 7 },
                    new Provision { Date = new DateTime(2026, 3, 7), Count = 5 },
                    new Provision { Date = new DateTime(2026, 3, 8), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 9), Count = 3 }
                });

           
            AddProvision(new Service { Name = "Массаж", Price = 1800 }, // массаж, 1800 рублей 
                new List<Provision> {
                    new Provision { Date = new DateTime(2026, 3, 2), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 4), Count = 3 },
                    new Provision { Date = new DateTime(2026, 3, 6), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 8), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 10), Count = 3 }
                });
            
            AddProvision(new Service { Name = "Педикюр", Price = 1500 }, // педикюр, 1500 рублей
                new List<Provision> {
                    new Provision { Date = new DateTime(2026, 3, 1), Count = 2 },
                    new Provision { Date = new DateTime(2026, 3, 3), Count = 3 },
                    new Provision { Date = new DateTime(2026, 3, 5), Count = 4 },
                    new Provision { Date = new DateTime(2026, 3, 7), Count = 5 },
                    new Provision { Date = new DateTime(2026, 3, 9), Count = 3 }
                });

            return true;
        }
        public List<Service> GetAllService() // получение всех услуг
        {
            return provisionByService_.Keys.ToList();
        }
        public double GetTotalRevenue() // получение общей выручки
        {
            double summ = 0;
            foreach(var i in provisionByService_)
            {
                Service service = i.Key;
                summ += i.Value.Sum(p => p.Count * service.Price);
            }
            return summ;
        }
        public Service GetService(string itemName) // получение услуги по имени
        {
            foreach (KeyValuePair<Service, List<Provision>> keyValue in provisionByService_)
            {
                Service item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }

            return null;
        }
        public List<Provision> GetProvisionsForService(string serviceName) // получение всех оказанных услуг по имени
        {
            var service = GetService(serviceName);
            if (service != null && provisionByService_.ContainsKey(service))
            {
                return provisionByService_[service];
            }
            return new List<Provision>();
        }


    }
}
