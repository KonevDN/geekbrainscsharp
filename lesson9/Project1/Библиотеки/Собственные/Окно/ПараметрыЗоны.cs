using System;

namespace БиблиотекаОкно
{
    public static class ПараметрыЗоны
    {
        public static Int32 ВысотаЗоны1 { get; }
        public static Int32 ШиринаЗоны1 { get; }
        public static Int32 ВысотаЗоны2 { get; }
        public static Int32 ШиринаЗоны2 { get; }
        public static Int32 ТочкаСлева { get; }
        public static Int32 ТочкаСверху { get; }




        static ПараметрыЗоны()
        {
            ВысотаЗоны1 = 30;
            ШиринаЗоны1 = 120;

            ВысотаЗоны2 = ВысотаЗоны1*2;
            ШиринаЗоны2 = 120;

            ТочкаСверху = 0;
            ТочкаСлева = 0;
        }
    }
}