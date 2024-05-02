interface ICarnivore //c# requires interfaces to have an 'I' at the beginning of the name to dictate its an interface
{

    public int Value { get; set; } //not needed, just reference that it can be done (assumed public like below)

    void EatMeat(); //assumed to be abstract (traditionally) so implied default access moddifier in Interfaces is 'Public' bc (traditionally) 'Private' would not have made sense.


}