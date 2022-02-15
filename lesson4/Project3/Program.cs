using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Суть_задачи = @"  
            Урок 4 Задача 3
            Написать метод по определению времени года. На вход подаётся число – порядковый номер
            месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
            Autumn. Написать метод, принимающий на вход значение из этого перечисления и
            возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
            ввести с клавиатуры номер месяца и вывести название времени года. Если введено
            некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12 https://gb.ru/lessons/212344";
            
            Console.WriteLine(Суть_задачи);
            Console.WriteLine();

            Console.WriteLine(" Введите порядковый номер текущего месяца и я выведу сезон года: ");
            Season Winter = Season.Winter;
            Season Spring = Season.Spring;
            Season Summer = Season.Summer;
            Season Autumn = Season.Autumn;

            while (true) 
            {
                Int32 mynumber = Convert.ToInt32(Console.ReadLine());
                switch (mynumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine(Winter+"/Зима");
                        Console.WriteLine("попробуйте еще раз. введите другую цифру:");
                        break;

                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine(Spring+"/Весна");
                        Console.WriteLine("попробуйте еще раз. введите другую цифру:");
                        break;

                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine(Summer+ "/Лето");
                        Console.WriteLine("попробуйте еще раз. введите другую цифру:");
                        break;

                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine(Autumn + "/Осень");
                        Console.WriteLine("попробуйте еще раз. введите другую цифру:");
                        break;

                    
                    default:
                        Console.WriteLine("Введеное значение нельзя использовать в этих целях.");
                        Console.WriteLine("попробуйте еще раз. введите другую цифру:");
                        break;
                }
            }
            

        }

    
        public enum Season : byte
        { 
            None = 0,
            Winter = 3,
            Spring = 6,
            Summer = 9,
            Autumn = 12
        }


    }
}
