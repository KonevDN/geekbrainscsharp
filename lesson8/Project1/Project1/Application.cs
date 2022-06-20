using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Application
    {
        static void Main(string[] args)
        {
            
            if(!string.IsNullOrEmpty(Properties.Settings.Default.ПриветствиеПриложения) )
            {
                Console.WriteLine(Properties.Settings.Default.ПриветствиеПриложения);
            }

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Имя))
            {
                Console.Write("Ранее вы ввели свое имя: ");
                Console.WriteLine(Properties.Settings.Default.Имя);
            }
            else
            {
                Console.Write("Введите свое имя пользователя: ");
                Properties.Settings.Default.Имя = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.Write(Environment.NewLine);
            }


            if (!string.IsNullOrEmpty(Properties.Settings.Default.Возраст))
            {
                Console.Write("Ранее вы ввели свой возраст: ");
                Console.WriteLine(Properties.Settings.Default.Возраст);
            }
            else
            {
                Console.Write("Введите свой возраст: ");
                Properties.Settings.Default.Возраст = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.Write(Environment.NewLine);
            }

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Работа))
            {
                Console.Write("Ранее вы сообщили вашу профессию: ");
                Console.WriteLine(Properties.Settings.Default.Работа);
            }
            else
            {
                Console.Write("Введите навание вашей процессии: ");
                Properties.Settings.Default.Работа = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.Write(Environment.NewLine);
            }


            Console.ReadKey();

        }
    }
}
