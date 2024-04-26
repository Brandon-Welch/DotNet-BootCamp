class Fridge
{
    //Fields

    public string drink;
    public string vegetable;
    public string fruit;
    public string condiment;
    public int temperature;

    //No Arg Constructor

    public Fridge()
    {
        temperature = 34;
    }

    //Full-Arg Constructor - meaning a choice of us providing ALL the values for our fields.

    public Fridge(string drink, string vegetable, string fruit, string condiment, int temperature)
    {
        this.drink = drink;
        this.vegetable = vegetable;
        this.fruit = fruit;
        this.condiment = condiment;
        this.temperature = temperature;

    }
    //Methods
 
    public void Sound()
    {
        System.Console.WriteLine("Crunch");
    }

    public void DoorOpen()
    {
        temperature = temperature + 1;
        System.Console.WriteLine("The temperature is increasing and is currently: " + temperature + ".");
    }

        public void DoorClosed()
    {
        temperature = temperature - 1;
        System.Console.WriteLine("Thanks, the temperature is back down to: " + temperature + ".");
    }


    //ToString
    public override string ToString()
    {
        string str ="";
        str += "{Drink = " + drink;
        str += "; Vegetable = " + vegetable;
        str += "; Fruit = " + fruit;
        str += "; Condiment = " + condiment;
        str += "; Temperature = " + temperature + "}";
        return str;
    }


}

//door open increase temp by 2
//door close decrease by 1
