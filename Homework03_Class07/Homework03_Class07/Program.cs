using Homewrok03_Class07.Domain.Models;

Console.WriteLine("1.Filter all cars that have Origin from Europe and print them in console.");

List<Car> carsWithOriginFromEurope = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();
ListHelper.PrintInfo(carsWithOriginFromEurope);

Console.WriteLine("=============================");


Console.WriteLine("2.Filter all cars that have more that 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result and print them in console.");

List<Car> carsMoreThan6Cylinders = CarsData.Cars.Where(x => x.Cylinders > 6).ToList();
List<Car> carsThatHave4CylindersAnd110 = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower == 110).ToList();

List<Car> allCars = carsMoreThan6Cylinders.Concat(carsThatHave4CylindersAnd110).ToList();
ListHelper.PrintInfo(allCars);

Console.WriteLine("============================");

Console.WriteLine("3.Count all cars based on their Origin and print the result in console. Example outpur \"US 10 models\\n Eu 15 Models");

List<string> usCars = CarsData.Cars.Where(x => x.Origin == "US").Select(x => x.Origin).ToList();
List<string> euCars = CarsData.Cars.Where(x => x.Origin == "Europe").Select(x => x.Origin).ToList();
List<string> japanCars = CarsData.Cars.Where(x => x.Origin == "Japan").Select(x => x.Origin).ToList();

ListHelper.CountOfCars(usCars, euCars, japanCars);

Console.WriteLine("=============================");


Console.WriteLine("4.Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;");

List<Car> carsMoreThan200HorsePower = CarsData.Cars.Where(x => x.HorsePower > 200).ToList();
ListHelper.PrintInfo(carsMoreThan200HorsePower);


if (carsMoreThan200HorsePower.Any())
{
    double lowestMPG = carsMoreThan200HorsePower.Min(x => x.MilesPerGalon);
    double highestMPG = carsMoreThan200HorsePower.Max(x => x.MilesPerGalon);
    double averageMPG = carsMoreThan200HorsePower.Average(x => x.MilesPerGalon);

    Console.WriteLine($"Lowest MPG : {lowestMPG}");
    Console.WriteLine($"Highest MPG : {highestMPG}");
    Console.WriteLine($"Average MPG : {averageMPG}");
}
else
{
    Console.WriteLine("There is no car with more than 200 horsepower.");
}

Console.WriteLine("=====================================");

Console.WriteLine("5.Find and print name Model of cars that starts with \"C\" and weight more than 3500 in order by Weight - ASCENDING ORDER.");

List<string> namesOfModelStartWithC = CarsData.Cars.Where(x => x.Model.StartsWith("C") && x.Weight > 3500).OrderBy(x => x.Weight).Select(x => x.Model).ToList();
if(namesOfModelStartWithC != null)
{
    ListHelper.PrintModels(namesOfModelStartWithC);
}
else
{
    Console.WriteLine("No car starts with \"C\" and weight more than 3500");
}

Console.WriteLine("6.Find and print first car that Origin is Japan and HorsePower is more than 80.");
Car car = CarsData.Cars.FirstOrDefault(x => x.Origin == "Japan" && x.HorsePower > 80);
Console.WriteLine(car.Model);


