using System;
namespace weekDays{
public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter week days : ");
        string weekDays = ReadLine();
        switch (weekDays.ToUpper()){
          case "SATURDAY":
            Console.WriteLine("Saturday");
            break;
          case "SUNDAY":
            Console.WriteLine("Sunday");
            break;
          case "MONDAY":
            Console.WriteLine("Monday");
            break;
          case "TUESDAY":
            Console.WriteLine("Tuesday");
            break;
          case "WEDNESDAY":
           Console.WriteLine("Wednesday");
           break;
          case "THURSDAY":
           Console.WriteLine("Thursday");
           break;
        }
    }
}
}