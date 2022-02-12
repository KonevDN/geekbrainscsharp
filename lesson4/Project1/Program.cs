using System;
namespace Project1

{
    class Program
    {
        static void Main(string[] args)
        {
            string поясняю_суть_задачи = @" 
/*
*Урок №4, Практическое задание №1
*поясняю_суть_задачи - Написать метод GetFullName(string firstName, string lastName, string
*patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
*объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
3–4 разных ФИО.  https://gb.ru/lessons/212344/homework  
*/";


            Console.WriteLine(GetFullName("Конев","Даниил","Николаевич"));
            Console.WriteLine(GetFullName("Сталин", "Иосиф", "Виссарионович"));
            Console.WriteLine(GetFullName("Ленин", "Владимир", "Ильич"));
            Console.ReadKey(); 

        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            String space = " ";
            return firstName + space + lastName + space + patronymic;
        }
    }
}
