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

                -convert helpbot into numerical options instead of word options
                

*/




/*
//Attempt with help of CoPilot that allows user to play again. I GIVE UP!!!!!!!!!!!!!
System.Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
int answer = 48; // Generate a random number between 1 and 100

while (playAgain == "Yes")
{
    while (true)
    {
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
    string playAgain = Console.ReadLine();
}

System.Console.WriteLine("Thanks for playing");
*/
//-------------------------------------------------------------------------------------------------------------------------
// /*
//Attempt with help of CoPilot that funcitons as expected.
System.Console.WriteLine("\nHello, welcome to the Guessing Game! Please guess a number between 1-100."); // \n in front to create a blank line between the prompt and the program
int answer = 48; // Generate a random number between 1 and 100

while (true)
{
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
// */
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
