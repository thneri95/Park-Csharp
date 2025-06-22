# 🚗 Parking Lot System in C#

A simple and educational console application developed in **C# with .NET**, simulating a basic parking lot system. It allows users to **register**, **list**, and **remove vehicles**, calculating parking fees based on time spent.

---

## 📸 Demo

```bash
Welcome to the parking lot system!
Enter the initial parking price:
> 5
Now enter the hourly rate:
> 2

Select an option:
1 - Register vehicle
2 - Remove vehicle
3 - List vehicles
4 - Exit
📌 Features
✅ Register vehicle entry

✅ List all parked vehicles

✅ Remove vehicle and calculate total price

✅ Validate user inputs and handle errors

✅ Price formula: initialPrice + (pricePerHour * hours)

💡 Business Logic
csharp
Copy
Edit
decimal totalAmount = initialPrice + (pricePerHour * hours);
Includes user-friendly prompts, case-insensitive plate checks, and safe input parsing.

🧠 Skills Practiced
Concept	Applied? ✅
Object-Oriented Programming (OOP)	✅
Generic Lists (List<string>)	✅
Console I/O	✅
Control Flow (if, switch, foreach)	✅
Exception & Input Handling	✅
Encapsulation & Clean Code	✅

🛠️ Tech Stack
💻 .NET SDK (C#)

🧱 Object-Oriented Programming

🧪 Visual Studio / VS Code

🖥️ Console Application (CLI)

🚀 Roadmap & Upgrades
Feature	Status
Save data to file	✅ Done
GUI using WinForms	🛠️ In progress
Unit testing with xUnit	⏳ Planned
Apply SOLID principles	⏳ Planned
Database integration (SQLite/SQL Server)	⏳ Planned

🧭 How to Run
Clone the repository

bash
Copy
Edit
git clone https://github.com/yourusername/parking-system-csharp.git
cd parking-system-csharp
Open the project in Visual Studio or VS Code

Run the project

Press F5 or use the terminal:

bash
Copy
Edit
dotnet run
📂 Project Structure
bash
Copy
Edit
/ParkingSystem
│
├── Models/
│   └── Parking.cs          # Core class with vehicle logic
├── Program.cs              # Console interface
├── README.md               # Project documentation
└── .csproj                 # Project config
🙋‍♂️ Author
Tiago Neri
💼 Finance Specialist & 💻 Full Stack Developer
