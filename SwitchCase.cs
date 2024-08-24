namespace _NET
{
public class Program
{
  public static void Main(string[] args)
  {
    object num = 300;
    string result = num switch{
        int => "integer",
        string => "string",
        float => "float",
        _ => "unknown type",
    };
    Console.WriteLine(result);
  }  
}
}