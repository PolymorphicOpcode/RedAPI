using System;
using System.Runtime.InteropServices;

public class Program {
    public static void Main() {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        MessageBox(IntPtr.Zero, "Hello, world!", "Message", 0);
    }
}