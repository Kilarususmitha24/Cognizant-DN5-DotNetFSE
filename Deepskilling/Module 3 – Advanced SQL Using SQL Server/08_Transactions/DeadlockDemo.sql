/* Session 1 */
BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpId = 1;

WAITFOR DELAY '00:00:10';

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpId = 2;

COMMIT TRANSACTION;

/* Session 2 */
BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpId = 2;

WAITFOR DELAY '00:00:10';

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpId = 1;

COMMIT TRANSACTION;