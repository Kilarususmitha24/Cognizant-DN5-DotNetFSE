CREATE TABLE Employees (
    EmpId INT,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1,'John','IT',60000),
(2,'Mary','IT',75000),
(3,'David','HR',50000),
(4,'Sara','HR',65000),
(5,'Tom','Finance',70000);

SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum
FROM Employees;