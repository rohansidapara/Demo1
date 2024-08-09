using System;

namespace MyApplication
{
    public interface IABC { // interface contian empty methods
        void Print();
    }
    public interface IDEF
    {    
        void Print2();
    }
    class RohanIN : IABC, IDEF
    {
        public void Print()
        {
            Console.WriteLine("Interface 1 called"); //override
        }
        public void Print2()
        {
            Console.WriteLine("Interface 2 called");
        }
    }

}