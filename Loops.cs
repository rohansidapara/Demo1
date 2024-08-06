using System;

namespace DemoLoops
{
    public class Loops
    {
        // If loops
        public void Loops1(int value)
        {
            if (value < 3)
            {
                Console.WriteLine("this is demo of If loop.");
            }
        }

        // if else 

        public void Loop1(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        // while loops

        public void Loops2(int i)
        {
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // do while 

        public void Loop2(int i)
        {
            do
            {
                Console.WriteLine("Ture");
                i++;
            } while (i > 5);
        }
    }
}