# 🚀 E-Space Management System

E-Space is a C# Windows Forms application developed to manage information related to space colonization and exploration.

This project was developed as part of the HND Software Engineering coursework.

## ✨ Features

- User Login Authentication
- Dashboard
- Colonist Management
- Colonist Contact Management
- Colonist Qualification Management
- Astronomer Management
- Astronomer Qualification Management
- Dependent Management
- House Management
- Trip Management
- E-Jet Management
- Job Management
- SQL Server Database Integration

## 🛠️ Technologies Used

- C#
- .NET / Windows Forms
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Visual Studio 2022
- ADO.NET

## 🗄️ Database

The project uses a Microsoft SQL Server database named:

```text
ESPACESOLUTION
```

A database creation script is included in:

```text
Database/ESPACESOLUTION.sql
```

### Database Setup

1. Open SQL Server Management Studio.
2. Connect to your SQL Server instance.
3. Open `Database/ESPACESOLUTION.sql`.
4. Execute the SQL script.
5. Verify that the `ESPACESOLUTION` database has been created.

## ⚙️ Configuration

The application currently connects to SQL Server using a connection string configured for the development machine.

If required, update the SQL Server connection in the project to match your SQL Server instance.

Example:

```text
Data Source=YOUR_SERVER\SQLEXPRESS;
Initial Catalog=ESPACESOLUTION;
Integrated Security=True;
Encrypt=False;
```

## ▶️ How to Run

1. Clone or download this repository.
2. Restore the `ESPACESOLUTION` database using the provided SQL script.
3. Open `ESpaceSolution.sln` in Visual Studio.
4. Check the SQL Server connection configuration.
5. Build the solution.
6. Run the application.

## 📁 Project Structure

```text
ESpaceSolution/
├── ESpaceSolution/                  # C# Windows Forms project
├── Database/
│   └── ESPACESOLUTION.sql    # Database script
├── Screenshots/              # Application screenshots
├── ESpaceSolution.sln
├── .gitignore
└── README.md
```

## 📸 Screenshots

Application screenshots can be added to the `Screenshots` directory.

## 📌 Project Type

HND Software Engineering Academic Project
