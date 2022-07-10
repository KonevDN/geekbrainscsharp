using System;
using System.IO;
using System.Text;
using БиблиотекаОкно;
using БиблиотекаОперации;
using БиблиотекаПаспорт;


namespace FireManagerConsole
{
    public static class Контроллер
    {
        static void Main(string[] args)
        {
            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборки
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки

#if DEBUG
            String ЗаголовокОкна = $"{FileManager.FileDescription} " + $"{FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022";
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

                
                Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1+2, ПараметрыЗоны.ТочкаСверхуДляЗоны1+2);

                DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory); 
                Console.WriteLine($"Директория: {directoryInfo.FullName}");

                Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1 + 2, ПараметрыЗоны.ТочкаСверхуДляЗоны1 + 3);
                РаспечататьСписокКаталогов(new DirectoryInfo(directoryInfo.FullName), "", true);
                
                ОбработкаСтрокиВвода.ОбработатьВводПользователя(ПараметрыЗоны.ШиринаЗоны3);
                //DrawTree(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory), 1);
            }
            
            // урок 9 1:44
        }


        static void DrawTree(DirectoryInfo ТекущаяДиректория, Int32 ЗапрошеннаяСтраница)
        {
            StringBuilder ДеревоКаталогов = new StringBuilder();
            GetTree(ДеревоКаталогов, ТекущаяДиректория, "", true);
            //DrawWindow(0, 0, WINDOW_WIDTH, 18);
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны1, ПараметрыЗоны.ТочкаСверхуДляЗоны1, ПараметрыЗоны.ШиринаЗоны1, ПараметрыЗоны.ВысотаЗоны1);

            (Int32 currentLeft, Int32 currentTop) = ВзятьТекущиеКоординатыКурсора();
            Int32 КоличествоСтрокВЗонеВывода = 38;

            string[] ВсеСтрокиИзДерева = ДеревоКаталогов.ToString().Split('\n'); 
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

            //// Отрисуем footer
            //string footer = $"╡ {ЗапрошеннаяСтраница} of {НеобходимоеКоличествоСтраницДляВывода} ╞";
            //Console.SetCursorPosition(WINDOW_WIDTH / 2 - footer.Length / 2, 17); 
            //Console.WriteLine(footer);


            (Int32 Слева, Int32 Справа) ВзятьТекущиеКоординатыКурсора()
            {
                return (Console.CursorLeft, Console.CursorTop);
            }

        }



        static void GetTree(StringBuilder ДеревоКаталогов, DirectoryInfo ТекущаяДиректория, string Отступ, bool ЭтоПоследняяДиректория)
        {
            ДеревоКаталогов.Append(Отступ);
            if (ЭтоПоследняяДиректория)
            {
                ДеревоКаталогов.Append("└─");
                Отступ += "  ";
            }
            else
            {
                ДеревоКаталогов.Append("├─");
                Отступ += "│ ";
            }

            ДеревоКаталогов.Append($"{ТекущаяДиректория.Name}\n");


            FileInfo[] subFiles = ТекущаяДиректория.GetFiles();
            for (int i = 0; i < subFiles.Length; i++)
            {
                if (i == subFiles.Length - 1)
                {
                    ДеревоКаталогов.Append($"{Отступ}└─{subFiles[i].Name}\n");
                }
                else
                {
                    ДеревоКаталогов.Append($"{Отступ}├─{subFiles[i].Name}\n");
                }
            }


            DirectoryInfo[] subDirects = ТекущаяДиректория.GetDirectories();
            for (int i = 0; i < subDirects.Length; i++)
                GetTree(ДеревоКаталогов, subDirects[i], Отступ, i == subDirects.Length - 1);
        }


        static void РаспечататьСписокКаталогов(DirectoryInfo НачальнаяДиректория, string ОтступВСтрокеКаталога, bool ЭтоПоследняяДиректория)
        {
            Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1 + 2, ПараметрыЗоны.ТочкаСверхуДляЗоны1 + 2);
            Console.Write(ОтступВСтрокеКаталога);
            Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1 + 2, ПараметрыЗоны.ТочкаСверхуДляЗоны1 + 3);
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
            
            String ОтступВСтрокеФайла = ОтступВСтрокеКаталога + " ├─";
            FileInfo[] СписокФайлов = ТекущаяДиректория.GetFiles();
            for (Int32 index = 0; index < СписокФайлов.Length; index++)
            {
                //Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1 + 4, ПараметрыЗоны.ТочкаСверхуДляЗоны1 + 2);
                Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны1 + 2, ПараметрыЗоны.ТочкаСверхуДляЗоны1 + 4);
                Console.Write(ОтступВСтрокеФайла);
                Console.WriteLine($"Файл: {СписокФайлов[index].Name}    {string.Format("{0:f2}", (double)СписокФайлов[index].Length / 1024)} кБ");
            }
        }



    }
}
