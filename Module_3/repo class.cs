using System;

class Octopus
{
    public readonly int Legs = 8;

    public Octopus()
    {
        Console.WriteLine("This octopus has " + Legs + " legs.");
    }
}

class Program
{
    static void Main()
    {
        Octopus o = new Octopus();
    }
}
