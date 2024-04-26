﻿//See Week2 -> ClassesExample -> ClassesAndObjects.MD

using System;


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
        System.Console.WriteLine("-------Car Drove-------");
        car1.Drive(100);
        System.Console.WriteLine("-------Car Drove-------");
        car1.Drive(150); //Additive



        Car car2 = new Car();

            car2.color = "Blue Carbon"; //if field is "inaccessible" - need to make the field/method public
            car2.year = 2018;
            car2.make = "Pagani";
            car2.model = "Zonda";

        System.Console.WriteLine("Car1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car2 Mileage: " + car2.mileage);

        car2.Drive(50);
        System.Console.WriteLine("---------------------------------------");
        System.Console.WriteLine("-------Car2 Drove-------");
        System.Console.WriteLine("Car1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car2 Mileage: " + car2.mileage);
        System.Console.WriteLine("---------------------------------------");

        Car car3 = new Car();
            car3.year = 2020;
/*
        Car car3 = car2;
        System.Console.WriteLine("Car 3 Color: " + car3.color);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);

        //Are car3 adn car2 the SAME car? or just borrowing the same initial values?

       // car3.Drive(50);
        //System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);
        //System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);
        //car3 and car2 are both the SAME exact Car in memory


        -----------------------got lost, review Ryans file after class-------------------------
*/
        //ToString Method
        //System.Console.WriteLine("Car 1: " + car1.DisplayInfo()); //DisplayInfo is now ToString Method
        //System.Console.WriteLine("Car 2: " + car2.DisplayInfo()); //DisplayInfo is now ToString Method
        System.Console.WriteLine("Car 1: " + car1.ToString()); 
        System.Console.WriteLine("Car 2: " + car2.ToString());

        System.Console.WriteLine("Car 1: " + car1); 
        System.Console.WriteLine("Car 2: " + car2);
        System.Console.WriteLine("Car 3: " + car3);

        Car car4 = new Car();
        Car car5 = new Car("Silver");

        System.Console.WriteLine("Car 4: " + car4);
        System.Console.WriteLine("Car 5: " + car5);

        Car car6 = new Car("Yellow", "Porsche", "911 RS", 2018, 4500);
        
        System.Console.WriteLine("Car 6: " + car6);

        //how to copy over one objects valyes to another object
        //no-arg
            Car car8 = new();
            car8.color = car6.color; 
            car8.make = car6.make; //etc... through all the fields
        //full-arg
            Car car9 = new(car6.color, car6.make, car6.model, car6.year, car6.mileage); //etc through all the fields
        //copy
            Car car10 = new(car6);











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



///to do
///create own class - fridge
///give it a field -condiments, meats, vehhies, fruits, drinks, etc
///give it some data - smear, ripen, sour, chill, etc
///try to give it a few methods to do something - vehhies crunch, drinks fizz
///try tostring
///try 2 constructors (no arg and full arg)
///make instances
///