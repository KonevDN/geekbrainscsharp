using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиблиотекаПриложение
{
    public static class ПаспортПриложения
    {
        private static String _ДиректорияЗапуска;
        public static String ДиректорияЗапуска
        {
            get { return _ДиректорияЗапуска; }
            set { _ДиректорияЗапуска = Directory.GetCurrentDirectory(); }
        }


        static ПаспортПриложения()
        {
            _ДиректорияЗапуска = Directory.GetCurrentDirectory().ToString();
            _ДиректорияВведеннаяПользователем = "ЕщеНеБылаВведена";
        }

        private static String _ДиректорияВведеннаяПользователем;
        public static String ДиректорияВведеннаяПользователем
        {
            get { return _ДиректорияВведеннаяПользователем; }
            set { _ДиректорияВведеннаяПользователем = value; }
        }
    }
}
