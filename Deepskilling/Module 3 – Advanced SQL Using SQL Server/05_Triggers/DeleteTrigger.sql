CREATE TRIGGER trg_DeleteEmployee
ON Employees
AFTER DELETE
AS
BEGIN
    PRINT 'Employee Record Deleted';
END;
GO

DELETE FROM Employees
WHERE EmpId = 6;