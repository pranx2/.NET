namespace oop_6_Abstract;
abstract class test
{
    public abstract void sum();
    public void testFunc()
    {
        Console.WriteLine("this is test function");
    }
}
class testChild : test
{
    public override void sum()
    {
        Console.WriteLine("this is overriden test function");
    }
}
interface Car
{
    void sum_Car();
}

class Bike : Car
{
    public void sum_Car()
    {
        Console.WriteLine("this is overriden car function");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //lower Classes Code
        vehicle car = new Cars(); // Abstract Object derive with concrete class// lso called as upcasting
        vehicle bike = new Bikes();
        Cars c1 = new Cars(); // also we can create object of concrete class; // Downcasting

        car.Brand();
        bike.Brand();

    //Upper Classes Cod;
        Bike bk = new Bike();
        bk.sum_Car();
        testChild tc = new testChild();
        tc.sum();
    }
}

public abstract class vehicle : Ivehicle
{ // public abstract class
    public abstract void Brand();
    public string? color { get; set; }
}

public interface Ivehicle
{
    public void Brand()
    {
        Console.WriteLine("This is a vehicle");
    }
    public string? color { get; set; }
}
public class Cars : vehicle,Ivehicle
{
    public override void Brand()
    {
        Console.WriteLine($"This is a Car");
    }
}

public class Bikes : vehicle, Ivehicle
{
    public override void Brand()
    {
        Console.WriteLine($"This is a Bike");
    }
}