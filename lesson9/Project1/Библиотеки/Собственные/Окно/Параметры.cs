using System;

namespace Окно
{
    public static class Параметры
    {
        private static UInt16 ТочкаСлева = 0;
        private static UInt16 ТочкаСверху = 0;
        private static UInt16 ШиринаЗоны = 120;
        private static UInt16 ВысотаЗоны = 30;
        private static UInt16 ШиринаОкна = ШиринаЗоны;
        private static UInt16 ВысотаОкна = ВысотаЗоны;

        public static UInt16 ВзятьЖелаемуюШиринуЗоны
        {
            get { return ШиринаЗоны; }
        }

        public static UInt16 ВзятьЖелаемуюВысотуЗоны
        {
            get { return ВысотаЗоны; }
        }

        public static UInt16 ВзятьЖелаемуюШиринуОкна
        {
            get { return ШиринаОкна; }
        }

        public static UInt16 ВзятьЖелаемуюВысотуОкна
        {
            get { return ВысотаОкна; }
        }

        public static UInt16 ВзятьЖелаемуюНачальнуюТочкуСлева
        {
            get { return ТочкаСлева; }
        }

        public static UInt16 ВзятьЖелаемуюНачальнуюТочкуСверху
        {
            get { return ТочкаСверху; }
        }

    }
}