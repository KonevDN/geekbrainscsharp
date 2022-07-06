using System;
using System.IO;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Directory, File, FileInfo, DirectoryInfo

            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            ////Console.WriteLine("FullName: {0}", directoryInfo.FullName);
            //Console.WriteLine($"Полный адрес каталога: {directoryInfo.FullName}");
            //Console.WriteLine("Name: {0}", directoryInfo.Name);
            //Console.WriteLine("Parent: {0}", directoryInfo.Parent);
            //Console.WriteLine("Creation: {0}", directoryInfo.CreationTime);
            //Console.WriteLine("Attributes: {0}", directoryInfo.Attributes.ToString());
            //Console.WriteLine("Root: {0}", directoryInfo.Root);

            //Console.WriteLine();

            Console.WriteLine($"Родитель: {directoryInfo.Parent}"); 
            РаспечататьСписокКаталогов(new DirectoryInfo(directoryInfo.FullName), "", true);


            Console.ReadKey(true);
        }

        static void РаспечататьСписокКаталогов(DirectoryInfo НачальнаяДиректория, string ОтступВСтрокеКаталога, bool ЭтоПоследняяДиректория)
        {
            
            Console.Write(ОтступВСтрокеКаталога);
            Console.Write(ЭтоПоследняяДиректория ? "└─" : "├─");
            ОтступВСтрокеКаталога = ОтступВСтрокеКаталога + (ЭтоПоследняяДиректория ? " " : "│ ");
            Console.WriteLine("Каталог: " + НачальнаяДиректория.Name);
            РаспечататьСписокФайлов(НачальнаяДиректория, ОтступВСтрокеКаталога);


            DirectoryInfo[] СписокКаталогов = НачальнаяДиректория.GetDirectories();
            for (int i = 0; i < СписокКаталогов.Length; i++)
            {
                РаспечататьСписокКаталогов(СписокКаталогов[i], ОтступВСтрокеКаталога, i == СписокКаталогов.Length - 1);
            }

        }

        static void РаспечататьСписокФайлов(DirectoryInfo ТекущаяДиректория, String ОтступВСтрокеКаталога)
        {
            String ОтступВСтрокеФайла = ОтступВСтрокеКаталога + "├─";
            FileInfo[] СписокФайлов = ТекущаяДиректория.GetFiles();
            for (Int32 index = 0; index < СписокФайлов.Length; index++)
            {
                Console.Write(ОтступВСтрокеФайла);
                Console.WriteLine("Файл: " + СписокФайлов[index].Name);
            }
        }


    }
}
