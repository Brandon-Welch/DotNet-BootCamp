using System;
//using System.Net.NetworkInformation;
//using System.Transactions;
//using System.Net.Security;

class Program
{

    static List<string> cart = new();

    static void Main(string[] args)
    {
        // main method code here 
        System.Console.WriteLine("Hello World!");

        /*
        Problem: Often we have chunks of code that perform some operation that we would like to potentially use again later in our program.
        Right now, our only means to do so is to simply copy/past that chunk of code to repeat its intended functionalty.

        Methods - Allow us to recall a chunkof code all consiluidated to one place as often as we would like, while simultaneously abstracting away the 
                 implementations behind acheiving such functionality, allowing us to focus solely on the intention of said chunk of code
         */

        AddNumbers(1, 2); //this executes the method that is created below
        AddToCart("Pepperoni");
        AddToCart("Cheese");

        int result = SquareNumber(5);
        System.Console.WriteLine(result);
        System.Console.WriteLine("-------------");


        //Print out this welcome message (method option below)
        System.Console.WriteLine("Please enter your name: "); ;
        string? input = Console.ReadLine();
        System.Console.WriteLine("=============");
        System.Console.WriteLine("Hello, " + input + "!");
        System.Console.WriteLine("==============");

        //Method version of welcome message
        SayHello();


        //Methods for Menu App

        PrintMenu();

        input = Console.ReadLine();
        int cmd = 0;
        if (input != null) cmd = int.Parse(input);

        switch (cmd)
        {
            case 1:
                {
                    SayHello();
                    break;
                }

            case 2:
                {
                    ProcessAddNumbers();
                    break;
                }

            case 3:
                {
                    ProcessSquareNumber();
                    break;
                }

            case 4:
                {
                    System.Console.WriteLine("You did not select a valid option.");
                    break;
                }
        }



    }

    public static void ProcessSquareNumber()
    {
        System.Console.WriteLine("Enter a Number:");
        string? value1 = Console.ReadLine();

        int num1 = 0;
        if (value1 != null) num1 = int.Parse(value1);

        System.Console.WriteLine(SquareNumber(num1));
    }

    public static void ProcessAddNumbers()
    {
        System.Console.WriteLine("Enter 1st Number:");
        string? value1 = Console.ReadLine();
        System.Console.WriteLine("Enter 2nd Number:");
        string? value2 = Console.ReadLine();

        int num1 = 0;
        int num2 = 0;
        if (value1 != null) num1 = int.Parse(value1);
        if (value2 != null) num2 = int.Parse(value2);

        AddNumbers(num1, num2);
    }


    //Sample application with methods
    public static void PrintMenu()
    {
        System.Console.WriteLine("Welcome to Our App!");
        System.Console.WriteLine("=============");
        System.Console.WriteLine("Please enter a Command:");
        System.Console.WriteLine("==============================");
        System.Console.WriteLine("[1] Say Hello!");
        System.Console.WriteLine("[2] Add Two Numbers");
        System.Console.WriteLine("[3] Square a Number");
        System.Console.WriteLine("==============================");
    }

    //lets make a method that simply adds two numbers together and prints that result
    // Method Signature Syntax:
    //     access_modifier return_type MethodName(parameterType paramaterName, parameterType parameterName2) {}

    public static void AddNumbers(int num1, int num2)
    {
        int result = num1 + num2;
        System.Console.WriteLine(result);
        System.Console.WriteLine("--------------");
        //System.Console.WriteLine(num1 + num2); //condenses the above 2 lines into 1
    }

    public static void AddToCart(string item)
    {
        cart.Add(item);
        System.Console.WriteLine("===My Cart===");
        foreach (string obj in cart)
        {
            System.Console.WriteLine(obj);
        }
        System.Console.WriteLine("--------------");
    }

    //lets make a method that RETURNS the squared value of a number.
    public static int SquareNumber(int num1)
    {
        int square = num1 * num1;
        return square;
    }

    public static void SayHello()
    {
        System.Console.WriteLine("Please enter your name: "); ;
        string? input = Console.ReadLine();
        System.Console.WriteLine("=============");
        System.Console.WriteLine("Hello, " + input + "!");
        System.Console.WriteLine("=============");
    }


    //takes in two strings and prints both of them twice.
    //Find the largest number between 3 ints.



}






