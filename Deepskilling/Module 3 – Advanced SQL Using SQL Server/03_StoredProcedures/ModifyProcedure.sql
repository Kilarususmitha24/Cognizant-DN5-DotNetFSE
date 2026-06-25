ALTER PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT
        EmpId,
        EmpName,
        Department
    FROM Employees;
END;
GO

EXEC GetAllEmployees;