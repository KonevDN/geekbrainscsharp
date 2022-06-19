using System;

namespace Окно
{
    public static class Графика
    {
        //public static int ШиринаЗоны { get; private set; }
        //public static int ВысотаЗоны { get; private set; }

        /// <summary>Метод НарисоватьЗону - нарисует прямоугольную зону  внутри консольного окна</summary>
        /// <param name="ТочкаСлева"></param>
        /// <param name="ТочкаСверху"></param>
        /// <param name="ШиринаЗоны"></param>
        /// <param name="ВысотаЗоны"></param>
        ///
        internal struct ПрямоугольникЗоны
        {
            internal static UInt16 ТочкаСлева = 0;
            internal const UInt16 ТочкаСверху = 0;
            internal const UInt16 ШиринаЗоны = 120;
            internal const UInt16 ВысотаЗоны = 30;
        }

        static Графика()
        {

            Console.SetWindowSize(ПрямоугольникЗоны.ШиринаЗоны, ПрямоугольникЗоны.ВысотаЗоны);
            Console.SetBufferSize(ПрямоугольникЗоны.ШиринаЗоны, ПрямоугольникЗоны.ВысотаЗоны);
        }


        public static void НарисоватьЗону()
        {
            УстановитьКурсорВПозицию();
            ВывестиЛевыйУголок();
            ЗаполнитьСтроку();
            ВывестиПравыйУголок();


            /// <summary>УстановитьКурсорВначало</summary>
            void УстановитьКурсорВПозицию()
            {
                Console.SetCursorPosition(ПрямоугольникЗоны.ТочкаСлева, ПрямоугольникЗоны.ТочкаСверху); 
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
                for (int Позиция = 0; Позиция < ПрямоугольникЗоны.ШиринаЗоны - ДваУголка; Позиция++)
                {
                    Console.Write("═");
                }
            }

        }


    }
}