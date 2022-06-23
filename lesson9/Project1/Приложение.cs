using System;
using БиблиотекаОкно;


namespace FireManagerConsole
{
    internal class Приложение
    {

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

            ГрафикаОкна.УстановитьРазмерОкна(ПараметрыОкна.ВзятьНастроеннуюШиринуОкна, ПараметрыОкна.ВзятьНастроеннуюВысотуОкна); 
            ПозицияОкна.ЦентрироватьОкно(ЗаголовокОкна);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыОкна.ВзятьЖелаемуюНачальнуюТочкуСлева, ПараметрыОкна.ВзятьЖелаемуюНачальнуюТочкуСверху, ПараметрыОкна.ВзятьЖелаемуюШиринуЗоны1, ПараметрыОкна.ВзятьЖелаемуюВысотуЗоны1);
            Console.ReadKey();

            Int32 ч = ПараметрыЗоны.ВысотаЗоны2;
            Int32 ч2 = ПараметрыЗоны.ШиринаЗоны2;
        }

        



    }
}
