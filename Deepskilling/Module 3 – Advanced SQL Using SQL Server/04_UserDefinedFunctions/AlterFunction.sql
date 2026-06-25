ALTER FUNCTION GetAnnualSalary
(
    @MonthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @MonthlySalary * 12 + 5000;
END;
GO

SELECT dbo.GetAnnualSalary(5000);