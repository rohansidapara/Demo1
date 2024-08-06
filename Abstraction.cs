// Abstraction demo

using System;
using System.Security.Policy;

abstract class Animal_Wild {
    public abstract void AniamlSound();
    public void Sleep()
    {
        Console.WriteLine("Zzz...");
    }
}

class Cat1 : Animal_Wild
{
    public override void AniamlSound()
    {
        Console.WriteLine("The cat says : meow meows");
    }
}