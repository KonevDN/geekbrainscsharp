/* Практическое задание Project4 для Урока2 
 * Звучит так: Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
 * только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, 
 * которые были заранее заготовлены до вывода на консоль. 
 * Оригинал фотки чека лежит тут https://irecommend.ru/sites/default/files/imagecache/copyright1/user-images/379799/R7zWu5vrnc4T21nQYqLhA.jpg 
 */

using System;
namespace Project4 
{
    class Program
    {
        static void Main(string[] args)
        {
            string name_of_paper = "ЧЕК ПРОДАЖИ";
            string name_of_goods = "1. ГЕЛЬ СМАЗКА ДЮРЕКС ПЛЭЙ ХИТ 5000 МЛ";
            string multiplicator = "2830.00 руб. x 1 упак. ....... 2830.00";
            string NM_name = "НМ";
            string NM_number = "00007253";
            string INN_name = "ИНН";
            string INN_number = "123456789123";
            string SHARP_number = "1234";
            //DateTime date = new DateTime(2021, 9, 5, 19, 57, 01); // это рабочий код если руками задавать
            DateTime date = DateTime.Now; // это рабочий код чтобы получить живое текущее время
            string date1 = date.ToString("dd.MM.yyyy"); // это форматирование раобтает и с живым временем 
            string date2 = date.ToString("HH:mm:ss"); // это форматирование раобтает и с живым временем 
            string name_of_kassir = "КАССИР";
            string number_of_kassir = "1";
            string text_of_sail = "ПРОДАЖА";
            string number_of_sail_today = "0204";
            string total_text = "ИТОГ";
            string total_summa = "2830.00";
            string money_type = "Наличка";
            string summa_of_gived_money = "3000.00";
            string text_of_money_back = "Сдача";
            string difference_in_money = "170";
            string text_of_signature = "Подпись";


            /**************************************************************/
            Console.WriteLine($"              {name_of_paper}");
            for (int ii = 0; ii < 40; ii++) { Console.Write("-"); }
            Console.WriteLine("");
            Console.WriteLine($" {name_of_goods}");
            Console.WriteLine($" {multiplicator}");
            for (int ii = 0; ii < 40; ii++) { Console.Write("="); }
            Console.WriteLine();
            Console.WriteLine($" {NM_name} {NM_number} {INN_name} {INN_number}     #{SHARP_number}");
            Console.WriteLine($" {date1} {date2}           {name_of_kassir} {number_of_kassir}"); // вывожу этот вариант чтобы контролировать количество символов в строке 
            //Console.WriteLine($" {DateTime.Now}           {name_of_kassir} {number_of_kassir}"); // не вывожу этот вариант тк количество его символов наверное зависит от системных настроек
            Console.WriteLine($" {text_of_sail}                          №{number_of_sail_today}");
            Console.WriteLine($" {total_text}                          ={total_summa}");
            Console.WriteLine($" {money_type}                        {summa_of_gived_money}");
            Console.WriteLine($" {text_of_money_back}                              {difference_in_money}");
            Console.WriteLine($" {text_of_signature}...............................");
            Console.ReadLine();


        }
    }
}