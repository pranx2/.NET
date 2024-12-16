namespace Array_2;

class Program
{
    static void Main(string[] args)
    {
        string[] Name = new String[5]; //? Array Declaration with size;
        Name[0] = "Pranto"; // Array Initialization;
        Name[1] = "Pritom";
        Name[2] = "Rahim";
        Name[3] = "Karim";

        for(int i = 0; i < Name.Length ; i++){ // index start from 0 to 4
            Console.WriteLine($"Name[{i}] = {Name[i]}");
        }

        //! Another_Method ;
        string[] Names = {"pranto", "Pritom", "Rahim", "Karim"}; //? Array Initialization with value;
        int count = 0;   // for counting the names;
        foreach (string Picking_Names in Names) //? Foreach Loop kind of a iterator in c++!
        {
            Console.WriteLine($"Name {++count} = {Picking_Names}");
        }

        // with foreach loop we can't get the index of the array;
        int[] nums = {20,40,50,20,50}; //? Array Initialization with value;
        int sum = 0; 
        foreach(int num in nums){
            sum += num;
            Console.WriteLine($"sum = {sum}");
        }
        //! with condition;
        int[] indexnum = {-3,4,5,-7,2,-4,5};
        foreach (int item in indexnum){
            if(item > 0){
                Console.WriteLine($"Greater then Zero  : {item}");
            }
        }
        /* 
        ! foreach cannot iterate the index , it's only take every input
        ! from the array and store it into a  `variable` and print the `Variable` value;
        ? on the Other hand for loop can easily print the index and it's value;
         */
        for(int i = 0; i< indexnum.Length; i++){
            if(indexnum[i] > 0) Console.WriteLine($"Index {i} : {indexnum[i]}");
        }
    }
}
