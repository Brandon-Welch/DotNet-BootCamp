class Parent
{
    //properties/fields
    public string JobTitle { get; set; }

    //constructors
    public Parent()
    {
        JobTitle = "";
    }

    public Parent(string jobTitle)
    {
        JobTitle = jobTitle;
    }


    //methods
    public virtual void Work() //adding virtual for instance when child class may call this
    {
        System.Console.WriteLine("Work hard all day to make money at my job as a: " + JobTitle);
    }

    public override string ToString()
    {
        return "{jobTitle:" + JobTitle + "}";
    }
}