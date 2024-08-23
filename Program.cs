//All System lib
using System;
namespace _NET; //Contains .NET

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("C# running Ok.");
        // int x = 1;
        // int y = 2;
        // Console.WriteLine("Value is " + 1+2);
        // Console.WriteLine(x+y);

        // Data Types
        // int a = 3;
        // float  b= 30.30f; //f for float;
        // double c = 34.4d; //d for double;
        // Console.WriteLine(a);
        // Console.WriteLine(b);
        // Console.WriteLine(c);

        //TypeCasting;
            // 1. Implicit Casting
                // [Auto] ->Char to int to long to float to double ;
        //     int x = (int) 3.5;
        //     int z = 'k';
        //     Console.WriteLine(x);
        //     Console.WriteLine(z);

        //     // 2. Explicit Casting
        //         // [Manually] ->  int to char -> long to int -> float to int -> double to int ;
        //      double x1 = (double) 5.89;
        //     Console.WriteLine(x1);

        // float var = Convert.ToInt64(5.20);
        // Console.WriteLine(var);
        // Convert.ToDouble;
        // Convert.ToString;
    //Input Output;
        // Console.WriteLine("Write your name");
        // string name = Console.ReadLine();
        // Console.WriteLine("Hello " + name);


        // operators
        //Math
        // int  t = Math.Max(32,345); // Compare
        //     Console.WriteLine(t);
        // int r  = Math.Min(32,0); //Mini
        // Console.WriteLine(r);
        // int s = Math.Abs(-5); //Absolute
        // Console.WriteLine(s);
        // double d = Math.Pow(2,3); //Power
        // Console.WriteLine(d);
        // double m = Math.Sqrt(49); //Root
        // Console.WriteLine(m);

    //String;
        // string Hello = "Hello World this is Pranto";
        // Console.WriteLine(Hello.Length);
        // Console.WriteLine(Hello.ToUpper()); //For upper Case
        // Console.WriteLine(Hello.ToLower());
    //String Interpolation
        // string name = Console.ReadLine();
        // string Candies = Console.ReadLine();
        // Console.WriteLine($"Your name is {name}. You will get {Candies} candies.");

        string personName = Console.ReadLine();
        string Age  = Console.ReadLine();
        string Country = Console.ReadLine();
        Console.WriteLine($"Hello Sir,{personName}. Welcome to {Country}, Your age is {Convert.ToInt64(Age)}.");
        Console.WriteLine($"{personName}, You have successfully Got {Country}n Visa.");
    }
}
