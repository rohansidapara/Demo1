// Abstraction demo

using System;
using System.Security.Policy;

abstract class Animal_Wild {
    public abstract void aniamlSound();
    public void sleep()
    {
        Console.WriteLine("Zzz...");
    }
}

class Cat1 : Animal_Wild
{
    public override void aniamlSound()
    {
        Console.WriteLine("The cat says : meow meows");
    }
}