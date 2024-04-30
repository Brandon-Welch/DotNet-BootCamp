class House : Building //to establish inheritance  add : and the parent class to derive/inherit from
{
    public int Bedrooms { get; set; }
    public string Owner { get; set; }



    //no arg constructor
    public House()
    //implied from public House() ; base() - base is the parent(aka Building() class)
    {
        System.Console.WriteLine("This new Building will become a House");
        Owner = "";
    }

    public House(int walls, int area) : base(walls, area)
    {
        Owner = "";
        System.Console.WriteLine("This new Building will become a House with an area and walls");
    }

    //full arg constructor
    public House(int walls, int area, int bedrooms, string owner) : this(walls, area)
    {
        Bedrooms = bedrooms;
        Owner = owner;
        //System.Console.WriteLine("This new Building will become a House with a wall, area, bedrooms and an owner"); //do not need as the 'this' in the argument calls the constructor above to include the WriteLine
    }

    //ToString Method
    public override string ToString()
    {
        return "{walls:" + Walls + ",area:" + Area + ",bedrooms:" + Bedrooms + ",owner:'" + Owner + "'}";
    }

}