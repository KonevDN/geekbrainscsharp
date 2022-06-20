using System;

namespace ObfuscateMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secret = "123456";
            Console.Write("Введите пароль для доступа: ");
            string input = Console.ReadLine();
            if (input == secret) Console.WriteLine("Добро пожаловать");
            else Console.WriteLine("В доступе отказано");
            Console.ReadKey();

        }
    }
}
