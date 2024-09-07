namespace RandomNumber;

class Program
{
    public static void Main(string[] args)
    {
    //Enter the Limitation of the code min & max; default 1-100;
    int min = 1, max = 100, count = 0;
      Random r = new Random(); 
      //user input;
      Console.Write("Welcome to the Guess Random Number Game!\nThe Default range is (1 - 100)\nDo you want to set the random number  range? (y/n) :");
      char UserInput = Convert.ToChar(Console.ReadLine());
        if( char.ToUpper(UserInput) == 'Y'){
            Console.WriteLine("Enter the minimum range : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum range : ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have set the range from {min} to {max} ");
        }
        //Number guess and loop condition;
      Console.WriteLine("Enter the  number you think the random number is: ");
      int g = r.Next(min,max);
      int x  = Convert.ToInt32(Console.ReadLine());
      while( g != x){
        if( x > g) {
            Console.WriteLine($"Oops! Your guess is too high. Try again!\nHint: (Number will be {min}-{max})");
            Console.Write("Input the number again : ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        else if( x < g){
            Console.WriteLine($" Oops! Your guess is too low. Try again!\nHint: (Number will be {min}-{max})");
            Console.Write("Input the number again : ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        count++;//Counting the guesses;
      }
      Console.WriteLine($"Congrats! You guessed the number after {++count}th try.");
    }
  }