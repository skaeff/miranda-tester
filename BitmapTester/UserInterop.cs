using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace BitmapTester
{
    class UserInterop
    {
        [DllImport("user32.dll",CharSet=CharSet.Auto, CallingConvention=CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, UIntPtr dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
       
        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        

        public static void DoMouseClick(Rectangle rect, Action action)
        {

            //Call the imported function with the cursor's current position
            uint X = (uint)(rect.X + rect.Width / 2);
            uint Y = (uint)(rect.Y + rect.Height / 2);

            SetCursorPos((int)X, (int)Y);

            //mouse_event((uint)(MouseEventFlags.LEFTDOWN | MouseEventFlags.LEFTUP | MouseEventFlags.ABSOLUTE), X, Y, 0, UIntPtr.Zero);
            mouse_event((uint)(MouseEventFlags.LEFTDOWN| MouseEventFlags.ABSOLUTE), X, Y, 0, UIntPtr.Zero);
            mouse_event((uint)(MouseEventFlags.LEFTUP | MouseEventFlags.ABSOLUTE), X, Y, 0, UIntPtr.Zero);
        
        }
    }
}
