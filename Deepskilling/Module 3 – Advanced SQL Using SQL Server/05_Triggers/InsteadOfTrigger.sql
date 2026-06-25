CREATE TRIGGER trg_InsteadOfDelete
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    PRINT 'Delete Operation Not Allowed';
END;
GO

DELETE FROM Employees
WHERE EmpId = 1;