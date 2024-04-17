// See https://aka.ms/new-console-template for more information

//This is your go-to line of code for Printing to the Console.
Console.WriteLine("Hello, World!");

//Variables should be camelCasing
int numberOfBooks;

//Variable Assignment
//Syntax: variableName = some-value;
numberOfBooks = 10;
numberOfBooks = 11; //Reassignment
Console.WriteLine(numberOfBooks);
Console.WriteLine(10);

//Variable Declaration and Assignment
double money = 2.5;
System.Console.WriteLine(money); //cw -shortcut, dont stress on the System. addition

// = -> Assignment Operator

//Basic Operations
int num = 1 + 2;
num = 1 - 2;
num = 1 * 3;
num = 1 / 3; // Integer Division - will only produce a while number (in this case 0 since this would result in 0.33333333)
double num2= 1 / 3.0; // so you can get the decimal to return
//num = 1 % 3; // Modulus

System.Console.WriteLine(num);
System.Console.WriteLine(num2);

// Aygmented (Compound) Assignment Operators

//What if I want to perform a calculation on a variable AND store that result back into the variable
int num3 = 10;
//num3 * 3; // Wont work
//int result = num3 * 3; //Alt Method
num3 = num3 * 3; // Preferred method ... right side runs calculation and assigns back to num3

//System.Console.WriteLine(result);
System.Console.WriteLine(num3);

//Augmented Assignment Operator
num3 =+ 5; // exactly same as avove: num3 = num3 = 5;
num3 -= 5;
num3 *= 5; 
num3 /= 5;
num3 %= 5; 

System.Console.WriteLine(num3);

// Increment / Decrement Operators
num3++; //Increment - Add Exactly 1   -> Shorthand for num3 += 1;   -> Shorthand for num3 = num3 + 1;
num3--; //Decrement - Subtract Exactly 1

++num3;
--num3;

System.Console.WriteLine(num3);

System.Console.WriteLine(num3++); // Post-Increment (Will increment AFTER the variable is used)
System.Console.WriteLine(num3);
System.Console.WriteLine(++num3); // Pre-Increment (Will increment BEFORE the variable is used)

// Booleans - valute type that stores either 'true' or 'false'

bool isSunny = true;
bool isRainy = false;

System.Console.WriteLine(isSunny);
System.Console.WriteLine(isRainy);

// ! -> null/Negation Operator -> change boolean into its 'opposite' value

System.Console.WriteLine(!isSunny);

isSunny = !isSunny; // A toggle -> switch boolean value to the over boolean value True>False or False>True
System.Console.WriteLine(isSunny);

// Relational Operators - compare one value to another value

// == Equality operator -> checks if the 2 values equal each other
// != Not Equals
// < Greater Than
// > Less Than
// <= Greater Than OR Equal To
// >= Less Than OR Equal To

System.Console.WriteLine(5 == 5); // the 5 == 5 is a Boolean Expression that evalues to true/false
System.Console.WriteLine(numberOfBooks == 5); //number of books DOES NOT equal 5 currently so will return FALSE
System.Console.WriteLine(numberOfBooks != 5); //could use any other relational operator above.... in this case, DOES #books NOT EQUAL 5? TRUE
System.Console.WriteLine(numberOfBooks == num3);