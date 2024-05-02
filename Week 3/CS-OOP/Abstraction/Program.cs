//key phrase to remember: intention over implementation
    //we care more about what its supposed to do than how it actually does it

using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        //Animal a = new(); //bc Animal class is Abstract,  makes Animal no long a class we can make objects from
        Dog d1 = new Dog();
        Cat c1 = new();


        System.Console.WriteLine("---Dog 1---");
        d1.Species = "Mastiff";
        System.Console.WriteLine("This animal's species is: " + d1.Species);
        System.Console.Write("Why does this animal sleep? ");
        d1.Sleep();
        System.Console.Write("This animal says: ");
        d1.MakeSound();
        d1.FavoriteChewToy = "Squeeky Toy"; //specific to dogs
        System.Console.WriteLine("Favorite Toy: " + d1.FavoriteChewToy);
        System.Console.Write("This animal eats: ");
        d1.EatMeat();
        d1.Value = 100;
        System.Console.WriteLine(d1.Value);
        System.Console.WriteLine("----------");

        System.Console.WriteLine("---Cat 1---");
        c1.Species = "Unknown Stray";
        System.Console.WriteLine("This animal's species is: " + c1.Species);
        System.Console.Write("Why does this animal sleep? ");
        c1.Sleep();
        System.Console.Write("This animal says: ");
        c1.MakeSound();
        //c1.FavoriteChewToy = "feather on string"; //specific to dogs so wont work as cat cannot inherit from dog....
        //System.Console.WriteLine("Favorite Toy: " + d1.FavoriteChewToy);
        System.Console.Write("This animal eats: ");
        c1.EatMeat();
        System.Console.WriteLine("----------");

        System.Console.WriteLine("---Bunny 1---");
        Bunny b1 = new();
        System.Console.Write("This animal says: ");
        b1.MakeSound();
        System.Console.Write("Why does this animal sleep? ");
        b1.Sleep();
        System.Console.Write("This animal eats: ");
        //b1.EatPlant(); //currnt have override in Bunny commented out, uncomment to fix
        System.Console.WriteLine("----------");
        
        System.Console.WriteLine("---Bunny 2---");
        IHerbivore b2 = new Bunny(); //seems to be the only way to use the concrete interface method right now without overriding every method
        System.Console.Write("This animal eats: ");
        b2.EatPlant();
        System.Console.WriteLine("----------");


        Animal[] animals = new Animal[4];
        animals[0] = d1;
        animals[1] = c1;
        animals[2] = b1;

        ICarnivore[] carnivores = new ICarnivore[3];
        carnivores[1] = d1;
        carnivores[2] = c1;
        //carnivores[3] = b1; //wont work since bunny isnt a carnivore (i.e not in the carnivore interface)

        IAdorable[] adorables = new IAdorable[3];
        adorables[0] = c1;
        adorables[1] = b1;

        TeddyBear bear = new();
        adorables[2] = bear;

    }
}