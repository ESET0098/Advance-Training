use smartMeterManagement

select *from Meter
select *from [User]
Select *from TodRule
select *from TariffSlab
create procedure selectMeterWithCategory @Category nvarchar(30)
as 
Select *from Meter where Category=@Category;
Go

create procedure selectUserWithName @DisplayName nvarchar(30)
as 
Select *from [User] where DisplayName=@DisplayName;
Go

exec selectUserWithName @DisplayName='Rajesh Kumar'


Create PROCEDURE totalActiveMetera @Status nvarchar(30)
AS 
BEGIN
    
    IF @Status IS NULL OR @Status = ''
    BEGIN
        SELECT * FROM Meter;
    END
    -- If @Status has a value, filter the meters by that category.
    ELSE
    BEGIN
        SELECT * FROM Meter WHERE Status = @Status;
    END
END;
GO

drop procedure totalActiveMeter

exec totalActiveMetera @Status = 'Active'

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50)
);
CREATE TABLE EmployeeBonuses (
    BonusID INT PRIMARY KEY,
    EmployeeID INT,
    BonusAmount DECIMAL(10, 2),
    BonusDate DATE
);
INSERT INTO Employees (EmployeeID, FirstName, LastName, Department)
VALUES
(1, 'John', 'Doe', 'Sales'),
(2, 'Jane', 'Smith', 'Marketing'),
(3, 'Peter', 'Jones', 'Sales'),
(4, 'Sarah', 'Miller', 'Human Resources'),
(5, 'David', 'Davis', 'IT');




INSERT INTO EmployeeBonuses (BonusID, EmployeeID, BonusAmount, BonusDate)
VALUES
(101, 1, 1000.00, '2025-01-01'),
(102, 2, 800.00, '2025-01-01'),
(103, 3, 1200.00, '2025-01-01'),
(104, 4, 950.00, '2025-01-01'),
(105, 5, 1100.00, '2025-01-01');


CREATE PROCEDURE ProcessEmployeeBonuses
AS
BEGIN
    -- Create a temporary table with an identity column for iteration
    CREATE TABLE #TempEmployees (
        RowNum INT IDENTITY(1, 1),
        EmployeeID INT
    );

    -- Insert the IDs of employees to be processed
    INSERT INTO #TempEmployees (EmployeeID)
    SELECT EmployeeID FROM Employees WHERE Department = 'Sales';

    DECLARE @RowCount INT = (SELECT COUNT(*) FROM #TempEmployees);
    DECLARE @Counter INT = 1;
    DECLARE @CurrentEmployeeID INT;

    WHILE @Counter <= @RowCount
    BEGIN
        -- Get the next employee ID
        SELECT @CurrentEmployeeID = EmployeeID
        FROM #TempEmployees
        WHERE RowNum = @Counter;

        -- Perform a custom action for the employee
        UPDATE EmployeeBonuses
        SET BonusAmount = BonusAmount * 1.10
        WHERE EmployeeID = @CurrentEmployeeID;

        -- Increment the counter to process the next row
        SET @Counter = @Counter + 1;
    END;

    DROP TABLE #TempEmployees;
END;

exec ProcessEmployeeBonuses



select *from EmployeeBonuses
select *from Employees

CREATE FUNCTION PredictBonus (
    @BonusDate DATE,
    @BonusAmount DECIMAL(10,2)
)
RETURNS NVARCHAR(50) -- 'NVARCHAR' is a valid string return type
AS
BEGIN
    DECLARE @Prediction NVARCHAR(50); -- The variable to hold the return value

    -- Example logic to predict or categorize the bonus
    IF @BonusAmount > 5000 AND MONTH(@BonusDate) IN (12, 1) -- Check for a large year-end bonus
    BEGIN
        SET @Prediction = 'Exceptional Year-End Bonus';
    END
    ELSE IF @BonusAmount >= 1000 AND @BonusAmount <= 5000
    BEGIN
        SET @Prediction = 'Standard Bonus';
    END
    ELSE
    BEGIN
        SET @Prediction = 'Small or Unspecified Bonus';
    END;

    RETURN @Prediction;
END;

-- Assume the EmployeeBonuses table exists from a previous example
SELECT
    BonusID,
    EmployeeID,
    BonusDate,
    BonusAmount,
    dbo.PredictBonus(BonusDate, BonusAmount) AS BonusPrediction
FROM EmployeeBonuses;







CREATE TYPE dbo.ProductListType AS TABLE (
    ProductID INT,
    ProductName NVARCHAR(100),
    Price DECIMAL(10, 2)
);
GO


CREATE PROCEDURE dbo.InsertNewProducts
    @NewProducts dbo.ProductListType READONLY
AS
BEGIN
    INSERT INTO dbo.Products (ProductID, ProductName, Price)
    SELECT ProductID, ProductName, Price
    FROM @NewProducts;
END;
GO


-- Declare a variable of the table type
DECLARE @ProductsToInsert dbo.ProductListType;

-- Populate the variable with data
INSERT INTO @ProductsToInsert (ProductID, ProductName, Price)
VALUES
(1, 'Laptop', 1200.00),
(2, 'Mouse', 25.00),
(3, 'Keyboard', 75.00);

-- Execute the stored procedure and pass the TVP
EXEC dbo.InsertNewProducts @ProductsToInsert;
GO
