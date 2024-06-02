namespace PizzaAPI.Models;

public class Pizza
{
    public int PizzaId { get; set; }
    public int PizzaSlices { get; set; }
    public string PizzaCheese { get; set; }
    public string PizzaSauce { get; set; }
    public string PizzaTopping { get; set; }
    

public Pizza()
{

}

public Pizza (int PizzaId, int PizzaSlices, string PizzaCheese, string PizzaSauce, string PizzaTopping)
{
    this.PizzaId = PizzaId;
    this.PizzaSlices = PizzaSlices;
    this.PizzaCheese = PizzaCheese;
    this.PizzaSauce = PizzaSauce;
    this.PizzaTopping = PizzaTopping;
}

}