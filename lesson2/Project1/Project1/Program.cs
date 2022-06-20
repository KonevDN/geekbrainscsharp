/*
Практическое задание Нужно запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
 */


using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_min = null;
            string s_max = null;
            int i_min = 0;
            int i_max = 0;
            int average;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Введите МИНимально холодное значение температуры, которое было сегодня на улице: ");
            s_min = Console.ReadLine();
            i_min = Convert.ToInt32(s_min);
            Console.WriteLine("Введите МАКсимально теплое значение температуры, которое было сегодня на улице: ");
            s_max = Console.ReadLine();
            i_max = Convert.ToInt32(s_max);
            average = (i_max + i_min) / 2;
            Console.WriteLine($" Получается, что средняя температура по больнице равна: {average    }");
            Console.ReadKey();
        }
    }
}