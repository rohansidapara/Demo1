using DemoLoops;
using Encapsulation;
using MyApplication;
using Polymorphism;
using Recursive_demo;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Demo1
{
    // partial class
    public partial class PartialDemo
    {
        public void Display()
        {
            Console.WriteLine("company name : " + item);
            Console.WriteLine("company id : " + companyid);
        }
    }
    // Singleton Class
    public class Singleton
    {
        private static Singleton instance = null;
        public String s;
        private Singleton()
        {
            s = "Hello i am a string part of singleton class";
        }
        public static Singleton Singleton1() // for creating new instance for singleton
        {
            if (instance == null) // singel line body dont need {}
                instance = new Singleton();
            return instance;
        }
    }
    //Sealed class Demo
    sealed class Demo_print
    {
        public void Show123(int a, int b)
        {
            Console.WriteLine("-- Sealed calss demo --");
            Console.WriteLine(a + b);
        }
    }
    // Static demo
    static class Author
    {
        public static int Authorage = 32;
        public static string Authorname = "rohan sidapara";
        public static string Author_l = "c#";
        public static void Show()
        {
            Console.WriteLine("this are the Author deatiles: ");
        }
    }
    public class Program
    {
        static public void Main()
        {
            // Demo of the a Inheritence
            Console.WriteLine("-- Inheritance Demo --");
            Console.WriteLine();
            Animal Dog = new Animal();
            Dog.Walk();

            Cat Tom = new Cat();
            Tom.Walk();
            Tom.Eat();

            Bird Peacock = new Bird();
            Peacock.Fly();
            Peacock.Walk();

            penguin Jerry = new penguin();
            Jerry.swimming();
            Jerry.Walk();

            Eagle eagle = new Eagle();
            eagle.Hunt();

            snake snake = new snake();
            snake.Hear();

            anaconda kingcobra = new anaconda();
            kingcobra.Atteck();
            kingcobra.Hear();

            MyAnimal myAnimal1 = new MyAnimal(); // interface
            myAnimal1.Method1();
            myAnimal1.Method2();
            Console.WriteLine();
            // Demo of the a Encapsulation
            Console.WriteLine("-- Encapsulation Demo --");
            Console.WriteLine();

            Console.WriteLine("demo 1");
            Console.WriteLine();
            Human rohan = new Human();
            rohan.name = "rohan";
            rohan.age = 22;

            Console.WriteLine("name : " + rohan.name);
            Console.WriteLine("age : " + rohan.age);

            Console.WriteLine();
            Console.WriteLine("demo 2");
            Console.WriteLine();

            Myaccount Rohan_account = new Myaccount();
            Rohan_account.Balance = 3000;
            Console.WriteLine("rohan account balance is : " + Rohan_account.Balance);
            Rohan_account.Deposit = 17000;
            Console.WriteLine("upadted balance is : " + Rohan_account.Balance);
            Rohan_account.Withdraw = 25000;
            Rohan_account.Withdraw = 2500;
            Console.WriteLine("Now youe closing balance is : " + Rohan_account.Balance);

            Console.WriteLine();
            Console.WriteLine("-- polymorphism Demo --");

            Console.WriteLine();
            Console.WriteLine("demo 1");
            Console.WriteLine();

            Cars car1 = new Cars();
            car1.Carsound();

            BMW Bmw_m5 = new BMW();
            Bmw_m5.Carsound();

            Supra supra_mk4 = new Supra();
            supra_mk4.Carsound();

            Console.WriteLine();
            Console.WriteLine("demo 2");
            Console.WriteLine();
            // overriding example
            Circle circle = new Circle();
            circle.Area_cal(4);

            Squre squre = new Squre();
            squre.Area_cal(10);

            // overloading example
            Console.WriteLine();
            Console.WriteLine("Overloading Example");
            Console.WriteLine();

            Console.WriteLine(Sum.Add(2, 3));
            Console.WriteLine(Sum.Add(5.0, 4.0)); // SUB OPREATION
            Console.WriteLine();

            Console.WriteLine("-- Abstraction Demo --");
            Console.WriteLine();

            Cat1 Mycat = new Cat1();
            Mycat.Sleep();
            Mycat.AniamlSound();
            Console.WriteLine();

            Console.WriteLine("-- Interface Demo --");
            Console.WriteLine();

            RohanIN rohanin = new RohanIN();
            rohanin.Print();
            rohanin.Print2();

            Console.WriteLine();
            Console.WriteLine("-- Loops --");
            // Demos of Loops
            Loops loops = new Loops();
            loops.If(2); // If loop
            loops.While(1); // While loop
            loops.Ifelse(1); // if else
            loops.Ifelse(0); // if else
            loops.Dowhile(1); // do while
            loops.For();

            Console.WriteLine();
            // assembly

            //Person person = new Person();
            //person.Sayhello();

            //recursion
            //demo 1
            Console.WriteLine("-- Recursive Demo --");
            int n = 5;
            Recursive recursive = new Recursive();
            recursive.Print(n);
   
            Console.WriteLine();
            // Static class and method demo
            Console.WriteLine("-- static class demo -- ");
            Console.WriteLine();
            Author.Show();
            Console.WriteLine("Author name is : " + Author.Authorname);
            Console.WriteLine("Author age is : " + Author.Authorage);
            Console.WriteLine("Author language is : " + Author.Author_l);

            Console.WriteLine();
            Demo_print demo_Print = new Demo_print(); // sealed class
            demo_Print.Show123(5, 6);

            // singleton class
            Console.WriteLine();
            Console.WriteLine("-- Singleton class demo --");
            Singleton X = Singleton.Singleton1(); // creat new instance
            Singleton Y = Singleton.Singleton1(); // creat new instance
            Singleton Z = Singleton.Singleton1(); // creat new instance
            Console.WriteLine("Hashcode of x is " + X.GetHashCode()); // same hashode
            Console.WriteLine("Hashcode of Y is " + Y.GetHashCode());
            Console.WriteLine("Hashcode of Z is " + Z.GetHashCode());

            //Class1 sumdll = new Class1();
            //sumdll.Addition(5, 5); // dll
            Console.WriteLine();
            // virtual class
            Console.WriteLine("-- virtual class --");
            Class1a class1 = new Class1a();
            class1.Class12();
            Class2 class2 = new Class2();
            class2.Class12();
            Class2 class3 = new Class2();
            class3.Class12();
            Console.WriteLine();

            Console.WriteLine("-- Extention demo --");
            ExntensionDemo E = new ExntensionDemo(); 
            E.M1();
            E.M2();
            E.M3();
            E.M4();
            E.M5("method 5");
            Console.WriteLine();

            // demo of partial class
            Console.WriteLine("-- Partial Demo --");
            PartialDemo partialDemo = new PartialDemo("itech" , 123456);
            partialDemo.Display();

            Console.ReadLine();
        }
    }
}