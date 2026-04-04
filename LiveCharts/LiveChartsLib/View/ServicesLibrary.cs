using LiveChartsLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLib.View
{
    public class ServicesLibrary
    {
        public interface IServicesView
        {
            void Show(List<Provision> provisions);
        }
    }
}
