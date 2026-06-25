CREATE TRIGGER trg_AfterUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    PRINT 'Employee Record Updated Successfully';
END;
GO

UPDATE Employees
SET Salary = 85000
WHERE EmpId = 6;