using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       string filepath = "example.txt";

    //    StreamWriter writer = new StreamWriter(filepath); //will overwrite any of the existing context in the file BY DEFAULT
    //    StreamWriter writer = new StreamWriter(filepath, true); //append option true will add, append option false will override (default)

    //    writer.WriteLine("Hello, world!"); //writes to file not program level at the console.
    //    writer.WriteLine("Ryan was here!");

    //     System.Console.WriteLine("Info was written to file."); //prints on program level to the console directly but not to the file.
       
    //     writer.Close(); //closes out of the resource

        WriteToFile(filepath);
        ReadFromFile(filepath);


    }

        //Methods    
        public static void WriteToFile (string filepath)
    {
        using (StreamWriter writer = new(filepath, true)) //append option true will add, append option false will override (default)
        {
            writer.WriteLine("Hello, world!"); //writes to file not program level at the console. 
            writer.WriteLine("Ryan was here!");

            System.Console.WriteLine("Info was written to file."); //prints on program level to the console directly but not to the file.
        }
    }

    public static void ReadFromFile (string filepath)
    {
        using (StreamReader reader = new(filepath))
        {
            string line;
            //line = reader.ReadLine();
            while((line = reader.ReadLine()) !=null) //combines the additional code and condences 
            {
                System.Console.WriteLine(line);
                //line = reader.ReadLine();
            }
        }
    }
}