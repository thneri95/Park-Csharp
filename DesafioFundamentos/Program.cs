using ParkingSystem.Models;

// Set encoding to UTF8 to display special characters correctly
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking lot system!\n" +
                  "Enter the initial parking price:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the hourly rate:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instantiate the Parking class with the values provided
Parking parking = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Menu loop
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Select an option:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();
}

Console.WriteLine("Program has ended.");
