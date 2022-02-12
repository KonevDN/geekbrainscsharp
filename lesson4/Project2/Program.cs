using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main()
        {
            string Суть_задачи = @"  
            Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
            возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
            результат на экран. https://gb.ru/lessons/212344/homework";

            Int32 Сумма = 0;
            String[] Строка_разделенная_на_части = Разделить_строку_на_части(Взять_строку());
            foreach (var Часть in Строка_разделенная_на_части)
            {
                Сумма = Сумма + Convert.ToInt32(Часть);
                Console.WriteLine($"Substring: {Часть}");
            }

            Console.WriteLine(Сумма);
            Console.ReadKey();

        }

        static String Взять_строку() 
        {
            String Набор_чисел_через_пробел = Console.ReadLine();
            return Набор_чисел_через_пробел;
        }

        static String[] Разделить_строку_на_части(String Набор_чисел_через_пробел) 
        {
            String[] Строка_разделенная_на_части = Набор_чисел_через_пробел.Split(' ');
            return Строка_разделенная_на_части;
        }


    }
}
