// Abstraction demo

using System;
using System.Security.Policy;

abstract class Animal_Wild {
    public abstract void AniamlSound(); // absract method
    public void Sleep() // normal method
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