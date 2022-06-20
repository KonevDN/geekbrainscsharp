using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace TaskManager
{
    public static class Менеджер
    {
        private static UInt32 НомерПроцессаВОчереди;
        private static UInt32 IDномерПроцесса;

        static Менеджер()
        {
            // пусто
        }

        public static void ВывестиВсеПроцессыНаЭкран()
        {
            НомерПроцессаВОчереди = 0;
            Process[] МассивВсехЛокальныхПроцессов = Process.GetProcesses();
            foreach (var Процесс in МассивВсехЛокальныхПроцессов)
            {
                Console.WriteLine(
                    $"Процесс: {++НомерПроцессаВОчереди}, ID номер: {Процесс.Id}, Имя: {Процесс.ProcessName}");
            }
        }

        public static void СпроситьЮзераКакойПроцессУбить()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.Write("Какой процесс желаете уничтожить?, укажите его номер ID: ");

            IDномерПроцесса = Convert.ToUInt32(Console.ReadLine());
            if (IDномерПроцесса is UInt32)
            {
                Console.WriteLine($" вы ввели номер: {IDномерПроцесса} ");
            }

        }

        public static void УбитьУказанныйПроцесс()
        {
            НомерПроцессаВОчереди = 0;
            Process[] МассивВсехЛокальныхПроцессов = Process.GetProcesses();
            foreach (var Процесс in МассивВсехЛокальныхПроцессов)
            {
                if (IDномерПроцесса == Процесс.Id) Процесс.Kill();
            }
        }

        public static void ПроверитьЧтоПроцессУбитУспешно()
        {
            Process[] МассивВсехЛокальныхПроцессов = Process.GetProcesses();

            bool ПроцессНеБылУбит = true;
            do
            {
                foreach (var Процесс in МассивВсехЛокальныхПроцессов)
                {
                    if (IDномерПроцесса == Процесс.Id)
                    {
                        Console.WriteLine("Процесс пока не был убит до конца, ждем...");
                        ПроцессНеБылУбит = true;
                    }
                    else ПроцессНеБылУбит = false;
                }
            } while (ПроцессНеБылУбит);
            Console.WriteLine("Процесс был убит успешно.");
            Console.WriteLine("Нажмите любую клавишу, чтобы начать сначала.");
            Console.ReadKey();
        }
    }
}  
        