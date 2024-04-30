using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class Calculator
{
    
    /*
    Polymorphism -> Many Forms - an entity can exist with multiple labels attached to it all at the same time.

        Static Polymorphism - Overloading
            -We can have multiple methods with the same name, the only requirement is that they each have a unique set of parameters (based strictly on Data Types)
                -change the quanitity, type, permutation/order (ways to make it unique)

        Dynamic Polymorphism - Overriding
            -We can change the implementation of methods that we inherit into a new child class to fit the narrative of our new class
                -C# does require you to specify that a method can be overriden and, by extension, you must explicitly declare that you are overriding an implementation
                    -use of 'override' keyword when delarcing [ex: public override string ToString()]
                    -use of 'virtual'

    */

    //-----------Static Polymorphism (Overloading)----------------------
    //------------------------------------------------------------------
    public static int Add(int num1, int num2)
    {   
        return num1 + num2;
    }

    public static int Add(int num1, int num2, int num3) //works: makes this unique bc we changed the quantity adding a 3rd int to the parameters)
    { 
        return num1 + num2 + num3;
    }

    // public static int Add(int value2, int value4) //wont work: does not make this unique bc the data types didnt change, only the value names so it conflicts with the other add with 2 ints alread
    // {
    //     return value2 + value4;
    // }

    public static double Add(double num1, double num2) //works: makes this unique bc we changed the data type using doubles instead of ints)
    {
        return num1 + num2;
    }

    public static double Add(string num1, string num2)
    {
        return double.Parse(num1) + double.Parse(num2);
    }

    public static double Add(string num1, double num2)
    {
        return double.Parse(num1) + num2;
    }

    public static double Add(double num1, string num2)
    {
        return num1 + double.Parse(num2);
    }

    public static int Add(int num1)
    {
        return num1;
    }

    public static int Add()
    {
        return 0;
    }

    public static int Add(int[] array) //using array so that we dont have to make a method for every possible amount of numbers 4, 5, 6, etc
    {
        int sum = 0;
        foreach(int num in array)
        {
            sum += num;
        }
        return sum;
    }

    //params -> paramater array argument. Essentially lets you provide a variable number of arguments to satisfy this one parameter, in which it will 'collect' them into one array for us
    //you can only have 1 parameter array per method and it MUST be the LAST paramater in the method
    public static double Add(params double[] array) //using a parameter array - treats all values passed in as one single array (with type double in this case)
    {   
        double sum = 0;
        foreach(double num in array)
        {
            sum += num;
        }
        return sum;
    //---------------------------------------------------------
    //-------End Static Polymorphism (Overloading)-------------


    //---------------------------------------------------------
    //-------Dynamic Polymorphism (Overriding)-----------------
    //See Parent.cs file

    
    
    
    
    
    
    }
}