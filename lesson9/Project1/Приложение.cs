using System;
using System.IO;
using System.Text;
using БиблиотекаОкно;
using БиблиотекаОперации;


namespace FireManagerConsole
{
    internal class Приложение
    {
        public static String ДиректорияЗапуска = Directory.GetCurrentDirectory();

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


            
            

            while (true)
            {
                ГрафикаОкна.ЗаполнитьЗонуОкна3(ДиректорияЗапуска);
                ОбработатьВводПользователя(ПараметрыЗоны.ШиринаЗоны3);
            }
            


            // урок 9 1:44



        }


        static void GetTree(StringBuilder tree, DirectoryInfo dir, string indent, bool lastDirectory)
        {
            tree.Append(indent);
            if (lastDirectory)
            {
                tree.Append("└─");
                indent += "  ";
            }
            else
            {
                tree.Append("├─");
                indent += "│ ";
            }

            tree.Append($"{dir.Name}\n");


            FileInfo[] subFiles = dir.GetFiles();
            for (int i = 0; i < subFiles.Length; i++)
            {
                if (i == subFiles.Length - 1)
                {
                    tree.Append($"{indent}└─{subFiles[i].Name}\n");
                }
                else
                {
                    tree.Append($"{indent}├─{subFiles[i].Name}\n");
                }
            }


            DirectoryInfo[] subDirects = dir.GetDirectories();
            for (int i = 0; i < subDirects.Length; i++)
                GetTree(tree, subDirects[i], indent, i == subDirects.Length - 1);
        }

        static void ОбработатьВводПользователя(Int32 ДопустимаяДлинаСтроки)
        {
            (Int32 НачальнаяПозицияКурсораСлева, Int32 НачальнаяПозицияКурсораСверху) = ВзятьТекущиеКоординатыКурсора();
            StringBuilder ВведеннаяКоманда = new StringBuilder();
            ConsoleKeyInfo ВведенныйСимвол = new ConsoleKeyInfo();
            char КодВведенногоСимвола;

            do
            {
                ВведенныйСимвол = Console.ReadKey();
                КодВведенногоСимвола = ВведенныйСимвол.KeyChar;
                if (ВведенныйСимвол.Key != ConsoleKey.Enter && ВведенныйСимвол.Key != ConsoleKey.Backspace && ВведенныйСимвол.Key != ConsoleKey.UpArrow) ВведеннаяКоманда.Append(КодВведенногоСимвола);
                
                (Int32 ТекущаяПозицияКурсораСлева, Int32 ТекущаяПозицияКурсораСверху) = ВзятьТекущиеКоординатыКурсора();
                
                if (ТекущаяПозицияКурсораСлева == ДопустимаяДлинаСтроки - 2)
                {
                    Console.SetCursorPosition(ТекущаяПозицияКурсораСлева-1, ТекущаяПозицияКурсораСверху);
                    Console.Write(" ");
                    Console.SetCursorPosition(ТекущаяПозицияКурсораСлева - 1, ТекущаяПозицияКурсораСверху);
                }

                if (ВведенныйСимвол.Key == ConsoleKey.Backspace)
                {
                    if (ВведеннаяКоманда.Length > 0)
                    {
                        ВведеннаяКоманда.Remove(ВведеннаяКоманда.Length - 1, 1);
                    }

                    if (ТекущаяПозицияКурсораСлева >= НачальнаяПозицияКурсораСлева)
                    {
                        Console.SetCursorPosition(ТекущаяПозицияКурсораСлева, ТекущаяПозицияКурсораСверху);
                        Console.Write(" ");
                        Console.SetCursorPosition(ТекущаяПозицияКурсораСлева, ТекущаяПозицияКурсораСверху);
                    }
                    else
                    {
                        ВведеннаяКоманда.Clear();
                        Console.SetCursorPosition(НачальнаяПозицияКурсораСлева, НачальнаяПозицияКурсораСверху);
                    }


                }
            } 
            while (ВведенныйСимвол.Key != ConsoleKey.Enter);

            РазобратьВведеннуюКоманду(ВведеннаяКоманда.ToString()); 
        }
        static (Int32 Слева, Int32 Справа) ВзятьТекущиеКоординатыКурсора()
        {
            return (Console.CursorLeft, Console.CursorTop);
        }
        private static void РазобратьВведеннуюКоманду(String ВведеннаяКоманда)
        {
            String[] ПараметрыВведеннойКоманды = ВведеннаяКоманда.ToLower().Split(' ');
            if (ПараметрыВведеннойКоманды.Length > 0) 
            {
                switch (ПараметрыВведеннойКоманды[0])
                {
                    case "cd":
                        if (ПараметрыВведеннойКоманды.Length > 1)
                        {
                            if (Directory.Exists(ПараметрыВведеннойКоманды[1]))
                            {
                                ДиректорияЗапуска = ПараметрыВведеннойКоманды[1];
                            }
                        }
                        break;
                }
            }
            //ОбработатьВводПользователя(ПараметрыЗоны.ШиринаЗоны3);
        }
        

        

        


    }
}
