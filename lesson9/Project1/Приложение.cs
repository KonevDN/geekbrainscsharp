using System;

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
            String ЗаголовокОкна = $"{FileManager.FileDescription} {FileManager.FileVersion} by {FileManager.CompanyName}" ;
            Console.Title = ЗаголовокОкна; 
#endif

            //const Int16 WINDOW_HEIGHT = 30; // 30 строк в окне
            //const Int16 WINDOW_WIDTH = 120; // 120 символов в строке 


            //Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            //Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            //Fuck.say();
            //ГрафикаОкна.Fuck.say();
            //НарисоватьЗону(ТочкаСлева:0, ТочкаСверху:0, ШиринаЗоны:WINDOW_WIDTH, ВысотаЗоны:WINDOW_HEIGHT);



            
            Окно.Позиция.ЦентрироватьОкно(ЗаголовокОкна);
            Окно.Графика.НарисоватьЗону();
            Console.ReadKey();
            


        }

        


        ///// <summary>Метод НарисоватьЗону - нарисует прямоугольную зону  внутри консольного окна</summary>
        ///// <param name="ТочкаСлева"></param>
        ///// <param name="ТочкаСверху"></param>
        ///// <param name="ШиринаЗоны"></param>
        ///// <param name="ВысотаЗоны"></param>
        //static void НарисоватьЗону(int ТочкаСлева = 0, int ТочкаСверху = 0, Int32 ШиринаЗоны = 10, int ВысотаЗоны = 20)
        //{
        //    УстановитьКурсорВПозицию();
        //    ВывестиЛевыйУголок();
        //    ЗаполнитьСтроку();
        //    ВывестиПравыйУголок();
            

        //    /// <summary>УстановитьКурсорВначало</summary>
        //    void УстановитьКурсорВПозицию()
        //    {
        //        Console.SetCursorPosition(ТочкаСлева, ТочкаСверху);
        //    }
        //    /// <summary>ВЫВЕСТИs the ЛЕВЫЙ УГОЛОК.</summary>
        //    void ВывестиЛевыйУголок(String ЛевыйУголок = "╔")
        //    {
        //        Console.Write(ЛевыйУголок);
        //    }
        //    /// <summary>ВЫВЕСТИs the ПРАВЫЙ УГОЛОК.</summary>
        //    void ВывестиПравыйУголок(String ПравыйУголок = "╗")
        //    {
        //        Console.Write(ПравыйУголок);
        //    }
        //    /// <summary>ЗАПОЛНИТЬs the СТРОКУ.</summary>
        //    void ЗаполнитьСтроку()
        //    {
        //        const Int16 ДваУголка = 2;
        //        for (int Позиция = 0; Позиция < ШиринаЗоны - ДваУголка; Позиция++)
        //        {
        //            Console.Write("═");
        //        }
        //    }

        //}


    }
}
