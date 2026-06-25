CREATE TABLE EmployeeLog
(
    LogId INT IDENTITY(1,1),
    Message VARCHAR(100),
    LogDate DATETIME
);
GO

CREATE TRIGGER trg_AfterInsert
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeLog(Message, LogDate)
    VALUES('Employee Record Inserted', GETDATE());
END;
GO

INSERT INTO Employees
VALUES(6,'Alex','IT',80000);

SELECT * FROM EmployeeLog;