# Employee Management System in CSharp

A Windows Forms application for managing employee data.

## Build Prerequisites

- Visual Studio 2019 or later with the .NET desktop development workload
- .NET Framework 4.7.2 or higher
- SQL Server Express LocalDB (usually installed with Visual Studio)

## Restoring the Database

1. Using SQL Server Management Studio or the **SQL Server Object Explorer** in Visual Studio, create a new LocalDB database named `emp`.
2. Execute the following SQL to create the necessary tables:

```sql
CREATE TABLE users(
    id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    date_register DATETIME NOT NULL
);

CREATE TABLE employees(
    id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id NVARCHAR(50) NOT NULL,
    full_name NVARCHAR(100) NOT NULL,
    gender NVARCHAR(10) NOT NULL,
    contact_number NVARCHAR(50),
    position NVARCHAR(50),
    salary INT NOT NULL,
    insert_date DATETIME NOT NULL,
    status NVARCHAR(20),
    update_date DATETIME NULL,
    delete_date DATETIME NULL
);
```

3. If your `emp.mdf` file is stored in a different location, update the connection strings in the C# project accordingly.

## Basic Usage

1. Open `EmployeeDatarecordSystem.sln` with Visual Studio.
2. Build the solution.
3. Run the project to launch the login screen.
4. Use **Sign Up** to create your first user account.
5. Log in and navigate the dashboard to add employees or manage salaries.
