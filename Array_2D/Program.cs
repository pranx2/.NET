using System;
namespace Array_2D;

class Program
{
    static void Main(string[] args)
    {
        //basics of array declaration and initialization
        int[] array = new int[5]; //! Declaration;
        int[] array2 = {1,2,3,4,5,6,}; //! Declaration and Initialization;
        
        // / 2D array; here Row = 3, Col = 3;
        int[,] array2DD = {{1,2,3}, {4,5,6}, {7,8,9}}; // 2D array declaration and initialization;
        Console.Write($"2D array elements by showing by foreach loop : ");
        foreach(int i in array2DD){
            Console.Write($"{i}\t");
        }
        Console.WriteLine($"");



        int[,] array2D = new int[2,3]; // 2D array declaration;
        Console.WriteLine($"Enter the array elements: ");

        for(int i = 0; i <array2D.GetLength(0); i++) // 0 means first index of array //?{int[0,1]}
        {
            for(int j = 0; j < array2D.GetLength(1); j++)
            {   
            Console.Write($"Enter the element at index [{i}x{j}] : ");
                array2D[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine($"Array elements are: ");
        for(int i = 0; i <array2D.GetLength(0); i++) // 0 means first index of array //?{int[0,1]}
        {
            for(int j = 0; j < array2D.GetLength(1); j++)
            {   
            Console.Write($"Element at index [{i}x{j}] : {array2D[i,j]}\n");
            }
            Console.WriteLine($"");
        }

    }
}
