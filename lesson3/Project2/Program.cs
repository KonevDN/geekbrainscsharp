using System;
namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string поясняю_суть_задачи = @" 
/*
*Урок №3, Практическое задание №2
*Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
*ЗЫ Уточнение от препода Сергея Драмарецкого Да, захардкодить массив и потом вывести его на экран. Просто отработать навык работы с двухмерным массивом.
*Источник задачи https://docs.google.com/document/d/1-3lIX6FLZx-9JxgWu0Dn3JYK7KvhiXPfIr5ZyVo1eTs/edit#heading=h.cg6d198vimyy 
*Ссылка на урок https://gb.ru/lessons/163440 
*/";

            Console.WriteLine(поясняю_суть_задачи);
            System.Console.WriteLine($" ");
            System.Console.WriteLine($" ");
            System.Console.WriteLine($" ");




            const int заданное_количество_строк = 5;
            const int заданное_количество_столбцов = 2;
            string[,] телефонная_книга = new string[заданное_количество_строк, заданное_количество_столбцов]
            {
                {"Ученик Даниил Конев","+7 981 8856 863"},
                {"Школа Гикбрейнс","8 800 700-68-41"},
                {"Препод Сергей Драмарецкий","https://gb.ru/users/5967972"},
                {"Валерий Шибанов разработчик в Mail.ru Group","8 800 123 456"},
                {"Сайт https://gb.ru/ ","+7 499 922-47-10"}
            };

            System.Console.WriteLine($"ТЕЛЕФОННАЯ КНИГА:");
            int используемая_размерность_массива;
            for (int текущий_номер_строки = 0;
                        текущий_номер_строки < телефонная_книга.GetLength(используемая_размерность_массива = 0);
                        текущий_номер_строки++)
            {
                for (int текущий_номер_столбца = 0;
                            текущий_номер_столбца < телефонная_книга.GetLength(используемая_размерность_массива = 1);
                            текущий_номер_столбца++)
                {

                    System.Console.Write($" {телефонная_книга[текущий_номер_строки, текущий_номер_столбца]} ");
                    System.Console.Write($"\t");
                    System.Console.Write($"\t");
                    System.Console.Write($"\t");
                }
                System.Console.Write($"\r\n");
            }

            System.Console.Write($"\r\n");
            System.Console.Write($"\r\n");
            System.Console.Write($"\r\n");
            System.Console.Write($"Думаю, что задача была выполнена успешно. ");
            Console.ReadKey();
        }
    }
}


