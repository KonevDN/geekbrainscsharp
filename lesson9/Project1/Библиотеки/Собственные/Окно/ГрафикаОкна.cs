﻿using System;

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
            УстановитьКурсорВПозицию();
            ВывестиЛевыйУголок();
            ЗаполнитьСтроку();
            ВывестиПравыйУголок();

            //Тело зоны
            Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху + 1);
            for (int НомерСтрокиВнутриЗоны = 0; НомерСтрокиВнутриЗоны < ЖелаемаяВысотаЗоны - 2; НомерСтрокиВнутриЗоны++)
            {
                Console.Write("║");
                for (int НомерСимволаВнутриСтроки = ЖелаемаяНачальнаяТочкаСлева +1; НомерСимволаВнутриСтроки < ЖелаемаяНачальнаяТочкаСлева + ЖелаемаяШиринаЗоны - 1; НомерСимволаВнутриСтроки++)
                {
                    Console.Write(" ");
                }
                Console.Write("║");
            }


            //подвал
            Console.Write("╚");
            for (int НомерСтрокиВнутриЗоны = 0; НомерСтрокиВнутриЗоны < ЖелаемаяШиринаЗоны - 2; НомерСтрокиВнутриЗоны++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
            Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху);





            /// <summary>УстановитьКурсорВначало</summary>
            void УстановитьКурсорВПозицию()
            {
                Console.SetCursorPosition(ЖелаемаяНачальнаяТочкаСлева, ЖелаемаяНачальнаяТочкаСверху); 
            }

            /// <summary>ВЫВЕСТИs the ЛЕВЫЙ УГОЛОК.</summary>
            void ВывестиЛевыйУголок(String ЛевыйУголок = "╔")
            {
                Console.Write(ЛевыйУголок);
            }

            /// <summary>ВЫВЕСТИs the ПРАВЫЙ УГОЛОК.</summary>
            void ВывестиПравыйУголок(String ПравыйУголок = "╗")
            {
                Console.Write(ПравыйУголок);
            }

            /// <summary>ЗАПОЛНИТЬs the СТРОКУ.</summary>
            void ЗаполнитьСтроку()
            {
                const Int16 ДваУголка = 2;
                for (int Позиция = 0; Позиция < ЖелаемаяШиринаЗоны - ДваУголка; Позиция++)
                {
                    Console.Write("═");
                }
            }

        }


    }
}