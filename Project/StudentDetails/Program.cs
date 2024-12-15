using System;
using System.Threading;
using System.Threading.Tasks;
namespace StudentDetails;
class StudentDetails{
    private string? StudentID{get; set;} // ? means nullable 
    private string?  Batch{get; set;}
    private string? Semester{get; set;}
    private string? VarsityName{get; set;}
    private string? StudentName{get; set;}
    private string? Department{get; set;}
    private DateTime _dateOfBirth ; // date of time is datatype special for date and time; it can't be null;
    public DateTime DateOfBirth{ // Date of birth property;
        get { return _dateOfBirth;} // get Date of birth;
        set{
            if(value > DateTime.Now){ // if date of birth is not valid;
                throw new ArgumentException("Date of Birth can't be future!"); // Exception Handling;
            } _dateOfBirth = value;
        }
    }

    //! Constructor initialized with default Values;
    public StudentDetails(string name,DateTime dateTime ,string id,string batch,string semester,string institute,string dpt){
        StudentName = name;
        StudentID = id;
        Batch = batch;
        Semester = semester;
        VarsityName = institute;
        Department = dpt;
        DateOfBirth = dateTime;
    }
   public int CalculateAge(){ // calculating age;
    int Year = DateTime.Now.Year - _dateOfBirth.Year;
    return Year;
}
    public void ShowDetails(){
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Date of Birth:{_dateOfBirth.ToShortDateString()}"); // for showing date in short format;
        Console.WriteLine($"Student ID:   {StudentID}");
        Console.WriteLine($"Batch:        {Batch}");
        Console.WriteLine($"Semester:     {Semester}");
        Console.WriteLine($"Varsity Name: {VarsityName}");
        Console.WriteLine($"Department:   {Department}");
    }
}
class Program{
    static void Main(string[] args){
        Console.WriteLine("Welcome to Student Details!\n\n");
        Console.WriteLine($"Loading...\n");
        Thread.Sleep(2000); // holding program for 2 seconds;
        try{ // trying this block of code;
        StudentDetails Student1 = new StudentDetails("Pranto",new DateTime(2005,10,16), "2233081405", "60-A", "Fall-24", "Uttara University", "CSE");
        StudentDetails Student2 = new StudentDetails("Pritom",new DateTime(2003,10,16),"2233081406","60-B","Fall-24","Uttara University","CSE");
        
        Student1.ShowDetails();
            Console.Write($"Student Age is :  {Student1.CalculateAge()} Year ");
            Console.WriteLine($"{DateTime.Now.Month - Student1.DateOfBirth.Month} Month {DateTime.Now.Day - Student1.DateOfBirth.Day} Days");
        
        Console.WriteLine($"\n\n"); //Line BReaks
        
        Student2.ShowDetails();
            Console.WriteLine($"Date Of Birth: {Student1.DateOfBirth.ToShortDateString()}");
            Console.Write($"Student Age is :  {Student2.CalculateAge()} Year ");
            Console.WriteLine($"{DateTime.Now.Month - Student2.DateOfBirth.Month} Months {DateTime.Now.Day - Student2.DateOfBirth.Day} Days");
        }//if any error occurs, catch block will catch the error;
            catch (Exception __Birth){
                Console.WriteLine($"Error: {__Birth.Message}");
            }
    }
}
