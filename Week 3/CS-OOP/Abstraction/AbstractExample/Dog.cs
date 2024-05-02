class Dog : Animal, ICarnivore
{
    
    public string FavoriteChewToy { get; set; }
    public int Value { get; set; }


    public void EatMeat()
    {
        System.Console.WriteLine("Bison");
    }
    public Dog()
    {
        FavoriteChewToy = "";
    }    
    
    public override void MakeSound()
    {
        System.Console.WriteLine("Woof!");
    }

}