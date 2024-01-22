using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GetNetBIOSName {   
    class Program {
        [DllImport("kernel32.dll")]
        static extern bool GetComputerNameA(StringBuilder lpBuffer, ref uint lpnSize);

        static void Main(string[] args) {
            uint bufSize = 100;
            StringBuilder buffer = new StringBuilder((int)bufSize);

            if (GetComputerNameA(buffer, ref bufSize)) {
                Console.WriteLine("Computer: {0}", buffer);
            }
            else {
                Console.WriteLine("Failed to get computer name.");
            }
        }
    }
}