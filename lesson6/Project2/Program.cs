using System;
using System.Diagnostics;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName =
                @"D:\Projects\geekbrainscsharp\lesson6\Project1\bin\Debug\netcoreapp3.1\Project1.exe";
            process.StartInfo.Arguments = "1 2 3";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            process.WaitForExit();
            Console.WriteLine(process.ExitCode);
        }
    }
}
