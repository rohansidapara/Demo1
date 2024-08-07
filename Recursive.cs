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

        // demo 2 incomplete
        // prime number

        //public bool Primenumber(int n1)
        //{
        //    if (n1 == 1 || n1 == 0)  return false;

        //    for (int i = 2; i < n1; i++)
        //    {
        //        if (n1 % i == 0) ;
        //        return false;
        //    }
        //    return true;
        //}
    }
}