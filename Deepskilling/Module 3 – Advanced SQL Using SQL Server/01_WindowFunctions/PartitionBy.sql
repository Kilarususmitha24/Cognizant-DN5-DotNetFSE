SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    ROW_NUMBER() OVER (
        PARTITION BY Department
        ORDER BY Salary DESC
    ) AS DepartmentRank
FROM Employees;