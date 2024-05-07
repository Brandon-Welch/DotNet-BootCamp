using System;
class Program
{
    static void Main(string[] args)
    {
        //Data Structure -> Arrays
        int[] numerals = new int[5];

        //Collections

        //List -> stores all of its values inside an array
            //Parameterized Class...
            //Generics - Generic Class
            //DataType<elementType> variableName = new DataType<elementType>;

        //There are more collections bseides lists:
            //Stacks and Queues
                //takes a slightly different strategy to data storage (more like a holding cell, where data enters in a particular order then exits (leaves/removed from collection) in a particular order)
                //Stacks have a strategy called FILO (First in Last Out)
                //Queues have a strategy called FIFO (First in First Out)

        //Hash - a way of storing values-- usually using some of hte item''s data to help formulate a spot for the hash to store said item

        //Set - do not preserve any order insertion
            //-duplicates are not allowed

        //Dictionary - store Key-Value Pairs
            //two datatype that you have to pick. One representing the Key, the other the Value
            //Real World Equivalences:
                // Dictionary - look up the *Key* (The Word) and the *value* you are provided is the definition
                // SSN - Someone can look up the *key* (SSN) and the *value* of the person (name/etc linked to the SSN) is provided





        //Lists();
        //StacksAndQueues();
        //HashSets();
        Dictionaries();

    }



    public static void Dictionaries()
    {
        Dictionary<string, int> studentScores = new Dictionary<string, int>(); //string = key, int = value
        studentScores.Add("Ryan", 80);
        studentScores.Add("Emma", 85);
        studentScores.Add("Adam", 75);

        //Accessing elements in the dictionary
        System.Console.WriteLine("Ryan's Score: " +studentScores["Ryan"]);

        studentScores["Ryan"] = 81; //can override/update a Key at any time and future representations of the key will reflect new value
        System.Console.WriteLine("Ryan's Score: " +studentScores["Ryan"]);

        System.Console.Write(studentScores.ContainsKey("Ryan")); 
        System.Console.WriteLine(" <- returns true bc the dictionary ContainsKey Ryan");

        //a way to display all in the dictionary
        foreach (KeyValuePair<string, int> kvp in studentScores) // shortened (var kvp in studentScores) *basically says "Whatever the datatype is" using
        {
            System.Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
        

    }

    public static void HashSets()
    {
        HashSet<int> set = new HashSet<int>(); //Alt short version HashSet<int> set = [1, 2, 3, 4, 5, 1];
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(5);
        set.Add(1); //wont accept a duplicate
        set.Add(7);
        set.Add(6);

        System.Console.WriteLine(set.Contains(4)); //return if 4 in set
        foreach (int num in set)
        {
            System.Console.WriteLine(num);
        }

    }
    
    public static void StacksAndQueues()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1); //thing putting IN queue
        queue.Enqueue(2);
        queue.Enqueue(3);
        System.Console.WriteLine("FIFO Dequeued: " +queue.Dequeue());
        queue.Enqueue(4);

        while (queue.Count > 0)
        {
            System.Console.WriteLine("Dequeued: "+ queue.Dequeue());
        }


        Stack<int> stack = new Stack<int>();
        stack.Push(10); //this pushing something ontop of the stack to add it
        stack.Push(20);
        stack.Push(30);
        System.Console.WriteLine("FILO First popped item: " + stack.Pop()); //pops it OUT of the stack (in a FILO) process
        stack.Push(40);


        while(stack.Count > 0)
        {
            System.Console.WriteLine("Popped item: " + stack.Pop());
        }

    }

    public static void Lists()
    {
        List<int> numbers = new List<int>(); //-> shortcut follow the elipse below new/list

        //Add values
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //Printing out items in collection
        //Long Way (only the foreach, i added the cw before and after for clarity in output)
        {
            System.Console.WriteLine("---Printing Numbers List:---");
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
            System.Console.WriteLine("---End Numbers List---");
        }

        //One-liner
        System.Console.Write(string.Join(",", numbers));
        System.Console.WriteLine(" <- Example printing using only one line");

        //------------------------
        //Insert a value somewhere in the list other than the end
        numbers.Insert(0, 40); //-> (index, value)
        System.Console.Write(string.Join(",", numbers));
        System.Console.WriteLine(" <- Example showing 40 added at 0 index");

        //Add/Insert mutlipel values
        //another list
        List<int> numbers2 = new List<int>();
        numbers2.Add(1);
        numbers2.Add(2);
        numbers2.Add(3);
        numbers.AddRange(numbers2);
        numbers.InsertRange(0, [4, 5, 6]);
        System.Console.Write(string.Join(",", numbers));
        System.Console.WriteLine(" <- Example showing 456 added at 0 index (from InsertRange) and also the 123 added at the end (from AddRange)");

        //IndexOf
        System.Console.WriteLine(numbers.IndexOf(30) + " <- Example showing return of index for value)");

        //Determine if an element is in the list
        System.Console.WriteLine(numbers.Contains(25) + " <- Example showing list doesnt contain 25");
        System.Console.WriteLine(numbers.Contains(20) + " <- Example showing list does contain 20");

        //Accessing an Element
        System.Console.WriteLine(numbers[0] + " <- Example showing what is in the specific index location of the list");

        //Removing an element
        numbers.Remove(20); //can use other remove options like RemoveAll(20) to removal all 20s, RemoveAt(0)  removes index based and would remove what is at 0 index, couple other removes

        //Reverse the list
        numbers.Reverse(); //would be permenant, to get back have to reverse again
        System.Console.Write(string.Join(",", numbers));
        System.Console.WriteLine(" <- Example showing reversed list");
    }
}