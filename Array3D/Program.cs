namespace Array3D;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[,,] array3D = { {{1,2,3}, {1,2,3}, {1,2,3}}, {{4,5,6},{4,5,6},{4,5,6}},{{7,8,9},{7,8,9},{7,8,9}}};
        Console.WriteLine($"Array3D Showing...");
        for(int i = 0;i < array3D.GetLength(0); i++ )
        {
            for(int j = 0; j < array3D.GetLength(1); j++)
            {
                for(int k = 0; k < array3D.GetLength(2); k++)
                {
                    Console.WriteLine($"Array3D [{i}x{j}x{k}] = {array3D[i,j,k]}");
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"");
        }
    }
}
