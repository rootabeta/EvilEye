using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EvilEye
{
    internal class Program
    {
        [DllImport("shell32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsUserAnAdmin();

        static void Main(string[] args)
        {
            if (IsUserAnAdmin()) {
                Console.WriteLine("Running in admin mode");
            } else
            {
                Console.WriteLine("Running in user mode");
            }
        }
    }
}
