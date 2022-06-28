using System;
using System.IO;
using System.Text;
using БиблиотекаПаспорт;


namespace БиблиотекаОперации
{
    public static class ОбработкаСтрокиВвода
    {
        public static void ОбработатьВводПользователя(Int32 ДопустимаяДлинаСтроки)
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
                    Console.SetCursorPosition(ТекущаяПозицияКурсораСлева - 1, ТекущаяПозицияКурсораСверху);
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
            ОбработкаКомандПользователя.РазобратьВведеннуюКоманду(ВведеннаяКоманда.ToString());
        }



        static (Int32 Слева, Int32 Справа) ВзятьТекущиеКоординатыКурсора()
        {
            return (Console.CursorLeft, Console.CursorTop);
        }


    }
}