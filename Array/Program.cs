namespace Array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the Array : ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[x]; //Array Declaration in c#
        Console.WriteLine("Enter the Value of the array : ");
        int i = 0, j = 0;
        while( i < x ){
            Console.WriteLine($"Enter the '{i}' index element : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        while( j < arr.Length ){
            Console.WriteLine($"Index : {j} value is : {arr[j]}");
            j++;
        }
    }
}
