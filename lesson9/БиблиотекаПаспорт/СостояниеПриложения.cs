using System;
using System.IO;

namespace БиблиотекаПриложение
{

    public static class СостояниеПриложения 
    {
        private static Int32 _ЗапрошеннаяСтраница;
        public static Int32 ЗапрошеннаяСтраница
        {
            get { return _ЗапрошеннаяСтраница; }
            set { _ЗапрошеннаяСтраница = value; }
        }
        

        private static String _ДиректорияВведеннаяПользователем;
        public static String ДиректорияВведеннаяПользователем
        {
            get { return _ДиректорияВведеннаяПользователем; }
            set { _ДиректорияВведеннаяПользователем = value; }
        }


        static СостояниеПриложения() { }
    }

}