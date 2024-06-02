namespace VehicleAPI.Models;

public class Vehicle
{
    public int VehicleId { get; set; }
    public int VehicleYear { get; set; }
    public string VehicleMake { get; set; }
    public String VehicleModel { get; set; }
    public bool NeedsMaintenance { get; set; }

public Vehicle()
{

}

public Vehicle (int VehicleId, int VehicleYear, string VehicleMake, string VehicleModel, bool NeedsMaintenance)
{
    this.VehicleId = VehicleId;
    this.VehicleYear = VehicleYear;
    this.VehicleMake = VehicleMake;
    this.VehicleModel = VehicleModel;
    this.NeedsMaintenance = NeedsMaintenance;
}

}