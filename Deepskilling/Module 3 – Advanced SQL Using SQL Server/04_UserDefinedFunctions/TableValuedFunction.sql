CREATE FUNCTION GetEmployeesByDepartment
(
    @Department VARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Employees
    WHERE Department = @Department
);
GO

SELECT *
FROM dbo.GetEmployeesByDepartment('IT');