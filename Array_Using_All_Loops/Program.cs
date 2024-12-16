namespace Array_Using_All_Loops;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int i = 0; // for point array index 0;

        //using Do While Loop;
        do{
            Console.Write($"{num[i]} ");
            i++;
        }while(i < num.Length);

        //line ghape;
        Console.WriteLine($"");

        //using While Loop;
        int j = 0;
    while(j <= num.Length){
        Console.Write($"[{j}] , ");
        j++;
    }

    //line ghape;
    Console.WriteLine($"");
    //using Foreach Loop;
    foreach(int k in num){ // in foreach loop index start at index 1;
        Console.Write($"[{k}] , ");
    }

    //line ghape;
    Console.WriteLine($"");
    //using For Loop;
    for(int l = 0; l <= num.Length; l++){
        Console.Write($"[{l}] , ");
    }
    }
}
