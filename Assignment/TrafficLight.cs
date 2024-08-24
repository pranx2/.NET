/// This program takes user input for the first letter of a traffic light color
/// and outputs the corresponding color meaning. It also converts the input letter
/// to uppercase or lowercase depending on the original case.
namespace Task1;
class Program
{
    static void Main(string[] args)
    {   
        //User Input;
        Console.Write("Enter the first letter of the light : ");
        Console.WriteLine(" i.e. ( Red R/r , Green G/g , Yellow Y/y )");
        char tl =char.Parse(Console.ReadLine());

        //checking  for traffic light color;
        if( tl == 'R' || tl == 'r' ) Console.WriteLine("STOP");
        else if( tl == 'G' || tl == 'g' ) Console.WriteLine("GO");
        else if( tl == 'Y' || tl == 'y' ) Console.WriteLine("GO SLOW");
        else Console.WriteLine("You have not Entered the correct letter.");

        // converting upper to lower and  vice versa;
        if(char.IsLower(tl)) Console.WriteLine(char.ToUpper(tl));
        else if(char.IsUpper(tl)) Console.WriteLine(char.ToLower(tl));
    }
}
