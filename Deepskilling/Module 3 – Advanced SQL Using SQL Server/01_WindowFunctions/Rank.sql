SELECT
    EmpId,
    EmpName,
    Salary,
    RANK() OVER (ORDER BY Salary DESC) AS EmployeeRank
FROM Employees;