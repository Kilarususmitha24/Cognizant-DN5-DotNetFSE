CREATE TABLE QuarterlySales
(
    Q1 INT,
    Q2 INT,
    Q3 INT,
    Q4 INT
);

INSERT INTO QuarterlySales
VALUES
(10000,15000,20000,25000);

SELECT
    QuarterName,
    Amount
FROM QuarterlySales

UNPIVOT
(
    Amount
    FOR QuarterName IN (Q1,Q2,Q3,Q4)
) AS UnpivotTable;