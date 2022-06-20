/* Практическое задание 2
 * Звучит так: Запросить у пользователя порядковый номер текущего месяца и вывести его название. 
 * Примеры кода для решения задачи взял тут https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/enum#enumeration-types-as-bit-flags 
 * взято тут  https://docs.google.com/document/d/1qg52591RTgqT4SIg0_oFQYYnvdvusaNJA-g2I0JvOKI/edit#heading=h.u9r7mqts77ja
 */

using System;
namespace Project2 
{
    class Program
    {
        public enum MonthsOfУear
        {
            None = 0,  //
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Введите порядковый номер текущего месяца и я выведу его название: ");
            var m = (MonthsOfУear)Convert.ToInt32(Console.ReadLine()); // беру у юзера цифру в виде строки и делаю из нее цифру, потом явно преобразую ее в тип перечисления 
            Console.WriteLine(m);  // оказывается член перечисления выводится как строка не как цифра.
                                   // ЗЫ Можно было две строки кода в одну собрать, но это только излишне усложнит чтение человеку
            Console.WriteLine("Готово.");
            Console.ReadLine();
        }


    }



}