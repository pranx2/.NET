//Try throw catch;
//finally


namespace Exception_Handling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Expectation Handling");
        try{
        Console.WriteLine($"Enter the First Number : ");
        string input1 = Console.ReadLine() ?? "";
        if( string.IsNullOrEmpty(input1)){
            throw new ArgumentException("Can't be Null of Empty");
        }
        int num1 =  Convert.ToInt32(input1);
        Console.WriteLine($"Enter the Second Number : ");
        string input2 = Console.ReadLine() ?? "";
        if(string.IsNullOrEmpty(input2)){
            throw new ArgumentException("Can't be Null of Empty");
        }
        int num2 = Convert.ToInt32(input2);
        if(num2 > 1000){//throw something if problem occurs;
            throw new Exception("Can't be greater then 1000");
        }
        int result = num1/num2;
        Console.WriteLine($"Result : {result}");
        }
        catch(System.OverflowException){//must be top of the exception;
            Console.WriteLine($"overflow");
        }
        catch( ArgumentNullException ){
            Console.WriteLine("Can't be null .");
        }
        catch(System.FormatException){ // unexpected data type ;
            Console.WriteLine("Please inter the valid number .");
        }
        catch(System.DivideByZeroException){
            Console.WriteLine("Can't  divide by zero .");

        }
        catch (System.Exception ex)//multiple catch can be taken;
        {//This exception catches all the possible problems;
             Console.WriteLine($"Exception  Caught : {ex.Message}");
        }
        finally{
            Console.WriteLine($"Good Bye!");
        }
    }
}
