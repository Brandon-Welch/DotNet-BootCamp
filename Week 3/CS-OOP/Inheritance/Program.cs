using System;

class Program
{
    static void Main(string[] args)
    {
       Building b1 = new();
       Building b2 = new(4, 1000);

       System.Console.WriteLine("Building 1 constructed with: " + b1);
       System.Console.WriteLine("Building 2 constructed with: " + b2);
       System.Console.WriteLine("---------------------------");

       House h1 = new();

       System.Console.WriteLine("House 1 constructed with: " + h1);
       System.Console.WriteLine("---------------------------");

       House h2 = new(6, 500);
       System.Console.WriteLine("House 2constructed with: " + h2);
       System.Console.WriteLine("---------------------------");

       House h3 = new(3, 750, 2, "John Smith");
       System.Console.WriteLine("House 3 constructed with: " + h3);
       
    }
}