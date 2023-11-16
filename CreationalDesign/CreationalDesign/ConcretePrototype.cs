using System;
using CreationalDesign;

public class ConcretePrototype : IPrototype
{
    public int Id { get; set; }

    public ConcretePrototype(int id)
    {
        Id = id;
    }

    public void Display()
    {
        Console.WriteLine($"ConcretePrototype with ID: {Id}");
    }

    public object Clone()
    {
        // Perform a shallow copy
        return this.MemberwiseClone();
    }
}