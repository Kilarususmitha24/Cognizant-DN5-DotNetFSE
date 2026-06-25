-- Cursor Approach

DECLARE @TotalSalary INT;

SELECT @TotalSalary = SUM(Salary)
FROM Employees;

PRINT 'Total Salary = ' + CAST(@TotalSalary AS VARCHAR);