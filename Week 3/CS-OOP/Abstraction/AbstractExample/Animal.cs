abstract class Animal //make abstract by adding abstract infront of class... makes Animal no long a class we can make objects from
{
    //Two Types of Methods you can make in Abstract Class:
    //  Concrete Method: these methods have an implementation (it does something)
    //  Abstract Method: these methods will not have an implementation (wont do anything) and any class (that is not also abstract) will have to provide the actual implementation

    public string Species { get; set; }

    public Animal()
    {
        Species = "";
    }

    public virtual void Sleep() //Concrete Method since it does something (prints a statement) ((had to make virtual so that cat class could override))
    {
        System.Console.WriteLine("Animal rests to recover energy");;
    }

    public abstract void MakeSound(); //Abstract method since it doesnt do anything, will rely on another class to provide the action
}