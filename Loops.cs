using System;

namespace DemoLoops
{
    public class Loops
    {
        // If loops
        public void If(int value)
        {
            if (value < 3)
                Console.WriteLine("this is demo of If loop.");
        }
        // if else 
        public void Ifelse(int i)
        {
            if (i == 1)
                Console.WriteLine("True");
            else
            {
                Console.WriteLine("False");
            }
        }
        // while loops
        public void While(int i)
        {
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        // do while 
        public void Dowhile(int i)
        {
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
        public void For()
        {
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}