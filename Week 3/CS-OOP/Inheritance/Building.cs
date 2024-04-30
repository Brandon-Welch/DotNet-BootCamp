class Building
{
    //properties ('prop' shortcut)
    public int Walls { get; set; }
    public int Area { get; set; }
    
    //constructors
    //no-arg constructor
    public Building()
    {
        //for the sake of demo
        System.Console.WriteLine("Constructing a new Building");
    }

    //full-arg constructor
    public Building(int walls, int area)
    {
        Walls = walls;
        Area = area;
        System.Console.WriteLine("Constructing a new building including: " + Walls + " walls and " + Area + " area.");
    }

    public override string ToString()    //needs override bc we are inheriting from default ToString method
    {
        return "{walls:" + Walls + ",area:" + Area + "}";
    }

}