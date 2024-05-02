using System;

class Program
{
    static void Main(string[] args)
    {
        //PreventiveApproach();
        HandlingExceptions();
    }

    public static void HandlingExceptions()
    {
        int[] numbers = [1, 2, 3];
        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing

        //Handling exceptions - try/catch block
        try
        {
            System.Console.WriteLine(numbers[index]);
        }
        catch (IndexOutOfRangeException e) //incase they entered an invalid int
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            //throw;
        }
        
        catch (FormatException e) //incase they entered a string instead of a int
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            //throw;
        }

        catch (Exception e) //general superclass exception scenario. will review for any/all
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            //throw;
        }

        finally
        {
            System.Console.WriteLine("Will Execute No Matter What");
        }

        System.Console.WriteLine("Program End");
    }
    
   
    public static void PreventiveApproach()
    {
        int[] numbers = [1, 2, 3];
        //int index = 2
        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing

        //preventitive approach to exception handling
        if (index >= numbers.Length || index < 0)
        {
            System.Console.WriteLine("Please input a valid index");
        }
        else
        {
            System.Console.WriteLine(numbers[index]);
        }
        //System.Console.WriteLine(numbers[2]);
        //System.Console.WriteLine(numbers[index]); //fixed by adding the if statement to notify if not valid or return a value
        System.Console.WriteLine("Program End");
    }
}