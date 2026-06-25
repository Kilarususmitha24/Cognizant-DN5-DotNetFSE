USE CompanyDB;
GO

CREATE TABLE Employees
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);

CREATE TABLE Departments
(
    DeptId INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Projects
(
    ProjectId INT PRIMARY KEY,
    ProjectName VARCHAR(100),
    Budget DECIMAL(12,2)
);
GO