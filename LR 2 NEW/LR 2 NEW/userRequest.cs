
using System;

namespace LR_2_NEW
{
    class userRequest
    {
        static public string InputUserRequest() // Запрос пользователя
        {
            Console.WriteLine("Введите пожалуйста букву локального диска (C или D): ");
            return Console.ReadLine();
        }
    }
}
