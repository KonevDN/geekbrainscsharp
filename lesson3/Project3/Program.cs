using System;

namespace lesson3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string поясняю_суть_задачи = @" 
/*
*Урок №3, Практическое задание №2
*Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
*/";

            Console.WriteLine(поясняю_суть_задачи);
            System.Console.WriteLine($" ");
            System.Console.WriteLine($" ");
            System.Console.WriteLine($" ");


                string строка1 = Console.ReadLine();
                int длина_строки = строка1.Length;
                //Console.WriteLine(строка1);
                Console.WriteLine(длина_строки);



                for (int текущий_номер_столбца = 0;
                               текущий_номер_столбца < строка1.Length;
                               текущий_номер_столбца++)
                {

                    Console.Write(строка1[(длина_строки - 1)]);
                    длина_строки--;

                }

                Console.WriteLine();
                Console.ReadKey();
            
            


        }
    }
}


// склад кода
//Console.Write(строка1[0]);
//Console.Write(строка1[1]);
//Console.Write(строка1[2]);
//Console.Write(строка1[3]);
//Console.Write(строка1[ (длина_строки-1) ]);