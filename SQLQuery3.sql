create database smartMeterManagement
use smartMeterManagement

CREATE TABLE [User](  
  UserId         BIGINT IDENTITY PRIMARY KEY,  
  Username       NVARCHAR(100) NOT NULL UNIQUE,  
  PasswordHash   VARBINARY(256) NOT NULL,  
  DisplayName    NVARCHAR(150) NOT NULL,  
  Email          NVARCHAR(200) NULL,  
  Phone          NVARCHAR(30) NULL,  
  LastLoginUtc   DATETIME2(3) NULL,  
  IsActive       BIT NOT NULL DEFAULT 1);
 
CREATE TABLE OrgUnit (
  OrgUnitId INT IDENTITY PRIMARY KEY,
  Type VARCHAR(20) NOT NULL CHECK (Type IN ('Zone','Substation','Feeder','DTR')),
  Name NVARCHAR(100) NOT NULL,
  ParentId INT NULL REFERENCES OrgUnit(OrgUnitId)
);
 
CREATE TABLE Tariff (
  TariffId INT IDENTITY PRIMARY KEY,
  Name NVARCHAR(100) NOT NULL,
  EffectiveFrom DATE NOT NULL,
  EffectiveTo DATE NULL,
  BaseRate DECIMAL(18,4) NOT NULL,
  TaxRate DECIMAL(18,4) NOT NULL DEFAULT 0
);
 
CREATE TABLE TodRule (
  TodRuleId      INT IDENTITY PRIMARY KEY,
  TariffId       INT NOT NULL REFERENCES Tariff(TariffId),
  Name           NVARCHAR(50) NOT NULL,
  StartTime      TIME(0) NOT NULL,
  EndTime        TIME(0) NOT NULL,
  RatePerKwh     DECIMAL(18,6) NOT NULL
);
 
 
CREATE TABLE TariffSlab (
  TariffSlabId   INT IDENTITY PRIMARY KEY,
  TariffId       INT NOT NULL REFERENCES Tariff(TariffId),
  FromKwh        DECIMAL(18,6) NOT NULL,
  ToKwh          DECIMAL(18,6) NOT NULL,
  RatePerKwh     DECIMAL(18,6) NOT NULL,
  CONSTRAINT CK_TariffSlab_Range CHECK (FromKwh >= 0 AND ToKwh > FromKwh)
);
 
CREATE TABLE Consumer (
  ConsumerId BIGINT IDENTITY PRIMARY KEY,
  Name NVARCHAR(200) NOT NULL,
  Address NVARCHAR(500) NULL,
  Phone NVARCHAR(30) NULL,
  Email NVARCHAR(200) NULL,
  OrgUnitId INT NOT NULL REFERENCES OrgUnit(OrgUnitId),
  TariffId INT NOT NULL REFERENCES Tariff(TariffId),
  Status VARCHAR(20) NOT NULL DEFAULT 'Active' CHECK (Status IN ('Active','Inactive')),
  CreatedAt DATETIME2(3) NOT NULL DEFAULT SYSUTCDATETIME(),
  CreatedBy NVARCHAR(100) NOT NULL DEFAULT 'system',
  UpdatedAt DATETIME2(3) NULL,
  UpdatedBy NVARCHAR(100) NULL
);
 
CREATE TABLE Meter (
  MeterSerialNo NVARCHAR(50) NOT NULL PRIMARY KEY,
  IpAddress NVARCHAR(45) NOT NULL,
  ICCID NVARCHAR(30) NOT NULL,
  IMSI NVARCHAR(30) NOT NULL,
  Manufacturer NVARCHAR(100) NOT NULL,
  Firmware NVARCHAR(50) NULL,
  Category NVARCHAR(50) NOT NULL,
  InstallTsUtc DATETIME2(3) NOT NULL,
  Status VARCHAR(20) NOT NULL DEFAULT 'Active'
           CHECK (Status IN ('Active','Inactive','Decommissioned')),
  ConsumerId BIGINT NULL REFERENCES Consumer(ConsumerId)
);

SET NOCOUNT ON;
DECLARE @i INT = 1;
BEGIN TRANSACTION;

WHILE @i <= 2000
BEGIN
    INSERT INTO [User] (
        Username,
        PasswordHash,
        DisplayName,
        Email,
        Phone,
        LastLoginUtc,
        IsActive
    )
    VALUES
    (
        'user' + CAST(@i AS NVARCHAR(10)),
        CAST(NEWID() AS VARBINARY(16)),
        'User ' + CAST(@i AS NVARCHAR(10)),
        'user' + CAST(@i AS NVARCHAR(10)) + '@example.com',
        '987-120-' + RIGHT('000' + CAST(@i AS NVARCHAR(10)), 4),
        GETUTCDATE(),
        1
    );

   
    SET @i = @i + 1;
END;


COMMIT TRANSACTION;
GO


select *from [User]

drop table [User]