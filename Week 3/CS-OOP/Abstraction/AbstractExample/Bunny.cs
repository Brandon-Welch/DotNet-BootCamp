using System.Buffers;

class Bunny : Animal, IHerbivore
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Cluck!");
    }

    // internal void EatPlant()
    // {
    //     System.Console.WriteLine("Carrots");
    // }
}