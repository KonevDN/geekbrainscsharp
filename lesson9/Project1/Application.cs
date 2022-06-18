using System;

namespace FileManagerConsole
{
    public class Application
    {
        static void Main(string[] args)
        {
            

            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборке (библиотеке)
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки
            

#if DEBUG 
            Console.Title = $"{FileManager.FileDescription} {FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022" ;
#else
            Console.Title = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
            Console.Title = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
#endif

            
            const Int16 WINDOW_HEIGHT = 30;
            const Int16 WINDOW_WIDTH = 120;

            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            
            Console.ReadKey();



        }


        /// <summary>
        /// Метод НарисоватьЗону - нарисует прямоугольную зону  внутри консольного окна
        /// </summary>
        /// <param name="ТочкаСлева"></param>
        /// <param name="ТочкаСверху"></param>
        /// <param name="ШиринаЗоны"></param>
        /// <param name="ВысотаЗоны"></param>
        static void НарисоватьЗону(int ТочкаСлева= 0, int ТочкаСверху = 0, Int32 ШиринаЗоны = 0, int ВысотаЗоны = 0)
        {

        }


    }
}
