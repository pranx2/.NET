namespace ArraySum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Array Sum!\nEnter the array size :");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int evenSum = 0, OddSum = 0;
        for(int i = 0; i < size; i++){
            Console.WriteLine($"Enter the array {i} value : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < size;  i++){
            if( arr[i] % 2 == 0 ) evenSum += arr[i];
            else OddSum += arr[i];
        }
        Console.WriteLine($"Total Even Sum : {evenSum}");
        Console.WriteLine($"Total Odd Sum : {OddSum}");

    }
}
