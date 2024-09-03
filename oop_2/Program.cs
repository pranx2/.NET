namespace oop_2;
class DataType{
    //In c# if we declared a function we must select that visibility -> public/private/protected;
    public int integer(){ //function in class must be public;
        Console.WriteLine("Integer without parameter.");
        return 0;
    }
     public int integer(int i){ // it can be called in  two ways 
        //In WriteLine and Without WriteLine;
        Console.WriteLine($"Integer with parameter : {i}");
        return 0;
    }
    public float f(){
        Console.WriteLine("Float without parameter");
        return 0.00f; //0f means it's ad floating value;
    }
    public float f(float f){
        Console.WriteLine($"Float with parameter : {f}");
        return 0f;
    }
    public double d(){
        Console.WriteLine("Double without parameter");
        return 0.00d;
    }
    public double d(double d){
        Console.WriteLine($"Double with parameter : {d}");
        return 0.00d;
    }
    public char c(){
        Console.WriteLine("Char without parameter");
        return 'a';
    }
    public char c(char c){
        Console.WriteLine($"Char with parameter  : {c}");
        return c;
    }
    public string s(){
        Console.WriteLine("string without parameter.");
        return "string";
    }
    public string s(string s){
        Console.WriteLine($"string with parameter : {s}");
        return "Hello";
    }
    public void NonReturn(){
        Console.WriteLine("Void type without parameter.");
    }
    public void NonReturn(string s){
        Console.WriteLine($"Void with parameter : {s}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data type with parameters and Non-parameter.");
        DataType Dt = new DataType();//Allocate New class in Dt

        Dt.integer();
        Dt.integer(20);//Without WriteLIne
        Console.WriteLine($"integer with return type parameter :{Dt.integer(100)}");//WriteLine

        //Floating  point number;
        Dt.f();
        Dt.f(34.6f); // must be declared as a float value;
        Console.WriteLine($"Float with non-return type : {Dt.f()}");

        //Double point Number;
        Dt.d();
        Dt.d(56.89);

        //Char data type;
        Dt.c();
        Dt.c('x'); // char given as argument it must be in char formate type;

        //String data type;
        Dt.s();
        Dt.s("PRANTO IS GOOD PROGRAMMER");

        //void
        Dt.NonReturn();
        Dt.NonReturn("PRANTO IS GOOD AT learning.");
    }
}
