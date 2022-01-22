using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main()
        {
            Char[] c1 = { 'w', 'o', 'r', 'd' };
            Byte[] b1 = {0x41,0x42,0x43,0x44 };

            String s1 = new String(c1);
            Console.WriteLine(s1);
            //Console.ReadLine();

            String s2;
            s2 = System.Text.Encoding.Default.GetString(b1);
            Console.WriteLine(s2);
            Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            Console.ReadLine();

            s2 =
                @"это 
                    многострочная
                строка и масло масляное но что поделать";
        }
    }
}
