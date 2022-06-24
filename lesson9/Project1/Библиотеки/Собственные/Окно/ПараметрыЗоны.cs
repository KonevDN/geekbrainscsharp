using System;

namespace БиблиотекаОкно
{
    public static class ПараметрыЗоны
    {
        public static Int32 ВысотаЗоны1 { get; }
        public static Int32 ШиринаЗоны1 { get; }
        public static Int32 ВысотаЗоны2 { get; }
        public static Int32 ШиринаЗоны2 { get; }
        public static Int32 ТочкаСлеваДляЗоны1 { get; }
        public static Int32 ТочкаСверхуДляЗоны1 { get; }




        static ПараметрыЗоны()
        {
            ВысотаЗоны1 = 20;
            ШиринаЗоны1 = 120;

            ВысотаЗоны2 = ВысотаЗоны1*2;
            ШиринаЗоны2 = 120;

            ТочкаСверхуДляЗоны1 = 0;
            ТочкаСлеваДляЗоны1 = 0;
        }
    }
}