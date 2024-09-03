namespace EvenOddIndicate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Even Odd Indicator\n");
        for(int i = 1; i <= 10; ++i){
            if( i % 2 == 0 )Console.WriteLine($"Even {i}");
            else Console.WriteLine($"Odd {i}");
        }
    }
}
