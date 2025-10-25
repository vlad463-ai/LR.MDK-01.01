

using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>();
            Dictionary.Add("дорогие", new List<string>() {"Бентли","Ламборгини","Кадиллак"});
            Dictionary.Add("средние", new List<string>() { "Форд", "Ниссан", "Шевроле" });
            Dictionary.Add("дешовые", new List<string>() { "Двинка", "Семёрка", "Четырка" });
        }
    }
}
