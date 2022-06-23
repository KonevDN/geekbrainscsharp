using System;

namespace БиблиотекаОкно
{
    public static class ПараметрыЗоны
    {
        private static Int32 ВысотаЗоны1 { get; }
        private static Int32 ШиринаЗоны1 { get; }
        public static Int32 ВысотаЗоны2 { get; }
        public static Int32 ШиринаЗоны2 { get; }

        static ПараметрыЗоны()
        {
            //ВысотаЗоны2 = ВысотаЗоны1 * 4;
            ВысотаЗоны1 = 10;
            ШиринаЗоны1 = 120;

            ВысотаЗоны2 = 11;
            ШиринаЗоны2 = 11;
        }

        

    }
}