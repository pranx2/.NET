using System;
namespace oop_1;
class Person
{
    public string? name, institute,location; // string? means the nullable string return type;
    public  long age, id, userID;
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A simple class created. Were we added the following sections :\n1. Name\n2. ID\n3. Institute\n4. Age\n5. Location\n");
        //Created an new class by referencing the class name;
        //Creating this new way in C#;
        Person p1 = new Person
        {
            userID = 1,
            name = "PRANTO KUMAR SHIL",
            id = 2233081405,
            institute = "Uttara University",
            age = 20,
            location = "Mirpur, Dhaka"
        }; // new means created an new class into the memory, same as memory allocation;

            Console.WriteLine($"Student ID : {p1.userID}");
            Console.WriteLine($"Name : {p1.name}");
            Console.WriteLine($"Age : {p1.age}");
            Console.WriteLine($"ID : {p1.id}");
            Console.WriteLine($"Institute : {p1.institute}");
            Console.WriteLine($"Location : {p1.location}\n\n");

        //Creating in old c++ and C- Structure way;
        Person p2 = new Person();
            p2.userID = 2;
            p2.name = "PRITOM PRANTO";
            p2.age = 21;
            p2.id = 2233081406;
            p2.institute = "State University";
            p2.location = "Vasantek, Dhaka";

            Console.WriteLine($"Student ID : {p2.userID}");
            Console.WriteLine($"Name : {p2.name}");
            Console.WriteLine($"Age : {p2.age}");
            Console.WriteLine($"ID : {p2.id}");
            Console.WriteLine($"Institute : {p2.institute}");
            Console.WriteLine($"Location : {p2.location}");
    }
}
// Both Class using method are good and ok!
