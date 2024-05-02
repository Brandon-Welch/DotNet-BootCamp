interface IHerbivore
{
    //"concrete methods" in interfaces can be done as well - 'Default' Method
    
    public virtual void EatPlant()
    {
        System.Console.WriteLine("Leaves");
    }
}