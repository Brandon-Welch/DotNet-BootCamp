/*
Steve and Tommy are playing a game where they take rocks out of a bag. The bag has a certain number of rocks, and each child can take a certain number of rocks out of the bag. Steve will always go first and then the two children take turns taking rocks out of the bag. It is your job to figure out which child will empty the bag (reduce the number of rocks in the bag to 0), and how many rocks that same child has taken total.

The rockGame() method takes in 3 arguments in this order:
b - the total number of rocks in the bag, this will be between 0-1000
s - the number of rocks Steve will take out every turn, this will be between 0-1000
t - the number of rocks Tommy will take out every turn, this will be between 0-1000
After figuring out who empties the bag, you are required to return the total number of rocks that the child who went has total.
 
 
Example Input:	Example Output:
9
2
3	5
Explanation:
First turn Steve takes out 2 rocks and Tommy takes out 3 rocks, leaving 4 left in the bag.
Second turn Steve takes out 2 rocks and Tommy goes to take out 3 rocks, but since there are only 2 left he only takes 2, emptying the bag.
Since Tommy emptied the bag to 0 rocks, the resulting number of rocks he has total is 5.
Skill: Language - Fundamentals II
*/

using System;

public class Test
{

    ///*-----Start of BrandonRockGame
            public static int BrandonRockGame(int b, int s, int t)

            {
                //int b min = 0; 

                //int b max = 1000;

                int steveTotal = 0;

                int tammyTotal = 0;


                while (b > 0)

                {
                    if (s > t) //steve always goes first should be higher? 
                    {
                        steveTotal = steveTotal + s;
                        b = b - s;
                    }
                    else //(t > s)
                    {
                        tammyTotal = tammyTotal + t;
                        b = b - t;
                    }
                }

                if (steveTotal > tammyTotal)
                {
                    //Console.Writeline(steveTotal);
                    return steveTotal;
                }

                else
                {
                    //Console.WriteLine(tammyTotal);
                    return tammyTotal;
                }
            }
    //*/-------End of BrandonRockGame

    //DO NOT TOUCH THE CODE BELOW

    /*//-------Begining of CoreyRockGame----------
    public static int CoreyRockGame(int b, int s, int t)

    {
        int steveTotal = 0;

        int tommyTotal = 0;

        int total = 0;

        do
        {

            if (b - s > 0)
            {
                steveTotal += s;
                b -= s;
            }

            else if (b - s == 0)
            {
                steveTotal += s;
                return steveTotal;
            }

            else
            {
                steveTotal += b;
                return steveTotal;
            }

            if (b - t > 0)
            {
                tommyTotal += t;
                b -= t;
            }

            else if (b - t == 0)
            {
                tommyTotal += t;
                return tommyTotal;
            }

            else
            {
                tommyTotal += b;
                return tommyTotal;
            }
        }
            while
             (b > 0) ;
            

            return total;
    }
    *///-------End of CoreyRockGame----------

    public static void Main()
    {
        System.Console.Write("Enter number of rocks in bag: "); //extra fluff, not needed during challenge. only adding here to review in VS Code
        int b = int.Parse(Console.ReadLine());
        System.Console.Write("Enter number of rocks Steve takes each turn: "); //extra fluff, not needed during challenge. only adding here to review in VS Code
        int s = int.Parse(Console.ReadLine());
        System.Console.Write("Enter number of rocks Tommy takes each turn: "); //extra fluff, not needed during challenge. only adding here to review in VS Code
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine(BrandonRockGame(b, s, t));
        //Console.WriteLine(CoreyRockGame(b, s, t));
    }
}


/*
Score: 0/50
Status: Failed
INPUT	ACTUAL OUTPUT	EXPECTED OUTPUT
100 7 5	105	60
444 15 20	460	249
37 1 1	37	19
596 76 42	608	386
900 11 13	910	482
*/