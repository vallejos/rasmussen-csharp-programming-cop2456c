using System;

public class Varmint : ICritter
{
    private int Hunger;

    public Varmint(int hunger=0) {
        Hunger = hunger;
        Console.WriteLine("Another Varmint has hatched!");
    }

    public void Howdy() {
        Console.WriteLine("Howdy! I'm a Varmint and my Hunger level is " + Hunger);        
    }

}
