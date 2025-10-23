use Procedures

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10, 2) NOT NULL,
    DateAdded DATETIME NOT NULL
);

CREATE PROCEDURE InsertProduct (
    @ProductName NVARCHAR(100),
    @Description NVARCHAR(255),
    @Price DECIMAL(10, 2)
)
AS
BEGIN
    SET NOCOUNT ON; -- Prevents the number of affected rows from being returned

    INSERT INTO Products (ProductName, Description, Price, DateAdded)
    VALUES (@ProductName, @Description, @Price, GETDATE());
END;
GO

select *from Products

CREATE FUNCTION PriceDouble (@Price DECIMAL(10,2))
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @DoublePrice DECIMAL(10,2);
    SET @DoublePrice = @Price * 2;
    RETURN @DoublePrice;
END

DECLARE @json NVarchar(MAX);

-- 1. Initialize the JSON variable
SET @json = '{"info":{"addr":[{"town":"Belgrade"},{"town":"Paris"},{"town":"Madrid"}]}}';

-- 2. Modify the JSON: The result of JSON_MODIFY must be assigned back to the @json variable.
SET @json = JSON_MODIFY(@json, '$.info.addr[1].town', 'bankok');

-- 3. Select the modified JSON
SELECT ModifiedJSON = @json;

-- Use OPENJSON to break down the 'addr' array into rows
SELECT *
FROM OPENJSON(@json, '$.info.addr');




DECLARE @json1 NVARCHAR(MAX);

SET @json1 = N'[
    {
        "id": 2,
        "info": {
            "name": "John",
            "surname": "Smith"
        },
        "age": 25
    },
    {
        "dob": "2005-11-04T12:00:00",
        "id": 3,
        "info": {
            "name": "Johny",
            "surname": "Smi",
            "skills": [ "SQL", "C#", "AZURE" ]
        }
    }
]';

select id,firstname,lastname,dateofbirth,skill,age from openJSON(@json1) with (
                        id int 'strict $.id',
						firstname nvarchar(50) '$.info.name',
						lastname nvarchar(50) '$.info.surname',
						dateofbirth DATETIME2 '$.dob',
						age int,
						skills nvarchar(MAX) '$.info.skills' AS JSON
						
)
outer apply openjson(skills) with (skill nvarchar(8) '$');
   

   select JSON_VALUE(@json1,'$.dob')