using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        OverloadEx();
        OverrideEx();
    }


    public static void OverrideEx()
    {
        System.Console.WriteLine("---Adding new parent---");
        Parent p = new();
        p.JobTitle = "Trainer";
        p.Work();
        System.Console.WriteLine("------------");

        System.Console.WriteLine("---Adding new child with inherited properties from parent---");
        Child c = new();
        c.JobTitle = "Student";
        c.FavoriteGame = "Minecraft";
        c.Play();
        c.Work();
        System.Console.WriteLine("------------");

        System.Console.WriteLine("---Adding new grand child with inherited properties from child---");
        GrandChild g = new();
        g.FavoriteGame = "Rattle";
        g.JobTitle = "Senior Associate Infant";
        g.Play();
        g.Work();
        System.Console.WriteLine("------------");

        //back to Parent
        System.Console.WriteLine("----Printing default ToString----");
        System.Console.WriteLine(p.ToString()); //returns simply 'Parent'
        System.Console.WriteLine("------------");


        //randomness around toStrings
        System.Console.WriteLine("----Randomness around ToString----");
        System.Console.WriteLine(p.ToString());
        System.Console.WriteLine(c);
        System.Console.WriteLine(g);


        //(Somewhat) Bonus Knowledge --turn back now! --- Save yourself!
        Parent p2 = new();
        Parent p3 = p2;

        Parent pc = new Child(); //valid bc child/grandchild have inherited all the "requirements" of being a parent
        //only has access to what is in Parent class (i.e work but not play)
        pc.JobTitle = "";
        pc.Work(); //pulling the word from the Child override not from the Parent class directly
        pc = new Parent(); //can be reassigned back to Parent class (but could not take a Child to a Parent)

        //Child c2 = new Parent(); //cant do this bc Child has more requirements than Parent class has (has favorite game and play in Child class but Parent only has Jobtitle and Work)

        //Slight Detour - Casting (allows to convert one data type to another similar to parse)
        int num1 = (int) 2.5; //putting dataype in front of variable and attempts to convert it best as it can (ie in this case, double to an int which will return 2 instead of 2.5)
        System.Console.WriteLine(num1);
        Parent p4 = (Parent) c; // casts child to parent and will work since has needed features (parent only needs job/work and child inherited those along with additional game/play)
        //Child c2 = (Child) p; //casts parent down to child - potentially compiling but likely will break as parent doesnt have all the required features (game/play)
        Child c2 = (Child) pc;
        c2.Work(); //works bc even tho techincally 'pc' is a parent object, 'pc' ALREADY has the other needed details in memory from the 'Parent pc = new Child();' initialization










    }
    private static void OverloadEx()
    {
        System.Console.WriteLine("2 Int Method Call: " + Calculator.Add(4, 5)); //calls Add Method with 2 Ints
        System.Console.WriteLine("3 Int Method Call: " + Calculator.Add(4, 5, 6)); //Calls Add Method with 3 ints
        System.Console.WriteLine("-------------------");
        System.Console.WriteLine("2 Double Method Call: " + Calculator.Add(4.2, 5.3)); //Calsl Add method wouth Double using double params
        System.Console.WriteLine("2 Double/String Method Call: " + Calculator.Add("123", "45.678")); //Calls Add method with doubles using string params
        System.Console.WriteLine("-------------------");
        System.Console.WriteLine("String and Double Method Call: " + Calculator.Add("123", 45.678)); //Calls Add method with string and double param
        System.Console.WriteLine("Double and String Method Call: " + Calculator.Add(12.345, "678")); //Calls Add method with double and string string params
        System.Console.WriteLine("-------------------");

        int[] numbers = [1, 2, 3];
        System.Console.WriteLine("Array Method Call: " + Calculator.Add(numbers)); //Calls Add method with arrays
                                                                                   //System.Console.WriteLine("Array (alternate) Method Call: " + Calculator.Add([1, 2, 3, 4, 5])); //Alternatre Version - Calls Add method with arrays
        System.Console.WriteLine("-------------------");

        //below 4 examples are using the Calls Add Params Array method
        System.Console.WriteLine("Below are Params Array Method Calls*");
        System.Console.WriteLine(Calculator.Add(2.5));
        System.Console.WriteLine(Calculator.Add(2.5, 3.6)); //*we have 2 methods that now take in 2 doubles... in this exact scenario it will call the 2 doubles method NOT the Params Array. Params array is deprioritized
        System.Console.WriteLine(Calculator.Add(2.5, 3.6, 7.4));
        System.Console.WriteLine(Calculator.Add(2.5, 3.6, 7.5, 2.1, 1.9, 2, 0.25));
        System.Console.WriteLine("-------------------");
    }
}