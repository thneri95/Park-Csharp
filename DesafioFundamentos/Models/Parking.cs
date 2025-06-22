namespace ParkingSystem.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter the license plate of the vehicle to park:");
            string plate = Console.ReadLine()?.ToUpper().Trim();

            if (!string.IsNullOrEmpty(plate))
            {
                vehicles.Add(plate);
                Console.WriteLine($"Vehicle with plate {plate} has been successfully parked.");
            }
            else
            {
                Console.WriteLine("Invalid plate. Please try again.");
            }
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the license plate of the vehicle to remove:");
            string plate = Console.ReadLine()?.ToUpper().Trim();

            if (vehicles.Any(x => x == plate))
            {
                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                if (int.TryParse(Console.ReadLine(), out int hours) && hours >= 0)
                {
                    decimal totalAmount = initialPrice + (pricePerHour * hours);
                    vehicles.Remove(plate);
                    Console.WriteLine($"The vehicle {plate} was removed and the total price is: ${totalAmount:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid input for hours. Operation cancelled.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please check the license plate and try again.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Currently parked vehicles:");
                foreach (string plate in vehicles)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles parked.");
            }
        }
    }
}
