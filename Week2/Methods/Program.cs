using System;
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
    }

    //lets make a method that simply adds two numbers together and prints that result
    // Method Signature Syntax:
    //     access_modifier return_type MethodName(parameterType paramaterName, parameterType parameterName2) {}

    public static void AddNumbers(int num1, int num2)
    {
        int result = num1 + num2;
        System.Console.WriteLine(result);
        //System.Console.WriteLine(num1 + num2); //condenses the above 2 lines into 1
    }

     public static void AddToCart(string item)
    {
        cart.Add(item);
        System.Console.WriteLine("===My Cart===");
        foreach(string obj in cart)
        {
             System.Console.WriteLine(obj);
         }
    }
}



