

using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Dictionary
{
    class Program
    {
        static public void AllElementValues(Dictionary<string, List<string>> Dictionary)
        {
            Console.WriteLine("Какая цена вам интересна (Дорогие, Средние, Дешёвые): ");
            string UserRequest = Console.ReadLine();
            List<string> brands = Dictionary[UserRequest];
            Console.WriteLine("Число марок автомобилей: " +Dictionary.Values.Count);
            Console.Write("Все марки автомобилей: " +string.Join(", ", brands));
            
        }
        static void Main(string[] args)
        {
            //Создание словаря
            Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>(); 
            //Заполнение словаря
            Dictionary.Add("Дорогие", new List<string>() {"Бентли"}); 
            Dictionary.Add("Средние", new List<string>() { "Форд", "Ниссан" });
            Dictionary.Add("Дешёвые", new List<string>() { "Двенашка", "Семёрка", "Четырка" });
            // Вывод на экран всех ключей
            Console.Write(string.Join(", ", Dictionary.Keys));
            // Вывод на экран значения через запятую по любому ключу
            Console.WriteLine();
            Console.WriteLine("Какой тип машины вам интересен: ");
            string a = Console.ReadLine();
            List<string> price = Dictionary[a];
            Console.WriteLine(string.Join(",", price));
            //Зпрос ключа пользователем по запросу выводит число элементов значения указанного ключа
            AllElementValues(Dictionary);




        }
    }
}
