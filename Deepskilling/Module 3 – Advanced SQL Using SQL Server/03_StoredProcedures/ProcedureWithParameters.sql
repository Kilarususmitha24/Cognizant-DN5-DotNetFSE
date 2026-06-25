CREATE PROCEDURE GetEmployeeByDepartment
    @Department VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE Department = @Department;
END;
GO

EXEC GetEmployeeByDepartment 'IT';