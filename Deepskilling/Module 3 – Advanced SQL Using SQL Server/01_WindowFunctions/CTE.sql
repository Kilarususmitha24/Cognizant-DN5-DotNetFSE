WITH HighSalaryEmployees AS
(
    SELECT *
    FROM Employees
    WHERE Salary > 60000
)

SELECT *
FROM HighSalaryEmployees;