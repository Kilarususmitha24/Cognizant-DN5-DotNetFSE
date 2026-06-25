SELECT
    EmpId,
    EmpName,
    Salary,
    AVG(Salary) OVER() AS AverageSalary
FROM Employees;