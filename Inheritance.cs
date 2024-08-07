using System;

namespace Demo1
{
    // single Inheritance
    class Animal
    {
        public void Walk()
        {
            Console.WriteLine("Animal is walking");
        }
    }

    class Cat : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
    }
    // Multiple Inheritence
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird can fly");
        }
    }
    class penguin : Bird
    {
        public void swimming()
        {
            Console.WriteLine("penguin is swimming");
        }
    }
    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }
    }
    // multi-level Inheritance
    class snake : Animal
    {
        public void Hear()
        {
            Console.WriteLine("sanek can hear voise by its body");
        }
    }
    class anaconda : snake
    {
        public void Atteck()
        {
            Console.WriteLine("anaconda is wildest attecker.");
        }
    }
    interface I1
    {
        void Method1();
    }
    interface I2
    {
        void Method2();
    }
    class MyAnimal : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Animal1 is called.");
        }
        public void Method2()
        {
            Console.WriteLine("Animal2 is called. ");
        }
    }
}
