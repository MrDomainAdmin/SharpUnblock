using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpUnblock
{
    class Program
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFile(string name);
        static void Main(string[] args)
        {
            switch (args.Length)
            {
                case 1:
                    Console.WriteLine("Unblocking " + args[0]);
                    DeleteFile(args[0] + ":Zone.Identifier");
                    break;
                default:
                    Console.WriteLine("Please enter the full path of a file to unblock");
                    break;
            }
        }
    }
}
