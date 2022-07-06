using System;
using System.IO;
using System.Text;
using БиблиотекаОкно;
using БиблиотекаОперации;
using БиблиотекаПаспорт;


namespace FireManagerConsole
{
    public static class Обработка
    {
        static void Main(string[] args)
        {
            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборки
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки

#if DEBUG
            String ЗаголовокОкна = $"{FileManager.FileDescription} " + $"" + $"{FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022";
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

            while (true)
            {
                ГрафикаОкна.ЗаполнитьЗонуОкна3(ПаспортПриложения.ДиректорияЗапуска);
                ОбработкаСтрокиВвода.ОбработатьВводПользователя(ПараметрыЗоны.ШиринаЗоны3);
            }
            
            // урок 9 1:44
        }


        static void DrawTree(DirectoryInfo ТекущаяДиректория, int ЗапрошеннаяСтраница)
        {
            StringBuilder Дерево = new StringBuilder();
            GetTree(Дерево, ТекущаяДиректория, "", true);
            //DrawWindow(0, 0, WINDOW_WIDTH, 18);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны1, ПараметрыЗоны.ТочкаСверхуДляЗоны1, ПараметрыЗоны.ШиринаЗоны1, ПараметрыЗоны.ВысотаЗоны1);

            (Int32 currentLeft, Int32 currentTop) = ВзятьТекущиеКоординатыКурсора();
            Int32 КоличествоСтрокВЗонеВывода = 16;

            string[] ВсеСтрокиИзДерева = Дерево.ToString().Split('\n'); 
            Int32 НеобходимоеКоличествоСтраницДляВывода = (ВсеСтрокиИзДерева.Length + КоличествоСтрокВЗонеВывода - 1) / КоличествоСтрокВЗонеВывода;
            if (ЗапрошеннаяСтраница > НеобходимоеКоличествоСтраницДляВывода) ЗапрошеннаяСтраница = НеобходимоеКоличествоСтраницДляВывода;

            for (Int32 i = (ЗапрошеннаяСтраница - 1) * КоличествоСтрокВЗонеВывода, counter = 0; i < ЗапрошеннаяСтраница * КоличествоСтрокВЗонеВывода; i++, counter++)
            {
                if (ВсеСтрокиИзДерева.Length - 1 > i)
                {
                    Console.SetCursorPosition(currentLeft + 1, currentTop + 1 + counter); 
                    Console.WriteLine(ВсеСтрокиИзДерева[i]); 
                }
            }

            // Отрисуем footer
            string footer = $"╡ {ЗапрошеннаяСтраница} of {НеобходимоеКоличествоСтраницДляВывода} ╞";
            Console.SetCursorPosition(WINDOW_WIDTH / 2 - footer.Length / 2, 17); 
            Console.WriteLine(footer);


            (Int32 Слева, Int32 Справа) ВзятьТекущиеКоординатыКурсора()
            {
                return (Console.CursorLeft, Console.CursorTop);
            }

        }



        static void GetTree(StringBuilder Дерево, DirectoryInfo ТекущаяДиректория, string Отступ, bool ЭтоПоследняяДиректория)
        {
            Дерево.Append(Отступ);
            if (ЭтоПоследняяДиректория)
            {
                Дерево.Append("└─");
                Отступ += "  ";
            }
            else
            {
                Дерево.Append("├─");
                Отступ += "│ ";
            }

            Дерево.Append($"{ТекущаяДиректория.Name}\n");


            FileInfo[] subFiles = ТекущаяДиректория.GetFiles();
            for (int i = 0; i < subFiles.Length; i++)
            {
                if (i == subFiles.Length - 1)
                {
                    Дерево.Append($"{Отступ}└─{subFiles[i].Name}\n");
                }
                else
                {
                    Дерево.Append($"{Отступ}├─{subFiles[i].Name}\n");
                }
            }


            DirectoryInfo[] subDirects = ТекущаяДиректория.GetDirectories();
            for (int i = 0; i < subDirects.Length; i++)
                GetTree(Дерево, subDirects[i], Отступ, i == subDirects.Length - 1);
        }



    }
}
