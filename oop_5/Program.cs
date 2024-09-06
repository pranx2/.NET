namespace oop_5;
//this and Readonly modifier;
public class student{
    //access  to write by Declaration and Constructor 
    public readonly int age; // only read not access to write;
    // public readonly int age = 40; //using by declaration;
    public student(int age){ // using by constructor;
        this.age = age; //this means class current object;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        student s1 = new student(40); // using  by constructor;

        // s1.age = 30; // using by declaration;
    Console.WriteLine($"age is  : {s1.age}");
    }
}
