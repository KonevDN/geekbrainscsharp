using System;

namespace БиблиотекаОкно
{
    public static class ПараметрыОкна
    {
        private static Int32 ТочкаСлева = 0;
        private static Int32 ТочкаСверху = 0;
        private static Int32 ШиринаЗоны1 = 120;
        private static Int32 ВысотаЗоны1 = 10;
        private static Int32 ВысотаЗоны2 = 30;
        private static Int32 ШиринаОкна = ШиринаЗоны1;
        private static Int32 ВысотаОкна = ВысотаЗоны1*5;
        private static Int32 _ширинаБуфера = ШиринаЗоны1;
        private static Int32 _высотаБуфера = ВысотаЗоны1*5;

        public static Int32 ВзятьЖелаемуюШиринуЗоны1
        {
            get { return ШиринаЗоны1; }
        }

        public static Int32 ВзятьЖелаемуюВысотуЗоны1
        {
            get { return ВысотаЗоны1; }
        }

        public static Int32 ВзятьНастроеннуюШиринуОкна
        {
            get { return ШиринаОкна; }
        }

        public static Int32 ВзятьНастроеннуюВысотуОкна
        {
            get { return ВысотаОкна; }
        }

        public static Int32 ВзятьЖелаемуюНачальнуюТочкуСлева
        {
            get { return ТочкаСлева; }
        }

        public static Int32 ВзятьЖелаемуюНачальнуюТочкуСверху
        {
            get { return ТочкаСверху; }
        }

        public static int ШиринаБуфера => _ширинаБуфера;

        public static int ВысотаБуфера => _высотаБуфера;
    }
}