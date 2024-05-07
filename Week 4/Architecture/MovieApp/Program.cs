using System;

class Program
{//---Start of Class Program---
    static void Main(string[] args)
    {//---Start of Main Method---

        MovieRepo mr = new(); //mr is just shrot for movie repo

        //Test retreiving a movie that exists
        //We have to make a little bit fo assumption
        //The user would have to know what kind of IDs might work
        System.Console.WriteLine("Please enter a movie ID: ");
        System.Console.Write("ID: ");
        int input = int.Parse(Console.ReadLine() ?? "0");
        Movie retrievedMovie = mr.GetMovie(input);

        //Easiest way to showcase what movie we retievied is to print it
        System.Console.WriteLine("Retrieved Movie: " + retrievedMovie);



        //Test adding a new movie into the collection

    }//---End of Main Method---
}//---End of Class Program---