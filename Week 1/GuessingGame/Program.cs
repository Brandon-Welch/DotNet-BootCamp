/*

Guessing Game - Make a New Project to work on this:
    Needs to:
        -Start with assumed range of numbers 1-100
        -Prompt user to enter a number in said range
        -Tell the user if the number is higher, lower, or equal to <some number of your choice>
            -if equal - win guessing game
            -if higher or lower, let them guess again
                -best solved with while loops
                -the while loop essentially needs to contain
                    -prompting the user
                    -retreiving their guess
                    -telling them higher/lower/equal
                        -while (guess != correctChoice) -> run the loop again
        Bonuses:
            -Introduce yourself to Random class, to helpo you randomize the correct answer
            -the user is prompted to play again? without having to restart the entire application
                -hint - likely will involved another (outer) while look

        Bonus Bonus:
            -adjust the range in which you tell the user to guess on their previous wrong answer.
                -example, if they pick 40 and its wrong, the response would tell then its low, pick a number between 40-100
                -Allow the user to pick the numbers that they will guess betwwen when the game starts (let user pick x-xxx)
                -keep track of number of guesses and return the # when the correct answer is selected (you got it right... AND it took you XXX guesses)
                
                -convert helpbot into numerical options instead of word options
                

*/


/*
//Attempt with help of CoPilot that allows user to play again. Took their example from  "c# using 2 while loops and abilite to answer yes or no question in outer loop > use if statement instead of switch

    //Console.Clear(); //<<<<<<<<<<<<<<<<<<<<Add back after it works>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    System.Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
    Console.Write("\tYour guess is: ");
    int answer = 48; // Generate a random number between 1 and 100
    
    bool playAgain = true;

while (playAgain)
{
    Console.Write("\tYour guess is: ");
    string guess = Console.ReadLine();

    if (int.TryParse(guess, out int guessInt))
    {
        if (guessInt == answer)
        {
            System.Console.WriteLine("The correct answer was " + answer + "! Congrats! You won the guessing game!");
            break; // without this, it will never exit the loop and will continue to accept inputs from user.
        }
        
        else if (guessInt > answer)
        {
            System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is higher than the correct answer.");
        }
        else
            {
                System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is lower than the correct answer.");
            }
    }
    else
        {
            System.Console.WriteLine("You entered a value that was not a number. Please enter a valid number between 1-100.");
        }
}


    System.Console.WriteLine("\nDo you want to play again?");
    string again = Console.ReadLine();

    if (again.Equals("No", StringComparison.OrdinalIgnoreCase))
    {
        System.Console.WriteLine("Thanks for Playing!\n");
        playAgain = false;
    }

*/
//------------------------------------------------------------------------------------------------------------------------------
/*
//Attempt with help of CoPilot that allows user to play again. I GIVE UP!!!!!!!!!!!!!
//Console.Clear(); <<<<<<<<<<<<<<<<<<<<Add back after it works>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
System.Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
int answer = 48; // Generate a random number between 1 and 100
bool playAgain = true;

while (playAgain)
//while (true)
{
    string again = "Yes";
        
        if (again == "Yes")
            {
                    while (true)
                    {
                        Console.Write("\tYour guess is: ");
                        string guess = Console.ReadLine();

                        if (int.TryParse(guess, out int guessInt))
                            {
                                if (guessInt == answer)
                                    {
                                        System.Console.WriteLine("The correct answer was " + answer + "! Congrats! You won the guessing game!");
                                        break; // without this, it will never exit the loop and will continue to accept inputs from user.
                                    }
                                else if (guessInt > answer)
                                    {
                                        System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is higher than the correct answer.");
                                    }
                                else
                                    {
                                        System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is lower than the correct answer.");
                                    }
                            }
                        else
                            {
                                System.Console.WriteLine("You entered a value that was not a number. Please enter a valid number between 1-100.");
                            }
                    }
            }
        else
            {
                System.Console.WriteLine("Thanks for playing!!!");
                break;
            }

    System.Console.WriteLine("\nDo you want to play again?");
    again = Console.ReadLine();

}

System.Console.WriteLine("Thanks for playing");
*/
//-------------------------------------------------------------------------------------------------------------------------
 /*
//Attempt with help of CoPilot that funcitons as expected.

System.Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
//int answer = 48; // Generate a random number between 1 and 100 - original answer that works... used copilot for help on Random number generation
Random rnd = new Random ();
int answer = rnd.Next(1, 101); //The Next(minValue, maxValue) method generates a random integer within the specified range. In this case, it produces a number between 1 and 100 (inclusive).

while (true)
{
    Console.Write("\tYour guess is: ");
    string guess = Console.ReadLine();

    if (int.TryParse(guess, out int guessInt)) 
        {
            if (guessInt == answer)
                {
                    System.Console.WriteLine("The correct answer was " + answer + "! Congrats! You won the guessing game!");
                    break; // without this, it will never exit the loop and will continue to accept inputs from user.
                }
            else if (guessInt > answer)
                {
                    System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is higher than the correct answer.");
                }
            else
                {
                    System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is lower than the correct answer.");
                }
        }
    else
        {
            System.Console.WriteLine("You entered a value that was not a number. Please enter a valid number between 1-100.");
        }
}

System.Console.WriteLine("Thanks for playing!");
 */
//-------------------------------------------------------------------------------------------------------------------------
/* 
//First Attempt - after research, need the WHILE loop to contain the IF... not If containing WHILE
Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
string guess = Console.ReadLine();
int guessString = int.Parse(guess);
int answer = 48;

//if (answer != null) guess = int.Parse(answer);
if (guessString == answer)
    {
        System.Console.WriteLine("The correct answer was: " + answer + ". Congrats! You won the guessing game!");
    }
else // (guess != answer)
    {
        while (guessString != answer)
        {
            if (guessString > answer)
                {
                    System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is higher than the correct answer.");
                    System.Console.WriteLine("Please guess a different number between 1-100.");
                    guess = Console.ReadLine();
                }
             else
                {
                    System.Console.WriteLine("Sorry, Please try again. Your guess of " + guess + " is lower than the correct answer.");
                    System.Console.WriteLine("Please guess a different number between 1-100.");
                    guess = Console.ReadLine();
                }           
            //how to let them guess again?
            //System.Console.WriteLine("Please guess a different number between 1-100.");
            //guess = Console.ReadLine();

        }
       System.Console.WriteLine("Thanks for playing!");
    }
*/



// Ryans Solution:

bool again = true;

while (again)
{
    //The entire game starts here
    Random random = new Random();
    int correctNum = random.Next(1, 101);
    int guess = 0;
    string? input;

    while (guess != correctNum)
    {
        System.Console.WriteLine("Please enter a number between 1-100: ");
        input = Console.ReadLine();
        if (input != null) guess = int.Parse(input);
        // guess = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing Operator

        if (guess > correctNum)
        {
            System.Console.WriteLine("Your guess was Too High!");
        }
        else if (guess < correctNum)
        {
            System.Console.WriteLine("Your guess was Too Low!");
        }
    }

    System.Console.WriteLine("Your guess was correct! The number was: " + correctNum);
    //The entire game ends here

    System.Console.WriteLine("Would you like to play again? (Y) or (N)?");
    input = Console.ReadLine();

    if (!"Y".Equals(input))
    {
        again = false;
    }
}

System.Console.WriteLine("Thanks for Playing! Goodbye!");


