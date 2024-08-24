using System;
namespace _NET
{
    public class Program 
    {
        public static void Main(string[] args)
        {   
        //Type Conversion;
        // int to float and double
         int x = 20;
         float x1 = (int)x; //Implicit / Auto conversion;
        Console.WriteLine($"int to float conversion {x1}");//int  to float
        double x2 = (double)x;//int  to double
        Console.WriteLine($"int to double conversion {x2}");
        double x3 = (double)x1;// float to double;
        Console.WriteLine($"float to int conversion {x3}");
        // float and double to int;
        //Explicit / Manually Conversion; 
            float y = 5.67f; //f means by float for avoid error;
            int y1 = (int)y;
            Console.WriteLine($"Float {y} to int {y1}");

        //Char to int ;
        char a = 'a'; //Implicit
        int a1 = (int)a;
        Console.WriteLine($"char {'a'} to int conversion {a1}");
        //int to char;
        //Explicit;
        int  a2 = 89;
        char a3 = (char)a2;
        Console.WriteLine($"int {a2} to char conversion {a3}");


            //String to int conversion;
            string data = "10";
            int number = int.Parse(data);
            Console.WriteLine(number);

            //If double to int it will system Error;
            //For  example
                string data2 = " 10.3 ";
                // int number2 = int.Parse(data2);
                // Console.WriteLine(number2);
    //Remove this error;
    //In this method if string to int not convert then also the program will run successfully.
    //and it's return only true/false;
        bool number2 = int.TryParse(data2 , out int result);
        Console.WriteLine($"Result is : {result}");
        Console.WriteLine($"Number2 is : {number2}");       

        // int to string
        //Implicit conversion;
            int s = 900;
            string s1 = Convert.ToString(s); // Convert.ToString() is used for implicit conversion;
            Console.WriteLine($"int {s} to string {s1}");   

            //Conversion using builtin function;
                int  ex = 60;
                Console.WriteLine("Double : " + Convert.ToDouble(ex));
                Console.WriteLine("char : " + Convert.ToChar(ex));
                Console.WriteLine("String : " + Convert.ToString(ex));
        }
    }
}