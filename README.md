# 🚗 Parking Lot System in C#

Welcome to the **Parking Lot System**, a fully interactive and educational **C#/.NET** console application simulating a real-world parking environment.

---

## 🎯 Overview

This project allows users to:

- 🚙 Register vehicle entry
- 📋 List all parked vehicles
- ❌ Remove a vehicle and calculate its total cost
- 🔍 Validate inputs and handle errors
- 💵 Use a pricing formula based on initial fee and hourly rate

---

## 📸 Interactive Demo

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
```

---

## 📌 Features

- ✅ Register vehicle entry  
- ✅ List all parked vehicles  
- ✅ Remove vehicle and calculate total price  
- ✅ Validate user inputs and handle errors  
- ✅ Case-insensitive plate checks  
- ✅ Price formula: `initialPrice + (pricePerHour * hours)`  
- ✅ Real-time feedback and confirmation messages  
- ✅ Clean and modular code with full encapsulation  

---

## 💡 Business Logic

The total price is calculated as:

```csharp
decimal totalAmount = initialPrice + (pricePerHour * hours);
```

- The system ensures input validity using `TryParse`.
- Plates are stored and compared in uppercase for consistency.
- All features are encapsulated in the `Parking` class.

---

## 🧠 Skills Practiced

| 💡 Concept                           | ✅ Applied |
|-------------------------------------|-----------|
| Object-Oriented Programming (OOP)   | ✅ Yes     |
| Generic Lists (`List<string>`)      | ✅ Yes     |
| Console Input/Output                | ✅ Yes     |
| Control Flow (if, switch, foreach)  | ✅ Yes     |
| Exception Handling & TryParse       | ✅ Yes     |
| Encapsulation & Clean Architecture  | ✅ Yes     |

---

## 🛠️ Tech Stack

- 💻 **.NET SDK (C#)**  
- 🧱 Object-Oriented Programming  
- 🧪 Visual Studio / VS Code  
- 🖥️ Console Application (CLI)  

---

## 🚀 Roadmap & Upgrades

| Feature                                     | Status         

| Save data to file                           | 🛠️ In progres  |

| GUI using **WinForms**                      | 🛠️ In progress |

| Unit testing with **xUnit**                 | ⏳ Planned     |

| Apply **SOLID principles**                  | ⏳ Planned     |

| Database integration (**SQLite/SQL Server**)| ⏳ Planned     |

---

## 🧭 How to Run

### 📥 Clone the Repository

```bash
git clone https://github.com/thneri95/Park-Csharp
cd parking-system-csharp
```

### 🛠️ Open in IDE

- Launch **Visual Studio** or **VS Code**
- Open the folder or `.sln` file

### ▶️ Run the Project

- Press `F5` **or**
- Use terminal:

```bash
dotnet run
```

---

## 📂 Project Structure

```
/ParkingSystem
│
├── Models/
│   └── Parking.cs          # Core class with vehicle logic
├── Program.cs              # Console interface
├── README.md               # Project documentation
└── ParkingSystem.csproj    # Project config
```

---

## 🙋‍♂️ Author

**Tiago Neri**  
💼 Finance Specialist +
💻 Full Stack Developer  

🔗 [LinkedIn](https://www.linkedin.com/in/tiago-neri-cfa-if-50935814b/)  


