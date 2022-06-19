using System;

namespace FireManagerConsole
{
    /// <summary>
    /// 
    /// </summary>
    internal class Приложение
    {

        /// <summary>
        ///   <br />
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборке (библиотеке)
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки


#if DEBUG
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022";
            Console.Title = ЗаголовокОкна;
#else
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
            Console.Title = ЗаголовокОкна; 
#endif


            Окно.Графика.УстановитьРазмерОкна(Окно.Параметры.ИспользоватьШиринуОкна, Окно.Параметры.ИспользоватьВысотуОкна); 
            Окно.Позиция.ЦентрироватьОкно(ЗаголовокОкна);
            Окно.Графика.НарисоватьЗону();
            Console.ReadKey();
            


        }

        



    }
}
