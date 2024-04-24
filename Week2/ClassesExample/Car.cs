class Car
{
    //Fields
    public int year;
    public string make;
    public string model;
    public string color;
    public int mileage;

    //Methods
    public void Honk()
    {
        System.Console.WriteLine("Ah-ooga!");
    }

    public void Exhaust()
    {
        System.Console.WriteLine("Vroooom!");
    }

    public void Drive(int milesDriven)
    {
        mileage += milesDriven;
        System.Console.WriteLine("The new total milage is: " + mileage + ".");
    }

//example of a Getter instead of making the field (directly) public
// public string GetColor()
// {
//     return color
// }


}