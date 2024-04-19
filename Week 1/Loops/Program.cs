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
