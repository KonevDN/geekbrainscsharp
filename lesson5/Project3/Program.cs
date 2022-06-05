// See https://aka.ms/new-console-template for more information
// УРОК5, ЗАДАЧА3 Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

string int1= Console.ReadLine(); // я пробовал Console.Read() но так почему то результат читается неверный 
byte b1= Convert.ToByte(int1);
byte[] b2 = new byte[1]{b1};
//b2[0] = b1;
File.WriteAllBytes("file1.bin", b2);
byte[] b3 = File.ReadAllBytes("file1.bin");
Console.WriteLine(b3[0]);

//Console.WriteLine("Проверка:");
//byte[] b4 = File.ReadAllBytes("file1.bin");
//Console.WriteLine(b4[0]);
