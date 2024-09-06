namespace oop_4;
//properties used in class member;
//If a class has  private member, it can be access by using properties get/set method;
//get syntax is  get{return [Name of the properties];}
//set syntax is set{[Name of the properties = value;]} // value is the by default reserve data type; 

class person{
    private string name;
    private int  age, id;
    public int Age{
        get{return age;}//a accessor which used to access private member;
        set{age = value;}//easily set and get data from private method;
    }
    public string Name{
        get{return name;} // No semicolon in the end;
        set{
            if(value != null && value.Length >= 2){ //name length must be longer then 2 and not to be null/empty;
            name = value;
            }
        } // we can use condition or anything we want into here;
    }
    public int ID{
        get; set; // if we just need to get or set data, we can use this  syntax;

    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        person pi = new person{
            Name  = "PRITOM", // variable must be properties type;
            Age = 20,
            ID = 405,
        };
        Console.WriteLine($"Name : {pi.Name} and Age is : {pi.Age} ID is : {pi.ID}");
    }
}
