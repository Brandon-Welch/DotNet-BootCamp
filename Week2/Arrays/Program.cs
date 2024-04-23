//Arrays

/*
-Problem: There is a lot of DATA that exists!!!
-Managing each piece in its own variable is going to become impractical/borderline impossible.
-A lot of this data is quite similiar or related, whether its by purpose or even data type

-We need to introduce means to store multiplepieces of data within one device/variable.

-Arrays offer a way for us to very simply store multiple values of the same data type

-Arrays (in C# and maybe Java) have a fixed size upon instantiation (initalization).
-Arrays use indexes (just like strings) - an Array of size 5 would have indexes 0-4

-Syntax:
    DataType[] variableName = new DataType[size];

*/

//Basic Example
using System.Threading.Tasks.Dataflow;

System.Console.WriteLine("-----Basic Example------");
int[] numbers = new int[5]; //this is NOT an integer, it is an Array that can hold 5 ints
System.Console.WriteLine(numbers.Length);

//Assign a value to any *element* of this array
numbers[0] = 10; //assigns value 10 to the 0th index
numbers[1] = 11;
numbers[2] = 12;

//Recall/use said value stored inside any *element* of this array
System.Console.WriteLine("-----Recall Example------");
System.Console.WriteLine(numbers[0]);
System.Console.WriteLine(numbers[1]);
System.Console.WriteLine(numbers[4]);
//System.Console.WriteLine(numbers[10]); //IndexOutOfRangeException - acceptable indexes for this array are 0-4
//System.Console.WriteLine(numbers[-1]); //Cannot use negative indices (in C#)
//System.Console.WriteLine(numbers); //returns "System.Int32[]"

//Foreach Loop
System.Console.WriteLine("-----Foreach Example------");
string arrString = "[";
foreach(int num in numbers)
{
    arrString += num + ","; //concatenate
}
arrString = arrString.Remove(arrString.Length - 1); //-1 removes the last string which in this example actually removed the last , we didnt need
arrString += "]";
System.Console.WriteLine(arrString);

//string result = string.Join (", ", Array.ConvertAll(numbers, x => x.ToString))
//---------
System.Console.WriteLine("--another way to do it---");
string[] numberStrings = new string[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{   
    numberStrings[i] = numbers[i].ToString();
}
System.Console.WriteLine(string.Join(",", numberStrings));

//---------
System.Console.WriteLine("--simplified but not ideal---");
foreach (int num in numbers)
{
    System.Console.Write(num + " ");
}
System.Console.WriteLine(); //simple line break

//Even less Important
//Multi-dimensional Arrays
//Syntax:
int[,] twoDimArray = new int[3,3];

twoDimArray[0,0] = 1;
twoDimArray[0,1] = 2;

//----------back to reality

//Alternative syntax for instantiating Arrays
System.Console.WriteLine("--Alt Example---");
string[] words = ["Hello", "Hi", "Hey"]; //provided 3 values, so the size of the array is interpretted as 3 ****CAN USE =[] OR ={}
System.Console.WriteLine(words[2]);
System.Console.WriteLine(words[1]);
words [1] = "Bye"; //can reassign the value set above
System.Console.WriteLine(words[1]);