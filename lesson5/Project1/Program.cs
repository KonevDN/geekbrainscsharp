using System;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Рабочая_папка = @"D:\Задача1";
            Directory.CreateDirectory(Рабочая_папка); // Создаем директорию
            string Путь_файла= Path.Combine(Рабочая_папка, "Note.txt");

            Console.WriteLine("Введите свой текст, он будет записан в файл:");

            //string Текст_файла = "Текст_файла Текст_файла Текст_файла Текст_файла Текст_файла";
            string Текст_файла = Console.ReadLine();
            File.WriteAllText(Путь_файла, Текст_файла);
        }

        

    }
}
