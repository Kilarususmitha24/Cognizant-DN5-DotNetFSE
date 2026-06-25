BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 5000
WHERE EmpId = 1;

/* Do not commit immediately */

-- In another session:
SELECT *
FROM Employees
WHERE EmpId = 1;

COMMIT TRANSACTION;