using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MouseClicker
{
    internal class MouseController
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private readonly Random _random = new Random();

        public void PerformRandomClickInArea(Rectangle area)
        {
            if (area.Width <= 0 || area.Height <= 0) return;
            int randomX = _random.Next(area.Left, area.Right);
            int randomY = _random.Next(area.Top, area.Bottom);
            SetCursorPos(randomX, randomY);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
