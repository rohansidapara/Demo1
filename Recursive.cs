using System;

namespace Recursive_demo
{
    public class Recursive
    {
        public void Print(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                Print(n - 1);
            }
        }
    }
}