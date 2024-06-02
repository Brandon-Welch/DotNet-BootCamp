using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Models;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("[controller]")] //http://localhost:port/Vehicle
public class PizzaController : ControllerBase
{
    //a dependency (dependency injection)
    //public ExampleClass exampleClass;

    /*
    This controller will receive http requests to the path /Pizza
    based on the http method it receives, it will direct th request to different "Actions"
    */
    
    public static List<Pizza> Pizzas = new List<Pizza>
    {
        new Pizza(1, 10, "Mozzarella", "Tomato", "Pepporoni"),
        new Pizza(2, 8, "Mozzarella", "Alfredo", "Chicken, Spinach, Onion"),
        new Pizza(3, 12, "Icing", "Cherry Preserves", "Graham Cracker Dust, Oats"),
        new Pizza(4, 12, "Mozzarella", "Buffalo, Ranch", "Chicken, Bacon, Onion"),
        new Pizza(5, 10, "Mozzarella", "Tomato", "Pepporoni, Beer, Green Pepper, Onion, Black Olives, Bacon"),
    };
    
    //  GET all Pizzas
    //  This is the begining part of a GET action to the path /Pizza
    //  You need this to let the controller know that this method should called when a GET request is sent to /Pizza
    [HttpGet]
    public IActionResult GetPizzas()
    {
        //return Ok("You hit the right endpoint");
        return Ok(Pizzas);
    }
    
    //  GET a Pizza by ID
    //  This is expecting the client to send GET request to /Pizza and also provide an /Id
    //  This ID needs to be an integer
    //  Example
    //      http://localhost:port/Pizza/1
    //      http://localhost:port/Pizza/39933
    //      http://localhost:port/Pizza/1324
    [HttpGet("{Id}")]
    public IActionResult GetPizzaById(int Id)
    {
        //tests to ensure we are returing the vehID 3 before we proceed adding actual Pizza details
        //System.Console.WriteLine(Id); 
        //return Ok(Id);

        //  This is an exampleof funcitonal programming
        //  We have an array and we want to filter through that array and grab the first thing that matches the correct Id
        //  We have created a LINQ onto the Vehicle array that will filter through each of hte vehicle and check to see if the PizzaID matches the ID that was passed in
        //  IF it matches, then it will return that Pizza
        Pizza pizza = Pizzas.Find(p => p.PizzaId == Id);
        if (pizza == null)
        {
            return NotFound();
        }
        return Ok(pizza);

    }

    //POST a new Pizza
    /*
        We send the data in the HTTP Request Body as a JSON Object
        This JSON has to match the field name sof the model we are using bc we are using hte model Pizza inside the paramaters, it will be what is used to validate if request body is in right format

    */
    [HttpPost]
    public IActionResult PostPizza(Pizza pizza)
    {
        /* //  test making sure the post is working
        System.Console.WriteLine(pizza.PizzaTopping);
        return Ok();
        */

        pizza.PizzaId = Pizzas.Count + 1;
        Pizzas.Add(pizza);
        return Ok();
    }

    //PUT an update on an existing Pizza
    [HttpPut("{ID}")]
    public IActionResult PutPizza(int Id, Pizza updatedPizza)
    {
        //System.Console.WriteLine(Id);
        //System.Console.WriteLine(updatedPizza);

        int index = Pizzas.FindIndex(p => p.PizzaId == Id);
        if (index == null)
        {
            return NotFound();
        }
        Pizzas[index] = updatedPizza;
        return Ok();
    }

    //DELECT an existing Pizza 
    [HttpDelete("{Id}")]
    public IActionResult DeletePizza(int Id)
    {
        foreach (Pizza pizza in Pizzas)
        {
            if(pizza.PizzaId == Id)
            {
                Pizzas.Remove(pizza);
                return Ok(pizza);
            }

        }
        return NotFound();
    }
}