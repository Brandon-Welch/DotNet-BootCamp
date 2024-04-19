/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts to further gain control over what will or will not happen within the program and/or how often.
    -Condition -> Boolean Expression -> Any statement that evaluates true/false
        -Examples:
            -true
            -false
            -boolean variable
            -expression: numberOfBooks > 5

Conditional Statement - evaluates a Condition to simply determine if a chunk of code is/is not executed
    -If statement
        -If-Else Statements
        -If-Elseif-Else Statements
    -Ternary Operators
    -Switch-Case Statements

*/

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

bool isRainy = false;


if (isRainy) 
    {
        System.Console.WriteLine("It is Rainy outside!");
    }


//Quick Detour - Console Input - > Console.ReadLine();
System.Console.WriteLine("Please enter your favorite number: ");
string? input = Console.ReadLine(); //question mark removes the yellow debug note in the terminal output
System.Console.WriteLine("Your favorite number is: " + input);

//Converting Data Types
//int number = int.Parse(input);

int number = 0; //we need to create the number variable outside of the IF statment for its scope to stretch beyond just that IF block (block being anythign inside curly brackets)
if (input != null)
    {
        number = int.Parse(input);
    }

else
    {
           System.Console.WriteLine("You failed to enter only digits, you suck.");     
           number = -1;
    }

if (number > 10)
    {
        System.Console.WriteLine("Your favorite number is greater than 10!");
    }

else
    {
        if (number == 10)
            {
                System.Console.WriteLine("Your favorite number is exactly than 10!");
            }
        
        else
            {
                System.Console.WriteLine("Your favorite number is not greater than 10!");
            }
    }

//Alternative Method to (most) nested conditionals
//If-ElseIf-Else Statements

if (number > 10)
{
    System.Console.WriteLine(">10 yay!");
}
else if (number > 5)
{
    System.Console.WriteLine("5<your number<=10 ............ yay.....");
}
else
{
    System.Console.WriteLine("<=5......whatever...");
}

/*
try
    {
        int number = int.Parse(input);
    }
catch (System.Exception e)
{
    System.Console.WriteLine("Whoops, not a number");
    throw;
}
*/


//Ternary Operators
//It is an Alternative to simple If-Else statements where the tasks/outcomes are very similiar.
// Syntax: (condition) ? <option if true> : <option if false>

if (number > 10)
    {
        System.Console.WriteLine("Your number is greater than 10");
    }
else
    {
        System.Console.WriteLine("Your number is not greater than 10");
    }

    //example of ternary comparerd to if
string phrase = "Your number is " + ((number > 10) ? "greater than 10." : "not greater than 10.");
System.Console.WriteLine(phrase);


//Switch-Case Statements
//are best used when the options we want to consider are particular, finite, and/or incremental

/*
switch (variable)
{
    case(value1): 
        {
            //some code to execute if variable == value1
        }

    case(value2):
        {
            //some code to execute if variable == value1
        }
    case(value3):
    case(value4):
        {
            //some code to execute if variable == value3 OR value4
        }
    default:
        {
            //some code to execute if variable != to any other case*
        }
}

*/
//------------------
System.Console.WriteLine("Enter an option 1-4:");
input = Console.ReadLine();
int option = 0;

if (input != null) option = int.Parse(input);

switch (option)
{
    case 1:
    {
        System.Console.WriteLine("You have chosen Option 1. You win $1");
        break;
    }
    case 2: 
    {
        System.Console.WriteLine("You have chosen Option 2. You win $2.");
        break;
    }
    case 3:
    case 4:
    {
        System.Console.WriteLine("You have chosen Option 3 or 4. You win the game.");
        break;
    }
    default:
        System.Console.WriteLine("You did not choose a valid option (1-4). Please try again");
        break;
}



//Loops