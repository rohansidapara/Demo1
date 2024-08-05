using System;

namespace Polymorphism
{
    class Cars
    {
        public void Carsound()
        {
            Console.WriteLine("The Cars make sound.");
        }
    }

    class BMW : Cars
    {
        public void Carsound()
        {
            Console.WriteLine("The Bmw sound likes : vroom vroom");
        }
    }

    class Supra : Cars
    {
        public void Carsound()
        {
            Console.WriteLine("The Supra sound like : ratttta ratttttaa..");
        }

    }

    class area
    {
        public void area_cal() { }
    }

    class Circle : area
    {
        public void Area_cal(double redius)
        {
            Console.WriteLine("area of circle is " + 3.14 * redius * redius + " for redius " + redius);
        }
    }

    class Squre : area
    {
        public void Area_cal(int side)
        {
            Console.WriteLine("Area of squre is " + side * side + " which side is " + side);
        }
    }

    // compile time polymorphism // method overloading

    class Sum
    {
        public static int Add(int a, int b)
        {
            //Console.WriteLine("SUM of this number is " + (a + b));
            return a + b;
        }
        public static double Add(double a, double b)
        {
            // Console.WriteLine("SUM of this number is " + (a + b));
            return a + b;
        }
    }
}
