CREATE VIEW EmployeeSalaryView
WITH SCHEMABINDING
AS
SELECT
    EmpId,
    Salary
FROM dbo.Employees;
GO

CREATE UNIQUE CLUSTERED INDEX IX_EmployeeSalaryView
ON EmployeeSalaryView(EmpId);