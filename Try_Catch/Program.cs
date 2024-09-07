namespace Try_Catch;
/// <summary>
/// This is small program which takes two number and check the number is  valid or not, 
/// Here we use the try catch throw;
/// This is just an example, it can be better with Try Parse;
/// </summary>
class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine($"This Function is about Try parse and error handling.\n");
        try{ // trying to catch the valid data; 
            int num1 = checkNum("num1");//passing the input into the function;
            int num2 = checkNum("num2");//passing the input into the function;
        } catch (ArgumentException ex){ //Exception by dev define;
            Console.WriteLine($"{ex.Message}");
        }

    }
static int checkNum(string prompt){
        while(true){
            Console.WriteLine($"Enter the {prompt} digit : ");
            string num1 = Console.ReadLine() ?? ""; //taken an string input
            if(string.IsNullOrEmpty(num1)){ //checking the input is valid or not;
                // throw new ArgumentException($"Enter the Valid Number : ");//if errors occur then return this line;
                Console.WriteLine($"Enter the Valid Number : ");
                continue; // if not meet the requirement then skip the later lines and start from the begin;
            }
        //!Checking the value is valid or not!
        try{
            Console.WriteLine($"{prompt} is : {num1}");
            return Convert.ToInt32(num1); // if input is valid then convert it to integer and return the value;
        }
        catch (ArgumentNullException ex) //catching null exception;
        {
            Console.WriteLine($"{ex.Message}");
            continue;

        }
        catch (System.OverflowException ex) //Catching overflow Exception;
        {
            Console.WriteLine($"Error 404 : {ex.Message}");
            continue;

        }
        catch(System.FormatException ex) //Catching Data Formate Exception;
        {
            Console.WriteLine($"Error 404 : {ex.Message}");
            continue;
        }
        }
    }
}