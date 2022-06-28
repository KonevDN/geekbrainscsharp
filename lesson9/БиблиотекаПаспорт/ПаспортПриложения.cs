using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиблиотекаПаспорт
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
        }
    }
}
