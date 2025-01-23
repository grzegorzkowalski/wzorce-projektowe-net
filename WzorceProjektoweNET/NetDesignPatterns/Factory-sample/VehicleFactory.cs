namespace Factory_sample
{
    // Fabryka tworząca pojazdy
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                _ => throw new ArgumentException("Nieznany typ pojazdu"),
            };
        }
    }
}
