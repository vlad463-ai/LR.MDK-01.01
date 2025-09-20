
using System;
using System.Collections.Generic;


namespace LIST_Prakt
{
    class Program
    {
        static void Main()
        {
            ///создали лист-список
            List<string> text = new List<string>();
            
            ///Заполнили список пятью элементами
            text.Add("grup");
            text.Add("PC");
            text.Add("film");
            text.Add("case");
            text.Add("box");
            
            /// Ввод текста с клавиатуры
            Console.WriteLine("Введите текст: ");
            string user = Console.ReadLine();
            //Console.WriteLine(user);

            List<string> input = new List<string>();
            
            for(int i =0; i< text.Count;i++)
            {
                if (text[i].Contains(user))
                {
                    input.Add(text[i]);
                }
            }
            foreach(string m in input)
            {
                Console.WriteLine(m);
            }
            
            
            









        }

        
    }
}
