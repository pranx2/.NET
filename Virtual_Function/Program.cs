namespace Virtual_Function;
class car{ //! Base Class;
    public virtual void Display(){
        Console.WriteLine($"This is Virtual Class ! Car.......");
    }
}
class Bike : car{ //Derive Class;
    public override void Display()
    {
        Console.WriteLine($"This is Overridden Class ! Bike......");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        car c1 = new car();
        c1.Display();

        Bike b1 = new Bike();
        b1.Display();
    }
}
//! Virtual is just a way that same method but we can change it in the derived class;