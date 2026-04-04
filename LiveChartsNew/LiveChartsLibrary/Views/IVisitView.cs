using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsLibrary.Views
{
    public interface IVisitView
    {
        void Show(List<Visit> visits);
    }
}
