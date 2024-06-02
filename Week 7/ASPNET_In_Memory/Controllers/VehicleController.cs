using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;

namespace VehicleAPI.Controllers;

[ApiController]
[Route("[controller]")] //http://localhost:port/Vehicle
public class VehicleController : ControllerBase
{
    //a dependency (dependency injection)
    //public ExampleClass exampleClass;

    /*
    This controller will receive http requests to the path /Vehilce
    based on the http method it receives, it will direct th request to different "Actions"
    */
    
    public static List<Vehicle> Vehicles = new List<Vehicle>
    {
        new Vehicle(1, 2010, "Toyota", "Camry", false),
        new Vehicle(2, 2015, "Honda", "CRV", false),
        new Vehicle(3, 2020, "Subaru", "Outback", false),
        new Vehicle(4, 2007, "Dodge", "Challenger", true),
        new Vehicle(5, 2001, "Ford", "F150", true),
    };
    
    //  GET all vehicles
    //  This is the begining part of a GET action to the path /Vehcile
    //  You need this to let the controller know that this method should called when a GET request is sent to /Vehicle
    [HttpGet]
    public IActionResult GetVehicles()
    {
        //return Ok("You hit the right endpoint");
        return Ok(Vehicles);
    }
    
    //  GET a vehicle by ID
    //  This is expecting the client to send GET request to /Vehicle and also provide an /Id
    //  This ID needs to be an integer
    //  Example
    //      http://localhost:port/Vehicle/1
    //      http://localhost:port/Vehicle/39933
    //      http://localhost:port/Vehicle/1324
    [HttpGet("{Id}")]
    public IActionResult GetVehicleById(int Id)
    {
        //tests to ensure we are returing the vehID 3 before we proceed adding actual vehicle details
        //System.Console.WriteLine(Id); 
        //return Ok(Id);

        //  This is an exampleof funcitonal programming
        //  We have an array and we want to filter through that array and grab the first thing that matches the correct Id
        //  We have created a LINQ onto the Vehicle array that will filter through each of hte vehicle and check to see if the VehcileID matches the ID that was passed in
        //  IF it matches, then it will return that vehilce
        Vehicle vehicle = Vehicles.Find(v => v.VehicleId == Id);
        return Ok(vehicle);

        //  Alternate way of doing it to iterate through each and if not found, will return a 404 error
        /*
        foreach (Vehicle vehicle in Vehicles)
        {
            if(vehicle.VehicleId == Id)
            {
                return Ok(vehicle);
            }

        }
        return NotFound();
        */
    }

    //POST a new vehicle
    /*
        We send the data in the HTTP Request Body as a JSON Object
        This JSON has to match the field name sof the model we are using bc we are using hte model vehicle inside the paramaters, it will be what is used to validate if request body is in right format

    */
    [HttpPost]
    public IActionResult PostVehicle(Vehicle vehicle)
    {
        /* //  test making sure the post is working
        System.Console.WriteLine(vehicle.VehicleMake);
        return Ok();
        */

        vehicle.VehicleId = Vehicles.Count + 1;
        Vehicles.Add(vehicle);
        return Ok();
    }

    //PUT an update on an existing vehicle
    [HttpPut("{ID}")]
    public IActionResult PutVehicle(int Id, Vehicle updatedVehicle)
    {
        //System.Console.WriteLine(Id);
        //System.Console.WriteLine(updatedVehicle);

        int index = Vehicles.FindIndex(v => v.VehicleId == Id);
        Vehicles[index] = updatedVehicle;
        return Ok();
    }

    //DELECT an existing vehicle 
    [HttpDelete("{Id}")]
    public IActionResult DeleteVehicle(int Id)
    {
        foreach (Vehicle vehicle in Vehicles)
        {
            if(vehicle.VehicleId == Id)
            {
                Vehicles.Remove(vehicle);
                return Ok(vehicle);
            }

        }
        return NotFound();
    }
}