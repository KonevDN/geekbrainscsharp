using System;
using System.Globalization;
using System.IO;
using БиблиотекаОкно;
using БиблиотекаПриложение;

namespace БиблиотекаОперации
{
    public static class ОбработкаКомандПользователя
    {
        public static void РазобратьВведеннуюКоманду(String ВведеннаяКоманда)
        {
            String[] ПараметрыВведеннойКоманды = ВведеннаяКоманда.ToLower().Split(' ');
            if (ПараметрыВведеннойКоманды.Length > 0)
            {
                switch (ПараметрыВведеннойКоманды[0])
                {
                    case "cd":
                        if (ПараметрыВведеннойКоманды.Length > 1)
                        {
                            if (Directory.Exists(ПараметрыВведеннойКоманды[1]))
                            {
                                ПаспортПриложения.ДиректорияВведеннаяПользователем = ПараметрыВведеннойКоманды[1];
                                ГрафикаОкна.ЗаполнитьЗонуНомер3(ПаспортПриложения.ДиректорияВведеннаяПользователем);
                            }
                        }
                        break;

                    case "ls":
                        if (ПараметрыВведеннойКоманды.Length > 1 && Directory.Exists(ПараметрыВведеннойКоманды[1]))
                        {
                            if (ПараметрыВведеннойКоманды.Length > 3 && ПараметрыВведеннойКоманды[2] == "-p" && Int32.TryParse(ПараметрыВведеннойКоманды[3], out Int32 n))
                            {
                                ГрафикаОкна.DrawTree(new DirectoryInfo(ПараметрыВведеннойКоманды[1]), n);
                                СостояниеПриложения.ЗапрошеннаяСтраница = n;
                            }
                            else
                            {
                                string s1 = ПараметрыВведеннойКоманды[1];
                                ГрафикаОкна.ОтрисоватьЗонуОкна(ПараметрыЗоны.ТочкаСлеваДляЗоны1, ПараметрыЗоны.ТочкаСверхуДляЗоны1, ПараметрыЗоны.ШиринаЗоны1, ПараметрыЗоны.ВысотаЗоны1);
                                ГрафикаОкна.DrawTree(new DirectoryInfo(ПараметрыВведеннойКоманды[1]), 1);
                            }

                        }
                        break;

                    case "dfl":
                        if (ПараметрыВведеннойКоманды.Length == 2 && File.Exists(ПараметрыВведеннойКоманды[1]))
                        {
                            File.Delete(ПараметрыВведеннойКоманды[1]);

                        }
                        break;

                    case "dfr":
                        if (ПараметрыВведеннойКоманды.Length == 2 && Directory.Exists(ПараметрыВведеннойКоманды[1]))
                        {
                            //Directory.Delete(ПараметрыВведеннойКоманды[1]);
                            String[] Вхождение = Directory.GetFileSystemEntries(ПараметрыВведеннойКоманды[1], "*", SearchOption.AllDirectories);
                            for (Int32 index = 0; index < Вхождение.Length; index++)
                            {
                                if (File.Exists(Вхождение[index]))
                                {
                                    File.Delete(Вхождение[index]); 
                                }
                            }

                            Вхождение = Directory.GetFileSystemEntries(ПараметрыВведеннойКоманды[1], "*", SearchOption.AllDirectories);
                            for (Int32 index = 0; index < Вхождение.Length; index++)
                            {
                                if (Directory.Exists(Вхождение[index]))
                                {
                                    Directory.Delete(Вхождение[index], true);
                                }
                            }

                            if (Directory.Exists(ПараметрыВведеннойКоманды[1]))
                            {
                                Directory.Delete(ПараметрыВведеннойКоманды[1]);
                            }


                        }
                        break;

                        //Console.WriteLine(File.Exists(@"D:\Projects\geekbrainscsharp\lesson9\Project2\bin\x64\Debug\FireManagerConsole.exe"));
                        //File.Delete(@"D:\del\PTC.Mathcad.V15.M050.Eng\setup.exe");
                }
            }
        }
    }
}

