using System;
using System.Runtime.CompilerServices;

namespace Demo1
{
    internal class ExntensionDemo
    {
        public void M1()
        {
            Console.WriteLine("method 1");
        }
        public void M2()
        {
            Console.WriteLine("method 2");
        }
        public void M3()
        {
            Console.WriteLine("method 3");
        }
    }

    static class ExtreMethod 
    {
        public static void M4(this ExntensionDemo E) // this keyword for binlding classes
        {
            Console.WriteLine("method 4");
        }
        public static void M5(this ExntensionDemo E, string str) // this keyword example with passing string in parameter
        {
            Console.WriteLine(str);
        }
    }
}