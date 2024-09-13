namespace MiniGame;
class Program
{
    static void Main(string[] args){
    Random ai = new Random();//Random function called for generate random number;
    Console.WriteLine($"Welcome to Stone, Paper  Scissor game.\nGame Tips :(Stone/Rock : R, paper : P, Scissor : S)");
    while (true){
    Console.Write($"Now your turn : ");
    int ComputerInput = ai.Next(0,3);//Computer input;
    char userInput = Convert.ToChar(Console.ReadLine());//User input;
    MatchResult(userInput, ComputerInput);
    }
}
    // Game Judge;
    static void MatchResult(char userInput, int ComputerInput){
        //Store/Rock is R; Paper is P; Scissor is S;
        char[] arr = {'P','R','S'}; //Random data store in array;
        Console.WriteLine($"User Output : {userInput}");
        Console.WriteLine($"Computer Output : {arr[ComputerInput]}");
        if(char.ToUpper(userInput) == 'R' && arr[ComputerInput] == 'S' || char.ToUpper(userInput) == 'S' && arr[ComputerInput] == 'R'){
            Console.WriteLine($"Stone crushes Scissor. Stone wins!");
        }
        else if (char.ToUpper( userInput) == 'R' && arr[ComputerInput] == 'P' || char.ToUpper( userInput) == 'P' && arr[ComputerInput] == 'R'){
            Console.WriteLine($"Paper crushes Stone. paper wins!");
        }
        else if(char.ToUpper(userInput )== 'P' && arr[ComputerInput] == 'S' || char.ToUpper(userInput )== 'S' && arr[ComputerInput] == 'P'){
            Console.WriteLine($"Scissor crushes Paper. Scissor Wins!");
        }
        else Console.WriteLine($"Match Tie");
    }
}

