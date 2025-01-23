using Factory_sample;

Console.WriteLine("Podaj typ pojazdu (car/bike):");
string vehicleType = Console.ReadLine();

try
{
    IVehicle vehicle = VehicleFactory.CreateVehicle(vehicleType);
    vehicle.Drive();
}
catch (Exception ex)
{
    Console.WriteLine($"Błąd: {ex.Message}");
}