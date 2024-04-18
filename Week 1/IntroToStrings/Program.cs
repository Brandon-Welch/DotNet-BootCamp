using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!"); // "Hello World!" is a String Literal with a dataType 'String'

/* 
Strings   - A sequence of characters (letters, numbers, symbols and whitespaces) all put together 
           - represented with "double quotes" in C# for String Literals
           - Reference types (aka an Object data type)
              -Objects have more capabilities than just storing a value
              -Objects can also have methods to perform various funcitonality (potentially upon some stored value(s))
              -Example: Car object
                  - States - Fields - properties (variables - pieces of data about said object)
                      -Color
                      -Make
                      -Model
                      -Year
                      -VIN
                      -numberOfTires
                      -Horsepower
                      -Mileage
                  - Behaviors - Methods - functionality we wish to perform with our Object (Methods use PascalCasing)
                      -Drive
                      -Park
                      -TurnOnRadio
                      -RollDownWindows
                      -Reverse
                      -TurnOnWipers
                      -TurnOnHeadlights
*/

//Create a String variable
string word = "Hello";
System.Console.WriteLine(word);

//To access fields and methods from obnject we create and use the dot "." (member access) operator

System.Console.WriteLine(word.Length);

word = "Hi!";
System.Console.WriteLine(word.Length);

System.Console.WriteLine(word.ToUpper()); //Without () in this method will not run... it has to have the () to envoke/call the method/function
System.Console.WriteLine(word.ToLower());
// (), [], {}
// ToUpper();
// WriteLine(word); // Argument
// When definding a Method: referred to as the Method's Parameters

word = "Hello World!";
System.Console.WriteLine(word.Substring(6));
System.Console.WriteLine(word.Substring(6,2));

/*
Indexes - Strings and other various collection-basd devices use Indec
    Describe the position of htat element with the entir set of data.
    Strings -> the position of that Character within the entire String.

    Indexes (in MOST programming languages) are 0-indexed.
        Means 1st Character in the String starts at the index 0.
        The Last Index of any String is: Length - 1
*/

//String Concatenation
// When using the "+" sign with Strings the behavior changes awar from (mathematical) addition.
// Concatenation - the combining of two or more strings in which we  conjoin all the characters into one new string.

string phrase = "Hello " + "World!";
System.Console.WriteLine(phrase);

string fname = "Brandon";
string lname = "Welch";
System.Console.WriteLine("Hello, My Name is: " + fname + lname); //no space between names
System.Console.WriteLine("Hello, My Name is: " + fname + " " + lname); //fixes no space between names

int num1 = 1;
int num2 = 2;
System.Console.WriteLine("Num1 = " + num1);
System.Console.WriteLine("Num2 = " + num2);

// value-types -> == measures if they have the same value
System.Console.WriteLine(num1 == 1); // checks if num1 = 1 - true/false

// reference-types - Objects -> == this will check if they are the SAME Object in memory (are they located at the same location in memory)
Object obj1 = new Object();
Object obj2 = new Object();

System.Console.WriteLine(obj1 == obj2);

string word1 = "Hello";
string word2 = "Hello";
System.Console.WriteLine(word1 == word2);

//strings utilixe what is calledd the String Pool
//Strings that are assigned the same value will point the same locaion in memory
//This is done to conserve on Memory for Strings.