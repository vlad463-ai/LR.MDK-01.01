

using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
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





        }
    }
}
