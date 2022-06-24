using System;

namespace БиблиотекаОкно
{
    public static class ПараметрыОкна
    {
        public static Int32 ВысотаОкна { get; }
        public static Int32 ШиринаОкна { get; }
        

        static ПараметрыОкна()
        {
            ШиринаОкна = 120;
            ВысотаОкна = 55;
        }

    }

    
}