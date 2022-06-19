using System;
using System.Runtime.InteropServices;
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


            System.Reflection.Assembly Сборка = System.Reflection.Assembly.GetExecutingAssembly(); // Получим информацию по текущей сборке (библиотеке)
            System.Diagnostics.FileVersionInfo FileManager = System.Diagnostics.FileVersionInfo.GetVersionInfo(Сборка.Location); // Получим информацию по текущей версии сборки


#if DEBUG
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} {"[DEBUG]"} by {FileManager.CompanyName} © 06/2022";
            Console.Title = ЗаголовокОкна;
#else
            Console.Title = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
#endif

            const Int16 WINDOW_HEIGHT = 30; // 30 строк в окне
            const Int16 WINDOW_WIDTH = 120; // 120 символов в строке 


            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            //Fuck.say();
            //ГрафикаОкна.Fuck.say();
            НарисоватьЗону(ТочкаСлева:0, ТочкаСверху:0, ШиринаЗоны:WINDOW_WIDTH, ВысотаЗоны:WINDOW_HEIGHT);



            
            Позиция.Центрировать(ЗаголовокОкна);
            
            Console.Title = ЗаголовокОкна;

            ///* Получить указатель на окно приложения */
            //var УказательНаОкно = Позиция.FindWindow(null, Console.Title);  
            //var ПрямоугольникОкна = new Позиция.Прямоугольник(); 

            ///* Получить  размеры окна приложения */
            //Позиция.GetWindowRect(УказательНаОкно, out ПрямоугольникОкна);
            //var ШиринаОкна = ПрямоугольникОкна.ПраваяТочка - ПрямоугольникОкна.ЛеваяТочка;
            //var ВысотаОкна = ПрямоугольникОкна.НижняяТочка - ПрямоугольникОкна.ВерхняяТочка;

            ///* Флаг - означает что при установке позиции окна размер не менялся */
            //var SWP_NOSIZE = 0x1;

            ///* Окно выше остальных */
            //var HWND_TOPMOST = -1;

            //var Width = 1800;
            //var Height = Width/2;
            ///* Установка окна в нужное место */
            //Позиция.SetWindowPos(УказательНаОкно, HWND_TOPMOST, Width / 2 - ШиринаОкна / 2, Height / 2 - ВысотаОкна / 2, 0, 0, SWP_NOSIZE);

            Console.ReadKey();



        }

        //ГрафикаОкна.НарисоватьЗону()


        /// <summary>Метод НарисоватьЗону - нарисует прямоугольную зону  внутри консольного окна</summary>
        /// <param name="ТочкаСлева"></param>
        /// <param name="ТочкаСверху"></param>
        /// <param name="ШиринаЗоны"></param>
        /// <param name="ВысотаЗоны"></param>
        static void НарисоватьЗону(int ТочкаСлева = 0, int ТочкаСверху = 0, Int32 ШиринаЗоны = 10, int ВысотаЗоны = 20)
        {
            УстановитьКурсорВПозицию();
            ВывестиЛевыйУголок();
            ЗаполнитьСтроку();
            ВывестиПравыйУголок();
            

            /// <summary>УстановитьКурсорВначало</summary>
            void УстановитьКурсорВПозицию()
            {
                Console.SetCursorPosition(ТочкаСлева, ТочкаСверху);
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
                for (int Позиция = 0; Позиция < ШиринаЗоны - ДваУголка; Позиция++)
                {
                    Console.Write("═");
                }
            }

        }


    }
}
