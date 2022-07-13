﻿using System;
using System.IO;
using System.Text;

namespace БиблиотекаОкно
{
    public static class ГрафикаОкна
    {

        static ГрафикаОкна() { }

        public static void УстановитьРазмерОкна(Int32 ШиринаОкна, Int32 ВысотаОкна)
        {
            Console.SetWindowSize(ШиринаОкна, ВысотаОкна);
            Console.SetBufferSize(ШиринаОкна, ВысотаОкна);
        }

        public static void ОтрисоватьЗонуОкна(Int32 ЖелаемаяНачальнаяТочкаСлева, Int32 ЖелаемаяНачальнаяТочкаСверху, Int32 ЖелаемаяШиринаЗоны, Int32 ЖелаемаяВысотаЗоны)
        {
            //Верхняя планка зоны
            УстановитьКурсорВначало();
            ВывестиЛевыйУголокЗоны();
            ВывестиВерхнююГраньЗоны();
            ВывестиПравыйУголокЗоны();
            ВывестиТелоЗоны();
            ВывестиНижнююГраньЗоны();
            

            /// <summary>УстановитьКурсорВначало</summary>
            void УстановитьКурсорВначало()
            {
                Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху); 
            }

            /// <summary>ВЫВЕСТИs the ЛЕВЫЙ УГОЛОК.</summary>
            void ВывестиЛевыйУголокЗоны(String ЛевыйУголок = "╔")
            {
                Console.Write(ЛевыйУголок);
            }

            /// <summary>ВывестиВерхнююГраньЗоны.</summary>
            void ВывестиВерхнююГраньЗоны()
            {
                const Int16 ДваУголка = 2;
                for (int Позиция = 0; Позиция < ЖелаемаяШиринаЗоны - ДваУголка; Позиция++)
                {
                    Console.Write("═");
                }
            }

            /// <summary>ВЫВЕСТИs the ПРАВЫЙ УГОЛОК.</summary>
            void ВывестиПравыйУголокЗоны(String ПравыйУголок = "╗")
            {
                Console.Write(ПравыйУголок);
            }

            void ВывестиТелоЗоны()
            {
                //Тело зоны
                Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху + 1);
                for (int НомерСтрокиВнутриЗоны = 0; НомерСтрокиВнутриЗоны < ЖелаемаяВысотаЗоны - 2; НомерСтрокиВнутриЗоны++)
                {
                    Console.Write("║");
                    for (int НомерСимволаВнутриСтроки = ЖелаемаяНачальнаяТочкаСлева + 1; НомерСимволаВнутриСтроки < ЖелаемаяНачальнаяТочкаСлева + ЖелаемаяШиринаЗоны - 1; НомерСимволаВнутриСтроки++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("║");
                }
            }

            void ВывестиНижнююГраньЗоны()
            {
                //подвал
                Console.Write("╚");
                for (int НомерСтрокиВнутриЗоны = 0; НомерСтрокиВнутриЗоны < ЖелаемаяШиринаЗоны - 2; НомерСтрокиВнутриЗоны++)
                {
                    Console.Write("═");
                }
                Console.Write("╝");
                Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху);
            }

        }

        public static void ЗаполнитьЗонуНомер3(String ДиректорияЗапуска)
        {
            ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны3, ПараметрыЗоны.ТочкаСверхуДляЗоны3, ПараметрыЗоны.ШиринаЗоныНомер3, ПараметрыЗоны.ВысотаЗоны3);
            Console.SetCursorPosition(ПараметрыЗоны.ТочкаСлеваДляЗоны3 + 1, ПараметрыЗоны.ТочкаСверхуДляЗоны3 + ПараметрыЗоны.ВысотаЗоны3 / 2);
            Console.Write(ДиректорияЗапуска + " ► ");
        }

        public static void DrawTree(DirectoryInfo ТекущаяДиректория, Int32 ЗапрошеннаяСтраница) 
        {
            StringBuilder ДеревоКаталогов = new StringBuilder();
            GetTree(ДеревоКаталогов, ТекущаяДиректория, "", true);
            //DrawWindow(0, 0, WINDOW_WIDTH, 18);
            //ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны1, ПараметрыЗоны.ТочкаСверхуДляЗоны1, ПараметрыЗоны.ШиринаЗоны1, ПараметрыЗоны.ВысотаЗоны1);

            (Int32 currentLeft, Int32 currentTop) = ВзятьТекущиеКоординатыКурсора();
            if (currentTop > 3) currentTop = 3;
            if (currentTop == 0) currentTop = 3;
            Int32 КоличествоСтрокВЗонеВывода = 30;

            string[] ВсеСтрокиИзДерева = ДеревоКаталогов.ToString().Split('\n');
            ПараметрыОкна.СколькоСтраницТребуетсяДляДерева = (ВсеСтрокиИзДерева.Length + КоличествоСтрокВЗонеВывода - 1) / КоличествоСтрокВЗонеВывода;

            // проверка и защита от ввода слишком далекой страницы
            if (ЗапрошеннаяСтраница > ПараметрыОкна.СколькоСтраницТребуетсяДляДерева) ЗапрошеннаяСтраница = ПараметрыОкна.СколькоСтраницТребуетсяДляДерева;

            for (Int32 НомерЦикла = (ЗапрошеннаяСтраница - 1) * КоличествоСтрокВЗонеВывода, СчетчикОтступаПоВысоте = 0; НомерЦикла < ЗапрошеннаяСтраница * КоличествоСтрокВЗонеВывода; НомерЦикла++, СчетчикОтступаПоВысоте++)
            {

                if (ВсеСтрокиИзДерева.Length - 1 > НомерЦикла)
                {
                    Console.SetCursorPosition(currentLeft + 1, currentTop + 0 + СчетчикОтступаПоВысоте);
                    Console.WriteLine(ВсеСтрокиИзДерева[НомерЦикла]);
                }

                if (НомерЦикла == КоличествоСтрокВЗонеВывода - 1)
                {
                    Console.SetCursorPosition(currentLeft + 5, currentTop + 2 + СчетчикОтступаПоВысоте);
                    Console.WriteLine("Конец страницы");
                }
            }

            (Int32 Слева, Int32 Справа) ВзятьТекущиеКоординатыКурсора()
            {
                return (Console.CursorLeft, Console.CursorTop);
            }

        }



        //// Отрисуем footer
        //string footer = $"╡ {ЗапрошеннаяСтраница} of {СколькоСтраницТребуетсяДляДерева} ╞";
        //Console.SetCursorPosition(WINDOW_WIDTH / 2 - footer.Length / 2, 17); 
        //Console.WriteLine(footer);

        public static void GetTree(StringBuilder ДеревоКаталогов, DirectoryInfo ТекущаяДиректория, string Отступ, bool ЭтоПоследняяДиректория)
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
    }
}