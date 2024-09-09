namespace StudentDetails;
class student{
    private string? _name, _rollNumber;
    private DateTime _dateOfBirth;
    public string Name{ get {return _name;} set {_name = value;}} //using properties;
    public string Roll{ get {return _rollNumber;} set {_rollNumber = value;}}
    public DateTime DateOfBirth{ get {return _dateOfBirth;} set { _dateTime = value;}}
     public student(string name, string rollNumber, DateTime dateTime){
        Name = name;
        Roll = rollNumber;
        DateOfBirth = dateTime;
    }
    public void  StudentPreview(){
        Console.WriteLine($"ID : {rollNumber}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
