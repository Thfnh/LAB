CREATE DATABASE EmployeeDB;
GO

CREATE TABLE Employee(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Salary DECIMAL(18,2),
    Status BIT 
);


select * from [dbo].[Employees]