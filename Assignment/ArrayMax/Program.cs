namespace ArrayMax;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Array Max Element Find out!");
        Console.WriteLine("\nEnter the array size :");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int i = 0; i < size; i++){
            Console.WriteLine($"Enter the array {i} value : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0], index = 0;
        for(int i = 1; i < size; i++){
            if(arr[i] >= max){
                max = arr[i];
                index = i;
            }
            }
        Console.WriteLine($"Array Max element is  : {max} Index is : {index}");

    }
}
