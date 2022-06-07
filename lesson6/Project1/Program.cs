using System;
using System.Diagnostics;
using System.Net.Mail;
//using static TaskManager.Менеджер;

namespace TaskManager 
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Менеджер.ВывестиВсеПроцессыНаЭкран();
                Менеджер.СпроситьЮзераКакойПроцессУбить();
                Менеджер.УбитьУказанныйПроцесс();
                Менеджер.ПроверитьЧтоПроцессУбитУспешно();
                Console.Clear();
                

            }
        }
    }
}