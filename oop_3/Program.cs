namespace oop_3;
class student{ //Declared a class, it has two types of encapsulation *Private *public
    private int age,id; //Store data. Not access to Read/Write;
    private string? grade, name; //it has private access modifier;

    //Default Constructor;
    public student(){ //Public access modifier; Constructor;
            Console.WriteLine("Student details : ");
        }
    //It's own function member can read/write;
        public void SetDetails(int g_id, string g_name, int  g_age, string g_grade){
              id = g_id; 
              name = g_name;
              age = g_age;
              grade = g_grade;
            }
        public void GetDetails(){
                Console.WriteLine($"ID : {id}\nName : {name}\nAge : {age}\ngrade : {grade}");
            }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encapsulation!");
        student st = new student(); //making a new class as reference as student class;
            st.SetDetails(405,"PRANTO KUMAR SHIL", 20, "A+");
            st.GetDetails();
    }
}
