DECLARE @EmployeeName VARCHAR(50);

DECLARE EmployeeCursor CURSOR
FOR
SELECT EmpName
FROM Employees;

-- Open Cursor
OPEN EmployeeCursor;

-- Fetch Records
FETCH NEXT FROM EmployeeCursor
INTO @EmployeeName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @EmployeeName;

    FETCH NEXT FROM EmployeeCursor
    INTO @EmployeeName;
END;

-- Close Cursor
CLOSE EmployeeCursor;

-- Remove Cursor
DEALLOCATE EmployeeCursor;