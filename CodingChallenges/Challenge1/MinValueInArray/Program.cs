/*
You are given an int array, and it is your job to figure out the minimum value in the int array (there may be duplicates).

The findMin() method takes in 1 argument:
intArray - the int array that will contain ints for you to check.
You will need to check all of the values in the array, and return the minimum value in findMin().
 
 
Example Input:	Example Output:
[1,2,3,4,5]	1
Explanation:
After going through all of the numbers in the int array, the smallest number returned is 1.
Skill: Language - Fundamentals II
*/


using System;

public class Test

{
    public static int findMin(int[] intArray)
    {
        int minNum = 10000;

        foreach (int num in intArray)
        {
            if (num < minNum)
            {
                minNum = num;
            }
        }

        //Console.WriteLine(minNum);
        return minNum;
    }

    //DO NOT TOUCH THE CODE BELOW

    public static void Main()
    {
        string[] inputArray = Console.ReadLine().Replace("[", "").Replace("]", "").Split(",");
        int[] intArray = new int[inputArray.Length];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(inputArray[i]);
        }

        Console.WriteLine(findMin(intArray));

    }

}


/*
Score: 50/50
Status: Passed
INPUT	ACTUAL OUTPUT	EXPECTED OUTPUT
[5,10,15,20]	5	5
[4,8,3,2,88,42,3,2,50]	2	2
[10,9,8,7,11,12,13,14]	7	7
[1,1,1,1,1,2,1,1,1,1]	1	1
[400,300,500,100,99,999]	99	99
*/