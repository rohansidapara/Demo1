using System;

namespace Recursive_demo
{
    public class Recursive
    {
        public void Print(int n)
        {
            if (n > 0) // if n grater than 0 than inter in loop
            {
                Console.WriteLine(n);
                Print(n - 1);
            }
        }
    }
}