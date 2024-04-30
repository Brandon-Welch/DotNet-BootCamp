using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string vegInput;

        Fridge fridge1 = new Fridge();
        Fridge fridge2 = new Fridge("Coca-Cola, Milk", "Carrots", "Grapes", "Mustard, Ranch, Hoisin", 35);
        Fridge fridge3 = new Fridge();

        System.Console.WriteLine("Refrigerator 1 includes: " + fridge1);
        System.Console.WriteLine("Refrigerator 2 includes: " + fridge2);

        fridge3.drink = "Orange Juice";

        System.Console.WriteLine("Refrigerator 3 includes: " + fridge3);

        System.Console.WriteLine("---------------");
        System.Console.WriteLine("Do any refrigerators have any fruit in them?");
        System.Console.WriteLine("Refrigerator 1 fruit includes: " + fridge1.fruit + ".");
        System.Console.WriteLine("Refrigerator 2 fruit includes: " + fridge2.fruit + ".");
        System.Console.WriteLine("Refrigerator 3 fruit includes: " + fridge3.fruit + ".");

        System.Console.WriteLine("---------------");
        System.Console.WriteLine("What sound does the fresh vegetables make when they are snapped in half?");
        System.Console.Write("Vegetables make the sound: "); fridge1.Sound();
        
        System.Console.WriteLine("\nPress Enter to open Refrigerator 1's door.");
        System.Console.ReadLine();

        System.Console.WriteLine("---------------");
        System.Console.WriteLine("Opening refrigerator 1 door.");
        Thread.Sleep(2000);
        System.Console.WriteLine("Refrigerator 1 door is open.");
         Thread.Sleep(3000);
        System.Console.Write("Please close the door before you let out all the cold. ");
        fridge1.DoorOpen();
        
        System.Console.WriteLine("\nPress Enter to close the door.");
        System.Console.ReadLine();
        
        System.Console.Write("Refrigerator 1 door is now closed. ");
        fridge1.DoorClosed();

        System.Console.WriteLine("");

        System.Console.WriteLine("What vegetable would you like to add to refrigerator 1?");
        vegInput = Console.ReadLine();

        fridge1.vegetable = vegInput;

        System.Console.WriteLine("Refrigerator 1 now includes: "+ fridge1.vegetable + ".");

        System.Console.WriteLine("For an updated inventory for all refrigerators, press enter.");
        System.Console.WriteLine("Refrigerator 1 includes: " + fridge1);
        System.Console.WriteLine("Refrigerator 2 includes: " + fridge2);
        System.Console.WriteLine("Refrigerator 3 includes: " + fridge3);
    System.Console.WriteLine(""); //clean seperation at end of program

    }
}