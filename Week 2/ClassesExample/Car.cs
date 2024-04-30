class Car
{
    //Fields
    public int year;
    public string make;
    public string model;
    public string color;
    public int mileage;

/*
    Constructors - a special type of method whose purpose is to help us create new objects of that class. Along with any other initial set up instructions we wish to provide.
    Syntax: 
        access_modified ClassName(potential parameters)  //Notice: no return type (i.e. void)
        {
            //what you want the constructor to do while setting up your object
                -Ex: setting initial values, etc.
        }

    C# will provide a "default" constructor when you do not explicitly create any constructions. As soon as you create even ONE constructor, the default constructor is no longer provided.
*/

    //Constructors

    //No Arg Constructor
    public Car()
    {
        color ="Black"; //would default the color alue to Black IF a color is not provided
        mileage = (2024 - year) * 1;
    }

    //We can have multiple constructors - the only requirement is that the parameters have to be some ne wunique conbination of types.
    //Overloaded Methods -> have multiple implementations to the same named method - with different __________________________

    public Car(string newColor) //one argument constructor/method - not a common constructor you would use
    {
        //color = newColor;
        this.color = color; //'this' is a placeholder that refers to the object in reference - the object actively getting built (ex. car1.year = 2020, car1 is the object in reference)
    }

    //Full-Arg Constructor - meaning a choice of us providing ALL the values for our fields.
    public Car(string color, string make, string model, int year, int mileage)
    {
        this.color = color; 
        this.make = make; 
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }


    //Bonus
    //Copy Constructor
    public Car(Car car)
    {
        color = car.color;
        make = car.make;
        model = car.model;
        year = car.year;
        mileage = car.mileage;
    }






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

    public override string ToString()
    {
        string str ="";
        str += "{Color= " + color;
        str += "; Year= " + year;
        str += "; Make= " + make;
        str += "; Model= " + model;
        str += "; Mileage= " + mileage + "}";

        return str;
    }

//example of a Getter instead of making the field (directly) public
// public string GetColor()
// {
//     return color
// }


}