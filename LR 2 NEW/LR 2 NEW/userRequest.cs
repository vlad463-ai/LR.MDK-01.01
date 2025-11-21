
using System;

namespace LR_2_NEW
{
    class userRequest
    {
        static public string InputUserRequest() // Запрос пользователя 
        {
            Console.WriteLine("Введите пожалуйста локальный диск (Диск C или Диск D): ");
            return Console.ReadLine();
        }
    }
}
