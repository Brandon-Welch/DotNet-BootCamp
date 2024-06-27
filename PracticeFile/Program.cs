using System;
using System.Formats.Asn1;
using System.Linq;

//send emails
//using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
//using System.Linq;
using System.Net.Mail;
using System.Net;


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
        //CharToInt1(); //To Lower - Ryans Example
        //CharToInt2(); // Subtracting unicode value 
        //CharToInt3(); // <-GetNumericValue & ToInt32
        //PalindromeChallenge();
        //StringToSecretCode();
        //Array1();
        //Array2();
        SendEmail();


        System.Console.WriteLine("\n---End---\n"); //define end of program and leave a blank line after program and before cmd line
    }






    //Methods

    public static void SendEmail()
    //https://medium.com/@SaiParvathaneni/automate-email-alerts-for-critical-errors-in-log-files-code-execute-and-automate-d8642e5d1442

        {
            try
            {
                // Path to the Logs folder
                string rootPath = @"D:\Logs"; 

                // Get the most recently created log file in the Logs folder
                var files = new DirectoryInfo(rootPath)
                            .GetFiles("*.log*", SearchOption.AllDirectories)
                            .OrderByDescending(x => x.CreationTime)
                            .FirstOrDefault();

                List<string> errorList = new List<string>();
                StringBuilder emailAlertLogs = new StringBuilder();

                // Read each line in the log file and add lines containing "ERROR" to errorList
                foreach (string file in files)
                {
                    StreamReader myReader = new StreamReader(file);
                    string line = "";
                    while (line != null)
                    {
                        line = myReader.ReadLine();
                        if (line != null)
                        {
                            if (line.Contains("ERROR") == true)
                            {
                                errorList.Add(line);
                            }
                        }
                    }
                    myReader.Close();
                }

                // Append each line in errorList to emailAlertLogs
                foreach (string line in errorList)
                {
                    emailAlertLogs.AppendLine(line + "\n");
                }

                string to = "receivers@email.com";
                string from = "your@email.com";

                // Create a new email message
                MailMessage message = new MailMessage(from, to);

                // Add an additional recipient to the email
                message.To.Add("additional.receivers@email.com");   

                message.Subject = "Alerts from Logs";
                message.Body = emailAlertLogs.ToString();

                // Configure the SMTP client with the email server and settings

                // string Username = "username";
                // string Password = "password";
                // string to = "receivers@email.com";
                // string from = "your@email.com";
                // MailMessage message = new MailMessage(from, to);
                // message.To.Add("additional.receivers@email.com");
                // message.Subject = "Alerts from Logs";
                // message.Body = emailAlertLogs.ToString();

                // SmtpClient client = new SmtpClient("smtp.email.com");
                // client.Port = 25;
                // client.EnableSsl = false;
                // client.Credentials = new NetworkCredential(Username, Password);
                // client.Send(message);

                SmtpClient client = new SmtpClient("smtp.email.com");
                client.Port = 25;
                client.EnableSsl = false;

                // Send the email message using the SMTP client
                client.Send(message);

                Console.WriteLine("Email Sent");
            }
            catch (Exception ex)
            {
                // Print any exceptions to the console
                Console.WriteLine(ex.Message);
            }
        }

    public static void Array2()
    /*
    Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

    A string is represented by an array if the array elements concatenated in order forms the string.

    Function Description
    In the provided code snippet, implement the provided arrayStringsAreEqual(...) method using the variables to print the result that signifies whether the concatenated strings are equal or not. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”. 

    There will be multiple test cases running so the Input and Output should match exactly as provided.
    The base output variable result is set to a default value of false which can be modified. Additionally, you can add or remove these output variables.

    Input Format
    The first line contains a String array word1
    The second line contains a String array word2

    Sample Input
    "ab" "c"  -- denotes word1
    "a" "bc"  -- denotes word2

    Output Format
    The output contains an integer value 1 or 0 denoting whether the concatenated arrays are equal or not

    Sample Output
    1

    Explanation
    word1 represents string "ab" + "c" -> "abc"
    word2 represents string "a" + "bc" -> "abc"
    The strings are the same, so return true and print the output 1.
    */
    {
        /*
        hello world
        hello world
        
        one two three
        one two three four

        ab c
        a bc
        */
        
        //take in a 2 strings with a space in between
        string[] word1 = Console.ReadLine().Split(' ');
        //take in a second 2 strings with a space in between
        string[] word2 = Console.ReadLine().Split(' ');
        //compare if they are equal and return true/false
        bool result = arrayStringsAreEqual(word1, word2);
        Console.WriteLine(result ? 1 : 0);

         static bool arrayStringsAreEqual(string[] word1, string[] word2) {
        // WRITE YOUR LOGIC HERE

        //check if first string length does not equal second string length
        if (word1.Length != word2.Length)
        //if it doesnt not equal, return false (0)
        return false;

        //go through each string coparing the values in the arrays one by one
        for (int i=0; i < word1.Length; i++)
        {   
            //check to determine if the arrays individual values are not equal to each other
            if (word1[i] != word2[i])
            //if it so, return true and continue loop
            return true;
        }
        //return true (1) if arrays  are equal to each other
        return true;
    }
    }
    public static void Array1()
    /* 
        You are given an array having N elements and an integer K.
        You have to write a program to find the smallest number greater than K which is not present in the given array.

        Example
        If the array is A = [ 2, 5, 7, 9, 21, 34] and K = 20
        The output will be 22.
        22 will be the smallest number greater than K=20 which is not present in the given array.

        Function Description
        In the provided code snippet, implement the provided notInArray(...) method using the variables to print the smallest number greater than K which is not present in the given array. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”. 

        There will be multiple test cases running so the Input and Output should match exactly as provided.
        The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

        Input Format
        The code provided handles the input and stores them in variables for you.
        The first line contains an integer N denoting the size of the array.
        The next N lines contain elements of array A.
        The next line contains an integer, K.

        Sample Input
        5 -- denotes N
        1 -- denotes elements of Array N
        4 -- denotes elements of Array N
        5 -- denotes elements of Array N
        2 -- denotes elements of Array N
        7 -- denotes elements of Array N
        4 -- denotes K
        Constraints
        1 <= N <= 105
        1 <= A[i] <= 105
        1 <= K <= 105

        Output Format
        The output contains an integer denoting the smallest number greater than K which is not present in the given array.

        Sample Output
        6
        Explanation
        The array is [1,4,5,2,7] and K=4
        The smallest element which is greater than K = 4 and not present in the array is 6.
        Hence the output is 6.
    */    
    {
        /*
        5, 1, 4, 5, 2, 7, 4
        3, 10, 10, 10, 12
        7, 1, 2, 3, 4, 5, 6, 7, 8
        */
    	
        //take in an declared amount of values for the array
        int N = Convert.ToInt32(Console.ReadLine()); 
        //create the array A
        int[] A = new int[N];
        //loop through until the needed amount of values is taken in
        for (int i = 0; i < N; i++) {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }
        //take in the Value to compare against which is NOT in the array
        int K = Convert.ToInt32(Console.ReadLine());
        int result = notInArray(N, A, K);
        Console.WriteLine(result);

        static int notInArray(int N, int[] A, int K) {
        // WRITE YOUR LOGIC HERE
        
        //Sort the array in order
        Array.Sort(A); 

        //establish baselines
        int small = 0; //establish smallest number
        int big = N - 1; //establish biggest number
        int num = K + 1; //establish what would be the next number after K

        //Loop through each number until the smallest number is less than or equal to the biggest number
        while (small <= big)
        {
            //determine the mid range of the array
            int middle = (small + big) / 2;

                //if the number in the middle is less than or equal to the number being compared to it
                if (A[middle] <= num)
                {
                    //if the number in the middle is equals the number being compared to it
                    if (A[middle] == num)
                    {
                        //add 1 and make the biggest number again N -1
                        num++;
                        big = N - 1;
                    }
                    // make the smallest number 1 bigger than middle number
                    small = middle + 1;
                }
                else
                {
                    //make the biggest number 1 smaller than the middle number
                    big = middle - 1;
                }
        }
            //return the next niggest number
            System.Console.WriteLine("answer:");
            return num;
            
    }
    }

    public static void PalindromeChallenge() //needed to add using System.Linq;
    {
        string s = "Happy Birthday!"; //"RACECAR";
        string reverseS = new string(s.Reverse().ToArray()); //Reverse: Inverts the order of the elements in a sequence //ToArray takes the char from the string
        bool palindrome = s == reverseS;
        System.Console.WriteLine(palindrome);
        //return palindrome;
    }
    public static void StringToSecretCode()
    {
        string s = "AppleSauce";
        string secretCode = ""; 
        foreach (char c in s.ToLower()) //converts characters in string to lowercase
        {
            if (char.IsLetter(c)) // Indicates whether the specified Unicode character is categorized as a Unicode letter
            {
                int codeConverted = c - 'a' + 1; //this makes 'a' correspond to 1 otherwise a = 0
                secretCode = secretCode + codeConverted.ToString("00"); //converts 1 to 01
                
            }
        }
        Console.WriteLine(secretCode);
        //return secretCode;
    }
    public static int CharToInt2()
    {
        char ch = '5';
        int intValue = ch - '1';
        Console.WriteLine($"The integer value is: {intValue}");
        return intValue;
    }
    public static int CharToInt1()
    {
        char c = 'A';
        c = char.ToLower(c); //c = a = 97
        int result = c - 'a' + 1;
        int result2 = c - 'b' + 2;
        System.Console.WriteLine("c (97) - 'a' (97) + 1 = " + result);
        System.Console.WriteLine("c (97) - 'b' (98) + 2 = " + result2);
        System.Console.WriteLine(c-1);
        return result;
    }
    public static int CharToInt3()
{
    char input = 'a';
    double temp = Char.GetNumericValue(input);
    int result = Convert.ToInt32(temp);
    System.Console.WriteLine(result);
    return result;
}
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