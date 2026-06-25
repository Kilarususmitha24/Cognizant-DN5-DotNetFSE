BEGIN TRANSACTION OuterTransaction;

INSERT INTO Employees
VALUES (10,'James','IT',75000);

BEGIN TRANSACTION InnerTransaction;

INSERT INTO Employees
VALUES (11,'Robert','HR',65000);

COMMIT TRANSACTION InnerTransaction;

COMMIT TRANSACTION OuterTransaction;

SELECT * FROM Employees;