// See https://aka.ms/new-console-template for more information
//УРОК5 ЗАДАЧА2 Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

DateTime Сейчас = DateTime.Now; // это рабочий код чтобы получить текущее живое время
string Дата = Сейчас.ToString("dd.MM.yyyy"); // это форматирование раобтает и с живым временем 
string Время = Сейчас.ToString("HH:mm:ss"); // это форматирование раобтает и с живым временем 

Console.WriteLine(Дата);
Console.WriteLine(Время);

String Пробел = " ";
String Папка = @"D:\Урок5,Задача2";
Directory.CreateDirectory(Папка); // Создаем вложенную директорию
string Путь= Path.Combine(Папка, "Файл.txt"); // "D:\ExampleDir\Notes\Note 1.txt"
File.AppendAllText(Путь, Дата+Пробел+Время);
File.AppendAllText(Путь, Environment.NewLine); // вставляем перенос строки