using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
    // Base class
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class that overrides and seals the method
public class Dog : Animal
{
    public sealed override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Another class derived from Dog
public class Chihuahua : Dog
{
        // This will cause a compile-time error
        // because MakeSound() is sealed in the Dog class.

        //public override void MakeSound()
        //{
        //    Console.WriteLine("The chihuahua yaps.");
        //}

    }



}
