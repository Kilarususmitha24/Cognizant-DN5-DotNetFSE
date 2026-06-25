-- Create Target Table
CREATE TABLE Employees_Target
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT
);

-- Create Source Table
CREATE TABLE Employees_Source
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT
);

-- Sample Data
INSERT INTO Employees_Target
VALUES
(1,'John',50000),
(2,'Mary',60000);

INSERT INTO Employees_Source
VALUES
(2,'Mary',65000),
(3,'David',55000);

-- MERGE Statement
MERGE Employees_Target AS TARGET
USING Employees_Source AS SOURCE
ON TARGET.EmpId = SOURCE.EmpId

WHEN MATCHED THEN
UPDATE SET
    TARGET.EmpName = SOURCE.EmpName,
    TARGET.Salary = SOURCE.Salary

WHEN NOT MATCHED BY TARGET THEN
INSERT (EmpId, EmpName, Salary)
VALUES (SOURCE.EmpId, SOURCE.EmpName, SOURCE.Salary);

SELECT * FROM Employees_Target;