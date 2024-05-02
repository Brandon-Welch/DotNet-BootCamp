class Cat : Animal, ICarnivore
{
    public int Value { get; set; }



    public void EatMeat() //inheritance from ICarnivore interface
    {
        System.Console.WriteLine("Fish");
    }

    public override void Sleep()
    {
        System.Console.WriteLine("Animal rests to prepare for pouncing!");
    }
    public override void MakeSound()  //inheritance from Animal class
    {
        System.Console.WriteLine("Meow!");
    }

}