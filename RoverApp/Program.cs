// See https://aka.ms/new-console-template for more information
using RoverApp.Classes.Plato;
using RoverApp.Classes.Position;
using RoverApp.Classes.Vehicle;
using RoverApp.Enums;
using RoverApp.Validators;

Console.WriteLine("Hello, Rover!");

#region Start Vehicle 
Validator validator = new Validator();
Plato plato = new Plato(new Position(5, 5));
RoverVehicle vehicle = new RoverVehicle(plato, new Position(1, 2), Navigate.N, validator);

vehicle.Proc("LMLMLMLMM");


Plato plato1 = new Plato(new Position(5, 5));
RoverVehicle vehicle1 = new RoverVehicle(plato1, new Position(3, 3), Navigate.E, validator);
vehicle1.Proc("MMRMMRMRRM");


#endregion
#region Expected Output
if (!string.IsNullOrEmpty(vehicle.ErrorMesage))
{
    Console.WriteLine(vehicle.ErrorMesage.ToString());

}
else
{
    Console.WriteLine(vehicle.ToString());
}

if (!string.IsNullOrEmpty(vehicle1.ErrorMesage))
{
    Console.WriteLine(vehicle1.ErrorMesage.ToString());

}
else
{
    Console.WriteLine(vehicle1.ToString());
}

#endregion