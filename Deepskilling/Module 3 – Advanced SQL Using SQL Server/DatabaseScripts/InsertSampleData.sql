USE CompanyDB;
GO

INSERT INTO Departments
VALUES
(1,'IT'),
(2,'HR'),
(3,'Finance');

INSERT INTO Employees
VALUES
(101,'John','IT',60000),
(102,'Mary','IT',75000),
(103,'David','HR',50000),
(104,'Sara','HR',65000),
(105,'Tom','Finance',70000);

INSERT INTO Projects
VALUES
(1,'Employee Management System',500000),
(2,'Payroll System',300000),
(3,'Inventory Management System',450000);
GO