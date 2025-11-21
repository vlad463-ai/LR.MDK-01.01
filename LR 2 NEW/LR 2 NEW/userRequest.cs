
using System;

namespace LR_2_NEW
{
    class userRequest
    {
        static public string InputUserRequest() // Запрос пользователя 
        {
            Console.WriteLine("Введите пожалуйста букву локального диска (Диск C или Диск D): ");
            return Console.ReadLine();
        }
    }
}
