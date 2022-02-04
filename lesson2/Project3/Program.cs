﻿/* Практическое задание Project3 для Урока2 
 * Звучит так: Определить, является ли четным число, введённое пользователем. 
 * оно задано тут  https://docs.google.com/document/d/1qg52591RTgqT4SIg0_oFQYYnvdvusaNJA-g2I0JvOKI/edit#heading=h.u9r7mqts77ja
 */

using System;

namespace Project3
{
    class Program
    {
        static void Main()
        {
            Int32 v1 = 0;

            for (int index = 0; index < 1000; index++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Я определю является ли четным число, введённое Вами, введите его плз: ");
                v1 = Convert.ToInt32(Console.ReadLine());
                
                if ((v1 % 2) == 0) // если деление дало нулевой остаток, значит число является четным
                {
                    Console.WriteLine($" ура! это число {v1} является четным. ");
                }

                if ((v1 % 2) > 0) // если деление дало остаток больше нуля, значит число является нечетным 
                {
                    Console.WriteLine($" ой! это число {v1} является нечетным. ");
                }

            }

            Console.WriteLine(" У вас была 1000 попыток. Запустите приложение заново, чтобы воспользовать им еще раз.");
            Console.ReadKey();


        }
    }
}