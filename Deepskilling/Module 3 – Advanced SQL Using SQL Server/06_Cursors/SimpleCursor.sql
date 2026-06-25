DECLARE @EmpName VARCHAR(50);

DECLARE EmployeeCursor CURSOR
FOR
SELECT EmpName
FROM Employees;

OPEN EmployeeCursor;

FETCH NEXT FROM EmployeeCursor
INTO @EmpName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Employee Name: ' + @EmpName;

    FETCH NEXT FROM EmployeeCursor
    INTO @EmpName;
END;

CLOSE EmployeeCursor;

DEALLOCATE EmployeeCursor;