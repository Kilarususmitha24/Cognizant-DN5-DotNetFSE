CREATE TABLE Sales
(
    SalesYear INT,
    QuarterName VARCHAR(10),
    Amount INT
);

INSERT INTO Sales
VALUES
(2024,'Q1',10000),
(2024,'Q2',15000),
(2024,'Q3',20000),
(2024,'Q4',25000);

SELECT *
FROM
(
    SELECT QuarterName, Amount
    FROM Sales
) AS SourceTable

PIVOT
(
    SUM(Amount)
    FOR QuarterName IN ([Q1],[Q2],[Q3],[Q4])
) AS PivotTable;