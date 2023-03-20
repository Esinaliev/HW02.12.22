using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace HW02._12._22
{
    class Program
    {
        private const string dllPath = @"C:\Users\GranullBoy\source\repos\HW02.12.22\x64\Debug\Dll1.dll";

        [DllImport(dllPath)]
        private static extern double MySqrt(int x);
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            double result = MySqrt(x);
            Console.WriteLine("Result:" + result);

            Console.WriteLine("<--------- Assembly info --------->");
            Console.WriteLine();
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
