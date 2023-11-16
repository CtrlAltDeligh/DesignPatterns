using System;

namespace CreationalDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             
The Prototype design pattern is a creational pattern that involves 
creating new objects by copying an existing object, known as the prototype.
Instead of creating a new instance of a class using a constructor, the
Prototype pattern involves creating new instances by copying an existing instance.
             */
            ConcretePrototype prototype = new ConcretePrototype(1);
            ConcretePrototype clonedObject =  (ConcretePrototype)(prototype.Clone());
            
           

            Console.WriteLine("Original Prototype: ");
            prototype.Display();
            Console.WriteLine();
        
            Console.WriteLine("Cloned Object: ");
            clonedObject.Display();

        }
    }
}