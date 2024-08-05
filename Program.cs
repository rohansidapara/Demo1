using DemoLoops;
using Encapsulation;
using MyApplication;
using Polymorphism;
using System;

namespace Demo1
{
    internal class Program
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

            MyAnimal myAnimal1 = new MyAnimal();
            myAnimal1.Method1();
            myAnimal1.Method2();


            Console.WriteLine();
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
            Console.WriteLine("name : " + rohan.age);

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

            Circle circle = new Circle();
            circle.Area_cal(4);

            Squre squre = new Squre();
            squre.Area_cal(10);

            // overloading example
            Console.WriteLine();
            Console.WriteLine("Overloading Example");
            Console.WriteLine();

            Console.WriteLine(Sum.Add(2, 3));
            Console.WriteLine(Sum.Add(4.0, 5.0));
            Console.WriteLine();

            //Console.WriteLine("write your name here : ");
            //string username = Console.ReadLine();

            //Console.WriteLine("Your name is " + username);
            Console.WriteLine("-- Abstraction Demo --");
            Console.WriteLine();

            Cat1 Mycat = new Cat1();
            Mycat.sleep();
            Mycat.aniamlSound();
            Console.WriteLine();

            Console.WriteLine("-- Interface Demo --");
            Console.WriteLine();

            RohanIN rohanin = new RohanIN();
            rohanin.Print();
            rohanin.Print2();

            Console.WriteLine();
            // Demos of Loops
            Loops loops = new Loops();
            loops.Loops1(2); // If loop
            loops.Loops2(1); // While loop
            loops.Loop1(1); // if else
            loops.Loop1(0); // if else
            //loops.Loop2(2); // do while

            Console.ReadLine();
        }
    }
}
