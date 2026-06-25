SELECT
    EmpId,
    EmpName,
    Salary,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseEmployeeRank
FROM Employees;