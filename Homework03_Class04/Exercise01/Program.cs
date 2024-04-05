using Exercise01.Domain.Models;
using System.ComponentModel.DataAnnotations;
using Validator = Exercise01.Domain.Models.Validator;

//Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
//Create two classes Car and Bike that inherit from Vehicle. Car has property FuelTank (int) and Countries in which it is produced and Bike has property Color.
//Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
//Class Car also has method PrintVehicle that prints the Type and the Countries in which it is produced.
//Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.
//Create a static class that serves as a DB, that has list of Vehicles. In this list put objects of type Car, Bike and Vehicle.
//In the main program call PrintVehicle for each object in the list in the db.
//Create a static class called Validator, that contains a method Validate, that receives a Vehicle and validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
//Call Validate from main Program with a couple of objects.

//Vehicle 

Vehicle vehicle1 = new Vehicle(1, "Vehicle", 2022, 2222);
Vehicle vehicle2 = new Vehicle(2, "", 2018, 3333);
Vehicle vehicle3 = new Vehicle(3, "Vehicle", 0, 4444);

//Car

Car car1 = new Car(12,"BMW",2023,1234,50,"Germany");
Car car2 = new Car(29,"Toyota",2021,0987,40,"Japan");
Car car3 = new Car(0,"Audi",2024,7654,60,"Germany");

//Bike

Bike bike1 = new Bike(4, "Scott", 2019, 0000, "Green");
Bike bike2 = new Bike(6, "Trek", 2023, 5555, "Blue");
Bike bike3 = new Bike(8, "BMC", 2018, 0909, "Black");

VehicleDb.Vehicles.Add(vehicle1);
VehicleDb.Vehicles.Add(vehicle2);
VehicleDb.Vehicles.Add(vehicle3);
VehicleDb.Vehicles.Add(car1);
VehicleDb.Vehicles.Add(car2);
VehicleDb.Vehicles.Add(car3);
VehicleDb.Vehicles.Add(bike1);
VehicleDb.Vehicles.Add(bike2);
VehicleDb.Vehicles.Add(bike3);

foreach(var vehicle in VehicleDb.Vehicles)
{
    vehicle.PrintVehicle();
}

Validator.Validate(car1);

foreach(var vehicle in VehicleDb.Vehicles )
{
   if(Validator.Validate(vehicle))
    {
        vehicle.PrintVehicle();
    }
    else
    {
        Console.WriteLine($"Invalid input!! Id : {vehicle.Id}");
    }
}

