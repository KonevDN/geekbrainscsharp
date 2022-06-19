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

        public static UInt16 СчитатьШиринуЗоны
        {
            get { return ШиринаЗоны; }
        }

        public static UInt16 ИспользоватьШиринуОкна
        {
            get { return ШиринаОкна; }
        }

        public static UInt16 ИспользоватьВысотуОкна
        {
            get { return ВысотаОкна; }
        }
    }
}