CREATE VIEW EmployeeView
AS
SELECT
    EmpId,
    EmpName,
    Department,
    Salary
FROM Employees;

SELECT * FROM EmployeeView;