using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("\n---Begin---\n"); //define beginning of program and leave a blank line after cmd line and before program

        Thread.Sleep(1000);
        ReversedString(); //goes backwards indexing the string?
        Thread.Sleep(1500);
        RyanReverseString(); //pulls each character starting at the end individually?
        Thread.Sleep(1500);
        MaxValueInArray(); //take numbers in array and returns highest (max) value 

        System.Console.WriteLine("\n---End---\n"); //define end of program and leave a blank line after program and before cmd line
    }




    //Methods
    public static void MaxValueInArray()
    {
        System.Console.WriteLine("-----Max Value in Array-----");
        int maxNum = 0;
        int[] numberArray = { 1, 5, 9, 15, 72, 99, 107, 114, 32, 55, 4 };
                
        foreach (int num in numberArray)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        System.Console.WriteLine("Max number in your Array is: " + maxNum);
        System.Console.WriteLine("----------------");
    }

    public static void RyanReverseString() 
    {
        System.Console.WriteLine("-----String Reversal 2-----");
        System.Console.Write("Enter a string of text: ");
        string str = System.Console.ReadLine();
        string reverse = "";
        
        foreach (char c in str)
        {
            reverse = c + reverse;
        }
        System.Console.WriteLine("String in reverse: " + reverse);
        System.Console.WriteLine("----------------");
    }

    public static void ReversedString() 
    {
        System.Console.WriteLine("-----String Reversal 1-----");
        System.Console.Write("Enter a string of text: ");

        string inputString = System.Console.ReadLine();
        string reversedString = "";
        
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString += inputString[i];
        }
        
        System.Console.WriteLine("String in reverse: " + reversedString);
        System.Console.WriteLine("----------------");
    }

}