using System;

class Program
{
    static void Main(string[] args)
    {
        //OutputInARange();
        //CantRecall(); 
        //CantRecallV2();
        //CalculatorSumSequencePositiveIntegersDave();
        //CalculatorSumSequencePositiveIntegersRon(); //cannot get this to work?
        //OutputEveryOddUpToInputedValueBrandon();
        //OutputEveryOddUpToInputedValueSamantha();
        //PrintIfIntegerDivisibleBy4();
        //PrintARectangle();
        //TeethAaron(); //confusing
        //TeethPhillip(); //confusing
        //TeethDave(); //confusing
        //BusPassengersChante();
        //BankingBrandon(); //writeline should be OUTSIDE for loop
        //BankingRoss();
        //BankingCorey(); //used ternary instead of IF statment to shorten
        //FirstTenMultiplesBrandon(); //stuck with trailing space
        //FirstTenMultiplesRyan();
        //ReverseStringCharacters();
        //ReverseStringCharactersJonathan();
        //SumOfEvenAndOddNumbersJonathan();
        //SumOfEvenAndOddNumbersRyan();
        //MinutesDurationFormattedHHMM();
        //ReturnProductAndSumOfConsIntgs();
        //ReturnProductofStringToIng();
        //RockPaperScissorsBrandon();
        //RockPaperScissorsRon();
        //RockPaperScissorsAaron();


    }

    public static void RockPaperScissorsAaron()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        string call1 = inputs[0];
        string call2 = inputs[1];

        if(call1==call2)
        Console.WriteLine("DRAW");
        else if(call1=="ROCK" && call2=="SCISSORS" || call1=="SCISSORS" && call2=="PAPER" || call1=="PAPER" && call2=="ROCK")
        Console.WriteLine("PLAYER1");
        else 
        Console.WriteLine("PLAYER2");
    }
    public static void RockPaperScissorsRon()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        string call1 = inputs[0];
        string call2 = inputs[1];
        string answer = "";
        if (call1 == call2)
            answer = "DRAW";
        else if (call1 == "PAPER" && call2 == "ROCK")
            answer = "PLAYER1";
        else if (call1 == "SCISSORS" && call2 == "PAPER")
            answer = "PLAYER1";
        else if (call1 == "ROCK" && call2 == "SCISSORS")
            answer = "PLAYER1";
        else
            answer = "PLAYER2";

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(answer);
    }
    public static void RockPaperScissorsBrandon()
    {
        string[] inputs = ["ROCK", "PAPER"]; //Console.ReadLine().Split(' ');
        string call1 = inputs[0]; //PLAYER1
        string call2 = inputs[1]; //PLAYER2

        if (call1 == "ROCK")
                {
                    if (call2 == "ROCK")
                    {
                        Console.WriteLine("DRAW");                     
                    }
                    else if (call2 == "PAPER")
                    {
                        Console.WriteLine("PLAYER2");

                    }
                    else //Scissors
                    {
                        Console.WriteLine("PLAYER1");
                    }

                }

                else if (call1 == "SCISSORS")
                {
                    if (call2 == "ROCK")
                    {
                        Console.WriteLine("PLAYER2");

                    }
                    else if (call2 == "PAPER")
                    {
                        Console.WriteLine("PLAYER1");

                    }
                    else //SCISSORS
                    {
                        Console.WriteLine("DRAW");                
                    }
                }
                else if (call1 == "PAPER")
                {
                    if (call2 == "ROCK")
                    {
                        Console.WriteLine("PLAYER1");

                    }
                    else if (call2 == "PAPER")
                    {
                        Console.WriteLine("DRAW");

                    }
                    else //SCISSORS
                    {
                        Console.WriteLine("PLAYER2");

                    }
                }
    }
    public static void ReturnProductofStringToIng()
    {
        string _num = "4513"; //"23";

        int product = 1;
        foreach(char c in _num)
        {
            product *= c - '0';
        }
        
        Console.WriteLine(product);
    }
    public static void ReturnProductAndSumOfConsIntgs()
    {
        int N = 5;
        long product = 1;
        long sum = 0;

        for(int i = 1; i <= N; i++)
        {
            product *= i;
            sum += i;

        }
    }
    public static void MinutesDurationFormattedHHMM()
    {
        //input
        string duration = "0:06"; // "14:06"; // "1:07"; // "13:05";

        //split hours and minutes apart
        string[] hours = duration.Split(':');

        //take hours and convert to minutes
        double hoursOnly = double.Parse(hours[0]);
        hoursOnly = hoursOnly * 60;

        //sum all minutes
        double minsOnly = double.Parse(hours[1]);
        double total = hoursOnly + minsOnly;

        //print total seconds
        Console.WriteLine(total);
    }
    public static void SumOfEvenAndOddNumbersRyan()
    {
        long n = long.Parse(Console.ReadLine());

        //Track both values
        long even = 0;
        long odd = 0;

        //Run a loop over all numbers. start at 1 (or 0) and go to N.
        for(int i = 0; i <= n; i++)
        {
            //determine if even or odd.
            if(i % 2 == 0)
            {
                even += i;
            }
            else
            {
                odd += i;
            }
        }

        //Print out result.
        Console.WriteLine(odd);
        Console.WriteLine(even);

    }
    public static void SumOfEvenAndOddNumbersJonathan()
    {
        long n = long.Parse(Console.ReadLine());

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        long evenSum = 0;
        long oddSum = 0;
        for(long i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
                evenSum += i;
            else
                oddSum += i;
        }

        Console.WriteLine(oddSum);
        Console.WriteLine(evenSum);
    }
    public static void ReverseStringCharactersJonathan()
    {
        //String coming in
        string S = Console.ReadLine();  

        //String to output
        string R = "";

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Foreach individual character in the string S...
        foreach(char c in S)
        {   
            //Check it's case using Char class static methods...
            if(Char.IsUpper(c)) //If it's uppercase, make it lowercase, add it to R
                R += Char.ToLower(c);
            else
                R += Char.ToUpper(c); //Otherwise, if it's lowercase make it uppercase and add it to R
        }

        Console.WriteLine(R); //return that string used to hold the return
    }
    public static void ReverseStringCharacters()
        {
            
            string S = "AppLe a DaY"; //"heLLo WoRld"; //Console.ReadLine();
            string reverseS = "";

            foreach (var letter in S)
            {
                if (char.ToLower(letter) != letter )
                    reverseS += char.ToLower(letter);
                else
                    reverseS += char.ToUpper(letter);
            }
            Console.WriteLine("Original String: " + S);
            Console.WriteLine("Reversed String: " + reverseS);
        }
    public static void FirstTenMultiplesRyan()
    {
        // The input we need to print out 10 times - for its 10 multiples
        int N = 21; //int.Parse(Console.ReadLine());

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Loop 10 times
        for(int i = 1; i <= 10; i++)
        {
            //Need to not print a last space.
            if(i != 10)
            Console.Write(N*i +  " ");
            else
            Console.Write(N*i);
        }
    }
    public static void FirstTenMultiplesBrandon()
    {
        int N = 21; //int.Parse(Console.ReadLine());
        int num = N;
        for (int i = 1; i < N; i++)
        {
            if (N != 10)
            {
            System.Console.Write(num + " "); //would make a row    
            num += N;
            i++;
            }

            else
            {
            System.Console.Write(num); //would make a row    
            num += N;
            i++;
            }
        }


    }
    public static void BankingCorey()
    //inputs:
    //initial balance *space* how many transactions (this example 100 3)
    //100 3
    //D 150
    //W 75
    //D 50
    //OUTPUT: 225
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int V = int.Parse(inputs[0]);
        int N = int.Parse(inputs[1]);
        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string transaction = inputs[0];
            int amount = int.Parse(inputs[1]);
            V = transaction == "W" ? V -= amount : V += amount;
        }
        Console.WriteLine(V);
    }
    public static void BankingRoss()
    //inputs:
    //initial balance *space* how many transactions (this example 100 3)
    //100 3
    //D 150
    //W 75
    //D 50
    //OUTPUT: 225    
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int V = int.Parse(inputs[0]);
        int N = int.Parse(inputs[1]);
        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string transaction = inputs[0];
            int amount = int.Parse(inputs[1]);
            if(transaction == "W") 
            {
                V -= amount;
            } 
            else 
            {
                V += amount;
            }
        }
        Console.WriteLine(V);
    }
    public static void BankingBrandon()
    //inputs:
    //initial balance *space* how many transactions (this example 100 3)
    //100 3
    //D 150
    //W 75
    //D 50
    //OUTPUT: 225    
    {
         string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int V = int.Parse(inputs[0]); //initial balance
        int N = int.Parse(inputs[1]); //amount of transactions
        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string transaction = inputs[0];
            int amount = int.Parse(inputs[1]);

            if (transaction == "D")
            {
                V += amount;
                Console.WriteLine(V);
            }

            else
            {
                V -= amount;
                Console.WriteLine(V);
            }
        }
    }
    public static void BusPassengersChante()
    {
        int busTotal = 1;
        int n = int.Parse(Console.ReadLine()); //input how many stops
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' '); //input how many get on and how many get off with a space ' ' in between. enter and repeat for #stops
            int getIn = int.Parse(inputs[0]);
            int getOff = int.Parse(inputs[1]);
            busTotal += getIn;
            busTotal -= getOff;
        }

        Console.WriteLine(busTotal);
    }
    public static void TeethDave()
    //You are given a patient. Every patient has a unique amount of teeth. Each tooth is either health (1), rotten (0) or pulled (-). Pull out any rotten teeth you find.
    //Input:
    //Line 1: Integer N for the amount of rows of teeth in a mouth
    //Next N Lines: Rows of Teeth
    //Output:
    //Output the entire mouth of hte patient after you have pulled out all rotten teeth
    //Example: 
    // Input: 2 Rows
    // Input Row 1:  ---------1-----
    // Output Row 1: ---------1----- (no rotten teeth to pull so expected to appear same)
    // Input Row 2:  -------0-----
    // Output Row 2: ------------- (See it replaced the rotten tooth 0 with a pulled tooth -)
    //NOTE* when exectuting code, initial input is amount of rows (commonly 2 as we normally have 2 rows of teeth). Second Input is a series of -/1/0 to make the mouth. should then output any 0 with -. next input is second row so 0/1/- and same output expectations.
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string ROW = Console.ReadLine();

            for (int a = 0; a < ROW.Length; a++)
            {

                if (ROW[a] == '0')
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(ROW[a]);
                }

            }
            Console.WriteLine();
        }
    }
    public static void TeethPhillip()
    //You are given a patient. Every patient has a unique amount of teeth. Each tooth is either health (1), rotten (0) or pulled (-). Pull out any rotten teeth you find.
    //Input:
    //Line 1: Integer N for the amount of rows of teeth in a mouth
    //Next N Lines: Rows of Teeth
    //Output:
    //Output the entire mouth of hte patient after you have pulled out all rotten teeth
    //Example: 
    // Input: 2 Rows
    // Input Row 1:  ---------1-----
    // Output Row 1: ---------1----- (no rotten teeth to pull so expected to appear same)
    // Input Row 2:  -------0-----
    // Output Row 2: ------------- (See it replaced the rotten tooth 0 with a pulled tooth -)
    //NOTE* when exectuting code, initial input is amount of rows (commonly 2 as we normally have 2 rows of teeth). Second Input is a series of -/1/0 to make the mouth. should then output any 0 with -. next input is second row so 0/1/- and same output expectations.
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string ROW = Console.ReadLine();

            string cleanedRow = ROW.Replace("0", "-");

            Console.WriteLine(cleanedRow);
        }
    }
    public static void TeethAaron()
    //You are given a patient. Every patient has a unique amount of teeth. Each tooth is either health (1), rotten (0) or pulled (-). Pull out any rotten teeth you find.
    //Input:
    //Line 1: Integer N for the amount of rows of teeth in a mouth
    //Next N Lines: Rows of Teeth
    //Output:
    //Output the entire mouth of hte patient after you have pulled out all rotten teeth
    //Example: 
    // Input: 2 Rows
    // Input Row 1:  ---------1-----
    // Output Row 1: ---------1----- (no rotten teeth to pull so expected to appear same)
    // Input Row 2:  -------0-----
    // Output Row 2: ------------- (See it replaced the rotten tooth 0 with a pulled tooth -)
    //NOTE* when exectuting code, initial input is amount of rows (commonly 2 as we normally have 2 rows of teeth). Second Input is a series of -/1/0 to make the mouth. should then output any 0 with -. next input is second row so 0/1/- and same output expectations.
    {
        int N = int.Parse(Console.ReadLine());
        string mouth = "";
        for (int i = 0; i < N; i++)
        {
            string ROW = Console.ReadLine();
            //int.Parse(ROW);
            foreach (char c in ROW)
            //for(int j = 0; j< ROW.Count(); j++)
            {
                if (c == '0')
                {
                    mouth += "-";
                }
                else if (c == '1')
                {
                    mouth += "1";
                }
                else
                {
                    mouth += "-";
                }
            }
            Console.WriteLine(mouth);
            mouth = "";

        }
    }
    public static void PrintARectangle()
    {
        //Create a rectangle based on the specific heigh and width parameters. Use the letter "O" (Case-Sensitive) as the character making up the rectanging
        //Input:
        //Line 1: The height of the rectangle
        //Line 2: The width of the rectangle
        //Output: 
        //A string that displays a rectangle
        //Example: 
        //Input: 2x2 Square
        //Output:
        // OO
        // OO

        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("O");
            }
            Console.WriteLine();
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
    }
    public static void PrintIfIntegerDivisibleBy4()
    {
        ulong N = ulong.Parse(Console.ReadLine());

        {
            if (N % 4 != 0)
            {
                Console.WriteLine("Ok");
            }

            else
            {
                Console.WriteLine("AAAAAAAAAA!!!");
            }
        }
    }
    public static void OutputEveryOddUpToInputedValueSamantha()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i += 2)
        {
            Console.WriteLine(i);
        }
    }
    public static void OutputEveryOddUpToInputedValueBrandon()
    {
        int N = int.Parse(Console.ReadLine());
        for (int n = 1; n < (N + 1); n++)
        {
            if (n % 2 != 0) // Checking if the number is odd by using the modulo operator
            {
                Console.WriteLine(n); // Printing the odd number
            }
        }

    }
    public static void CalculatorSumSequencePositiveIntegersRon()
    {
        int count = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int p = 0;
        for (int i = 0; i < count; i++)
        {
            string unary = inputs[i];
            p += unary.Length;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for (int j = 0; j < p; j++)
        {
            Console.Write('1');
        }
    }
    public static void CalculatorSumSequencePositiveIntegersDave()
    {
        string output = "";
        int count = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < count; i++)
        {
            string unary = inputs[i];
            output += unary;
        }
        Console.WriteLine(output);
    }
    public static void CantRecallV2()
    {
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                n = n * 2;
            }
            else
            {
                n = n * 3;
            }
            Console.WriteLine(n);
        }
    }
    public static void CantRecall()
    {
        //cant recall exact challenge details

        int[] numbers = [1, 2, 3, 5, 7, 10];
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num * 2);
            }
            else
            {
                Console.WriteLine(num * 3);
            }
        }
    }
    public static void OutputInARange()
    {
        //Output the (signed) size of the range [N, 1000-N]
        //Input - the Integer N
        //Output - one integer
        //Constraints - 0 <= N <= 1000
        //Example: Input 15 | Output 970

        System.Console.WriteLine("---Start OutputInARange---");

        System.Console.Write("Input: "); //fluff for Terminal readability
        int n = int.Parse(Console.ReadLine());
        System.Console.Write("Output: "); //fluff for Terminal readability
        System.Console.WriteLine(1000 - n - n); //shortened (1000 - (n*2)

        System.Console.WriteLine("---End OutputInARange---");
    }
}