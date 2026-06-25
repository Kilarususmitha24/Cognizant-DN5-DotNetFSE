SELECT
    Department,
    SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY GROUPING SETS
(
    (Department),
    ()
);