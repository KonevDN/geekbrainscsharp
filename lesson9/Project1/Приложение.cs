using System;
using Окно;


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


            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборки
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки


#if DEBUG
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022";
            Console.Title = ЗаголовокОкна;
#else
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
            Console.Title = ЗаголовокОкна; 
#endif

            
            Окно.Графика.УстановитьРазмерОкна(Окно.Параметры.ВзятьЖелаемуюШиринуОкна, Окно.Параметры.ВзятьЖелаемуюВысотуОкна); 
            Окно.Позиция.ЦентрироватьОкно(ЗаголовокОкна);
            Окно.Графика.ОтрисоватьЗонуОкна(Окно.Параметры.ВзятьЖелаемуюНачальнуюТочкуСлева, Окно.Параметры.ВзятьЖелаемуюНачальнуюТочкуСверху, Окно.Параметры.ВзятьЖелаемуюШиринуЗоны, Окно.Параметры.ВзятьЖелаемуюВысотуЗоны);
            Console.ReadKey();
            


        }

        



    }
}
