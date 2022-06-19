using System;
using System.Runtime.InteropServices;

namespace Окно
{
    public static class Позиция
    {
        private static int x;

        [StructLayout(LayoutKind.Sequential)]
        public struct Прямоугольник
        {
            public int ЛеваяТочка;
            public int ВерхняяТочка;
            public int ПраваяТочка;
            public int НижняяТочка;
        }


        /* Возвращает хэндл (указатель) нашего окна IntPtr hWnd*/
        [DllImport("User32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /* Устанавливаем окно по его указателю в нужное место */
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        /* Получаем крайние точки окна */
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Прямоугольник lpПрямоугольник);

        public static void Центрировать(String ЗаголовокОкна)
        {
            Console.Title = ЗаголовокОкна;

            /* Получить указатель на окно приложения */
            var УказательНаОкно = Позиция.FindWindow(null, Console.Title);
            var ПрямоугольникОкна = new Позиция.Прямоугольник();

            /* Получить  размеры окна приложения */
            Позиция.GetWindowRect(УказательНаОкно, out ПрямоугольникОкна);
            var ШиринаОкна = ПрямоугольникОкна.ПраваяТочка - ПрямоугольникОкна.ЛеваяТочка;
            var ВысотаОкна = ПрямоугольникОкна.НижняяТочка - ПрямоугольникОкна.ВерхняяТочка;

            /* Флаг - означает что при установке позиции окна размер не менялся */
            var SWP_NOSIZE = 0x1;

            /* Окно выше остальных */
            var HWND_TOPMOST = -1;

            var Width = 1800;
            var Height = Width / 2;
            /* Установка окна в нужное место */
            Позиция.SetWindowPos(УказательНаОкно, HWND_TOPMOST, Width / 2 - ШиринаОкна / 2, Height / 2 - ВысотаОкна / 2, 0, 0, SWP_NOSIZE);
        }
    }
}
