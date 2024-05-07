using System;
using System.Formats.Asn1;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("\n---Begin---\n"); //define beginning of program and leave a blank line after cmd line and before program
        // Thread.Sleep(1000);
        // ReversedString(); //goes backwards indexing the string?
        // Thread.Sleep(1500);
        // RyanReverseString(); //pulls each character starting at the end individually?
        // Thread.Sleep(1500);
        // MaxValueInArray(); //take numbers in array and returns highest (max) value
        //PalindromePrintedUsingReverseMethod(); 
        //PalindromeUsingToCharAndReverse();
        //PalindromeUsingLength();
        //CharToASCII(); //<-Unable to interpret???????

        System.Console.WriteLine("\n---End---\n"); //define end of program and leave a blank line after program and before cmd line
    }

    //Methods
    public static void CharToASCII()
    {
        string? S = Console.ReadLine();
        int value = 0;

        foreach (char A in S)
        {
            value += A;
        }

        Console.WriteLine(value);
    }
    public static void PalindromeUsingToCharAndReverse()
        //In this method, we first convert our string into a char array using ToCharArray() method, then we call Array.Reverse() to reverse our char array. 
        //We create a new string from this reversed array. If our initial string matches this reversed string, we have a palindrome.
    {
        System.Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        char[] cArray = word.ToCharArray();
        Array.Reverse(cArray);
        string revWord = new string(cArray);

        Console.WriteLine(word == revWord ? word + " is a palindrome!" : word + " is not a palindrome!");
        
    }    
    public static void PalindromeUsingLength()
        //In this method, we create a boolean variable isPalindrome and set it to true as initial value. 
        //We then loop halfway through our string, comparing the element at the current index with its corresponding element from the end. 
        //If we find a mismatch, we break from the loop and set isPalindrome to false.
    {
        System.Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        int length = word.Length;
        bool isPalindrome = true;

        for(int i = 0; i < length / 2; i++) 
        {
            if(word[i] != word[length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        Console.WriteLine(isPalindrome ? word + " is a palindrome!" : word + " is not a palindrome!");
    }
    public static void PalindromePrintedUsingReverseMethod()
    {
        System.Console.Write("Please enter a word: "); 
        var original = Console.ReadLine();
        var reversed = new string(original.Reverse().ToArray());
        var palindrome = original == reversed;
        System.Console.WriteLine("Your word reversed is: " + reversed);
        System.Console.Write("Is this a palindrome? ");
        System.Console.WriteLine(palindrome);
    }
    public static void MaxValueInArray()
    {
        System.Console.WriteLine("-----Max Value in Array-----");
        int maxNum = 0;
        int[] numberArray = { 1, 5, 9, 15, 72, 99, 107, 114, 32, 155, 4 };
                
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