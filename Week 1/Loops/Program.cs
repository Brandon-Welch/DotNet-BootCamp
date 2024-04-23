/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts to further gain control over what will or will not happen within the program and/or how often.
    Loops - allow us to execute a chunk of code for as long as the condition continues to be true.
        -The condition is reassessed after each 'iteration' of the loop, before executing the loop again.

        -While Loop
            -Do-While Loop
                -Best used when the number of iterations needed by the loop is not know / non-deterministic
            -For Loop
                -For each Loop
                -Best used when the number of iterations needed by the loop is known / calculable. Finite

*/

// Print the numbers 1-100

//old/bad way
/*
int counter = 1;
System.Console.WriteLine(counter);
counter = counter + 1; //short cut -> counter += 1; -shortcut > coutner==;
System.Console.WriteLine(counter);
counter++;
System.Console.WriteLine(counter );
*/

using System.Security.Cryptography;
using System.Xml.XPath;

int counter = 1;
/*
white (condition)
{
    //code to execute while condition is true.
}
*/

while (counter <=10)
    {
        System.Console.WriteLine(counter);
        counter++;
    }

System.Console.WriteLine("End of Program");

// Print the sum of the numbers 1-10
counter = 1;
int end = 1000;
int sum = 0;

while (counter <= end)
{
    sum = sum + counter; // shorthand-> sum += counter;
    counter++;
}
System.Console.WriteLine("The sum of the numbers 1-" + end + " is: " + sum);

//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------

// Input Validation

// Tell the user to print out the number: 5
int num = 0;

System.Console.WriteLine("\nPlease input the number: 5");

while (num != 5)
{
//    System.Console.WriteLine("\nPlease input the number: 5");
    string? input = Console.ReadLine();    

    if (input !=null) num = int.Parse(input);

        if (num != 5)
        {
            System.Console.WriteLine("Please try entering the number 5 again!");
        }
}

//Outside of the while loop down here, is for when the loop is done (they finally inputted the correct value)
System.Console.WriteLine("Thanks, you entered: " + num + ".\n");
System.Console.WriteLine("-----------------------------------");

//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------
//Do-While
//Do-While Loops, as opposed to just While Loops, will always execute AT LEAST ONCE before executing

/*
do
{
    /whatever we want the loop to do
}

while (condition);
*/

//Rebranding the last example into a do-while loop
// Tell the user to print out the number: 5
System.Console.WriteLine("\n Do -> Please enter the number: 5");

do
{
    while (num != 5)
    {
    //    System.Console.WriteLine("\nPlease input the number: 5");
        string? input = Console.ReadLine();    

        if (input !=null) num = int.Parse(input);

            if (num != 5)
            {
                System.Console.WriteLine("Do -> Please try entering the number 5 again!");
            }
    }
}

while (num !=5);
System.Console.WriteLine("Do -> Thanks, you correctly entered: " + num + ".\n");
System.Console.WriteLine("-----------------------------------");

//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------

//For Loops

//Best used when the number of iterations is known / calculable. 
/*

for (initialization; condition; update) //described initial state of a variable we want to use; what the loop will use if we are going to run again; change we would make before we check if condition is true again
{

}

*/

//print the numbers 1-10
for (int count = 1; count <= 10; count++)
{
    System.Console.WriteLine(count);
}
System.Console.WriteLine("-----------------------------------");

//print the sum of the numbers 1-10000
int sum2 = 0;
for (int count = 1; count <= 10000; count++)
{
    sum2 += count;
}
System.Console.WriteLine(sum2);
System.Console.WriteLine("-----------------------------------");

//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------

//sample:
//Print only even numbers 2-200 (+2)

for (int count = 2; count <= 200; count+=2)
{
    System.Console.WriteLine(count);
}
System.Console.WriteLine("-----------------------------------");
//Print all numbers starting with 50 going to 25 (decremental --)
for (int count = 50; count >= 25; count--)
{
    System.Console.WriteLine(count);
}
System.Console.WriteLine("-----------------------------------");

//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------

//Nesting Loops
/*
    -Any control flow can be coded / nested into any other control flow
        -Therefore Loops can be built inside of other loops
        -However, we should exercise caution, we could potentially develop scenarios that will drastically increase processing time
    -Problem:
        -Single Loop -> 100 iterations => 100 Processes
        -Nested Loop -> 100 iterations inside 100 iterations => 10,000 Processes
        -Quadratic Growth of time
*/

// Build a Square out of '*' of whatever size we want
int size = 8;

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size; j++)
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write("* "); //would make a row    
    }
    
    System.Console.WriteLine(); //to generate the column
}
System.Console.WriteLine("-----------------------------------");

//Staircase Challenege
//Print 1 '*' for first row, then 2 '*' for second row, etc ending a 5 '*' row

//the OUTER loop deals with printing additional rows/"steps"
//the INNER loops deals with printing the contents of each row/"step"
size = 5;

for (int i = 1; i <= size; i++) //OUTER LOOP
{
    for (int j = 1; j <= i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write("* "); //would make a row    
    }
    
    System.Console.WriteLine(); //to generate the column
}
System.Console.WriteLine("-----------------------------------");


//Foreach Loop
//Best used when iterating (once) over each item of a collection of values.

//Before foreach
string word = "Hello";
for(int i = 0; i < word.Length; i++) //use less than instead of lessthan OR equal too since index starts at 0 and for a word with 5 letters, 0-4 is used
{
    System.Console.WriteLine(word[i]);
}
System.Console.WriteLine("-----------------------------------");

//After Foreach Loop
foreach (char letter in word)
{
    System.Console.WriteLine(letter);
}
System.Console.WriteLine("-----------------------------------");
//----------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------

//Exercise: Staircase Challenege Continued
//Alreadt printed going down... now Print going up, and then invert both
//for most part, will be manipulation of the INNER loop

/*

*
**
***
****
*****
*/

System.Console.WriteLine("-------------Left Facing---------------");
size = 5;

for (int i = 1; i <= size; i++) //OUTER LOOP
{
    for (int j = 1; j <= i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write("*"); //would make a row    
    }
    
    System.Console.WriteLine(); //to generate the column
}
System.Console.WriteLine("-----------------------------------");

/*
    *
   **
  ***
 ****
*****
*/
System.Console.WriteLine("-------------Right Facing---------------");

size = 5;

for (int i = 1; i <= size; i++) //OUTER LOOP
{
    for (int j = 1; j <= size - i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write(" ");
    }

    for (int j = 1; j <= i; j++) //INNER LOOP
    {       
        System.Console.Write("*");
    }
    
    System.Console.WriteLine();
    //System.Console.Write(" ");
}
System.Console.WriteLine("-----------------------------------");


/*
*****
****
***
**
*
*/
System.Console.WriteLine("-------------Inverted Left Facing---------------");
size = 5;

for (int i = size; i >= 1; i--) //OUTER LOOP
{
    for (int j = 1; j <= i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write("*"); //would make a row    
    }
    
    System.Console.WriteLine(); //to generate the column
}
System.Console.WriteLine("-----------------------------------");


/*
*****
 ****
  ***
   **
    *
*/
System.Console.WriteLine("-------------Inverted Right Facing---------------");
size = 5;

for (int i = size; i >= 1; i--) //OUTER LOOP
{
    for (int j = 1; j <= size - i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write(" ");
    }

    for (int j = 1; j <= i; j++) //INNER LOOP
    {       
        System.Console.Write("*");
    }
    
    System.Console.WriteLine();
    //System.Console.Write(" ");
}
System.Console.WriteLine("-----------------------------------");


//-BONUS: Solve with a SINGLE loop
System.Console.WriteLine("-------------Single Loop Left Facing---------------");
size = 5; // Adjust the size of the staircase as needed

    for (int i = 1; i <= size; i++)
    {
        string row = new string('*', i).PadRight(size);
        Console.WriteLine(row);
    }
System.Console.WriteLine("-----------------------------------");


System.Console.WriteLine("-------------Single Loop Right Facing---------------");
size = 5; // Adjust the size of the staircase as needed

    for (int i = 1; i <= size; i++)
    {
        string row = new string('*', i).PadLeft(size);
        Console.WriteLine(row);
    }
System.Console.WriteLine("-----------------------------------");


System.Console.WriteLine("-------------Single Loop Inverted Left Facing---------------");
size = 5; // Adjust the size of the staircase as needed

    for (int i = size; i >= 1; i--)
    {
        string row = new string('*', i).PadRight(size);
        Console.WriteLine(row);
    }
System.Console.WriteLine("-----------------------------------");


System.Console.WriteLine("-------------Single Loop Inverted Right Facing---------------");
size = 5; // Adjust the size of the staircase as needed

    for (int i = size; i >= 1; i--)
    {
        string row = new string('*', i).PadLeft(size);
        Console.WriteLine(row);
    }
System.Console.WriteLine("-----------------------------------");














/*
//-------------------------------
//---------------------------
//Random Find - Makes a triangle
size = 5;

for (int i = 1; i <= size; i++) //OUTER LOOP
{
    for (int j = 1; j <= size - i; j++) //INNER LOOP
    {
        //System.Console.WriteLine("*"); //would make a column, need rows
        System.Console.Write(" ");
    }

    for (int j = 1; j <= i; j++) //INNER LOOP
    {       
        System.Console.Write("*");
    }
    
    System.Console.WriteLine();
    //System.Console.Write(" ");
}
System.Console.WriteLine("-----------------------------------");
*/