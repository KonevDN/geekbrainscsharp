﻿using System;
using System.IO;

using БиблиотекаОкно;


namespace FireManagerConsole
{
    internal class Приложение
    {
        private static String ДиректорияЗапуска = Directory.GetCurrentDirectory();

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
                
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            ГрафикаОкна.УстановитьРазмерОкна(ПараметрыОкна.ШиринаОкна, ПараметрыОкна.ВысотаОкна); 
            ПозицияОкна.ЦентрироватьОкно(ЗаголовокОкна);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны1, ПараметрыЗоны.ТочкаСверхуДляЗоны1, ПараметрыЗоны.ШиринаЗоны1, ПараметрыЗоны.ВысотаЗоны1);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны2, ПараметрыЗоны.ТочкаСверхуДляЗоны2, ПараметрыЗоны.ШиринаЗоны2, ПараметрыЗоны.ВысотаЗоны2);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны3, ПараметрыЗоны.ТочкаСверхуДляЗоны3, ПараметрыЗоны.ШиринаЗоны3, ПараметрыЗоны.ВысотаЗоны3);
            ЗаполнитьЗонуОкна3();
            

            

            Console.ReadLine();

        }

        static void ЗаполнитьЗонуОкна3()
        {
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны3, ПараметрыЗоны.ТочкаСверхуДляЗоны3, ПараметрыЗоны.ШиринаЗоны3, ПараметрыЗоны.ВысотаЗоны3);
            Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны3+1, ПараметрыЗоны.ТочкаСверхуДляЗоны3+ПараметрыЗоны.ВысотаЗоны3/2);
            Console.Write(Directory.GetCurrentDirectory());
        }

        static void ОбработатьВведеннуюКоманду(Int32 ДлинаСтроки)
        {

        }





    }
}
