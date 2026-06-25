ALTER VIEW EmployeeView
AS
SELECT
    EmpId,
    EmpName,
    Department
FROM Employees;

SELECT * FROM EmployeeView;