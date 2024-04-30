class Thing
{
    //Scopes - a way to measure a range of visibility/existence of a particular entity/variable
    //
    //

    //Object Scope - exists within any object of this class
    public int objectNum; //field (not a prperty) with value assigned via constructor below.

    //Class Scope - belongs to the Entire class, and by extension, each Object of that class
    //the value of Class Scoped variables remains the same between each object (it is shared)

    public static int classNum = 10;
    public static int count = 0;

    
    public Thing()
    {
        objectNum = 100;
        count++;
    }

    public static void StaticMethod()
    {
        System.Console.WriteLine("This is a staic method from the Thing Class!");
    }

    //Method Scope - any variable we create (declare) inside of a method OR
    //and parameter used by that method is 'scoped' to that Method
    //Will no longer be used after the Method is finished.

    public void SomeMethod(int paramNum)
    {
        int methodNum = 10;

        //Parameters and variables created within a Method can be used so long as we are still in that Method.
        System.Console.WriteLine("=======printing Method Scoped=========");
        System.Console.WriteLine(paramNum);
        System.Console.WriteLine(methodNum);

        //Can still access the Object/Class Scoped variables
        System.Console.WriteLine("=======printing Object Scoped within Method Scoped=========");
        System.Console.WriteLine(objectNum);
        System.Console.WriteLine("=======printing Class Scoped within Method Scoped=========");
        System.Console.WriteLine(classNum);

    //Block Scope - any variable created within a "block: of code
    //can only be used within that context
    //a "block" -> Conditionals / Loops / etc.

            if (true)
            {
                int blockNum = 100;
                System.Console.WriteLine(blockNum);
            }
            else
            {
                //cannot use the block scoped varbiale above (blockNum) since we left that block of code. 
            }


            for (int i = 0; i <=100; i++)
            {
                System.Console.WriteLine(i); //cannot use the block scoped varbiale (i) outside of this specific block of code.
            }
    }






}