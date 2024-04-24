//See Week2 -> ClassesExample -> ClassesAndObjects.MD

using System;
using System.Net.NetworkInformation;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //int num = 1; //EXAMPLE
        //string word = "Hello"; //EXAMPLE
        //    word.ToUpper(); is word calling the ToUpper Method

        //Object Declaration and Instantiation (Initialization) ((basically Instantiation is the creatation of a new INSTANCE of the CLASS))
        Object obj = new Object(); //uses Object class to create variable obj
        Object obj2 = new(); //Shortened Syntax from above....considered name of new Object will match the one at the start of line

        DateTime currentTime = DateTime.Now; //creates DateTime Object, but this isnt creating a NEW object.... its assigning it based on the existing DateTime Object  and using the NOW specific value
        System.Console.WriteLine("---------------------------------------");
        System.Console.WriteLine("-------Print DateTime-------");
        System.Console.WriteLine(currentTime);

        System.Console.WriteLine("---------------------------------------");
        System.Console.WriteLine("-------Print Car-------");
        Car car1 = new Car();
        System.Console.WriteLine(car1); //Right Now, Printing the Object is quite boring/useless. Only prints the name of the class.

        car1.color = "Redfire Metallic"; //if field is "inaccessible" - need to make the field/method public
        car1.year = 2023;
        car1.make = "Chevrolet";
        car1.model = "Corvette";

        System.Console.WriteLine(car1.color); //not prints the Object's field
        System.Console.WriteLine(car1.year); //not prints the Object's field
        System.Console.WriteLine(car1.make); //not prints the Object's field
        System.Console.WriteLine(car1.model); //not prints the Object's field
        System.Console.WriteLine("car1= " + car1.color + " " + car1.year + " " + car1.make + " " + car1.model + ".");

        //Adding in the Method
        car1.Honk();
        car1.Exhaust();
        car1.Drive(100);
        car1.Drive(150); //Additive


        // ToString method
        // Copying Object references
        // Properties
        // Constructors
        // Scopes (TcpStatistics keyword as Well)
        // Access Modifiers

        // Inheritance
        // Polymorphism - 
    }
}