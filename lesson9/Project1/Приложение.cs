using System;
using БиблиотекаОкно;


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

            
            ГрафикаОкна.УстановитьРазмерОкна(ПараметрыОкна.ВзятьЖелаемуюШиринуОкна, ПараметрыОкна.ВзятьЖелаемуюВысотуОкна); 
            ПозицияОкна.ЦентрироватьОкно(ЗаголовокОкна);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыОкна.ВзятьЖелаемуюНачальнуюТочкуСлева, ПараметрыОкна.ВзятьЖелаемуюНачальнуюТочкуСверху, ПараметрыОкна.ВзятьЖелаемуюШиринуЗоны, ПараметрыОкна.ВзятьЖелаемуюВысотуЗоны);
            Console.ReadKey();

            
            

        }

        



    }
}
