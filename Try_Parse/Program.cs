namespace Try_Parse;
//Try parse is a bool type which takes the user input and return the true/false 
//is user input is incorrect then its show false also the vice-versa;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try Parse!");
        string input = (Console.ReadLine()) ?? "";
        bool x = int.TryParse(input, out int output);//checking the value is correct with data types or not;
        Console.WriteLine($"User Input : {x}\toutput is : {output} ");
    }
}
