using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 x2 = 0;
            String name = null;
            Console.WriteLine("Напишите как вас зовут:");
            name = Console.ReadLine();
            Console.WriteLine($" Привет {name}, сегодня {DateTime.Now} ");
            Console.ReadLine();
        }
    }
}
