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