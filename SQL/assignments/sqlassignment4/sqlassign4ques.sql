--1.	Write a T-SQL Program to find the factorial of a given number.

DECLARE @Number INT = 4;  
DECLARE @factorial INT = 1;
DECLARE @result INT = 1;

WHILE @result <= @Number
BEGIN
    SET @factorial = @factorial * @result;
    SET @result = @result + 1;
END

PRINT 'Factorial of ' + CAST(@Number AS VARCHAR(10)) + ' is ' + CAST(@factorial AS VARCHAR(20));

--2.	Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number.


CREATE PROCEDURE GenerateTable
    @InputNumber INT,
    @MultiplyNumber INT
AS
BEGIN
    DECLARE @tempNumber INT = 1;
    DECLARE @result INT;

    WHILE @tempNumber <= @MultiplyNumber
    BEGIN
        SET @result = @InputNumber * @tempNumber;
        PRINT CAST(@InputNumber AS VARCHAR) + ' * ' + CAST(@tempNumber AS VARCHAR) + ' = ' + CAST(@result AS VARCHAR);
        SET @tempNumber = @tempNumber + 1;
    END
END;
GO

DECLARE @InputNumber INT = 12;
DECLARE @MultiplyNumber INT = 20;

EXEC GenerateTable @InputNumber, @MultiplyNumber;

--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

Create Table Holiday 
(
    holiday_date date primary key,
    Holiday_name varchar(55)
);


Insert into Holiday (holiday_date, Holiday_name)
values 
    ('2024-01-26', 'Republic Day'),
    ('2024-10-27', 'Diwali'),
    ('2024-12-25', 'Christmas'),
    ('2025-10-02', 'Gandhi Jayanthi');

Insert into Holiday (holiday_date, Holiday_name)
values 
    ('2024-07-20', 'Governmentholiday');

	select * from Holiday
	select * from EMP

CREATE TRIGGER RestrictDataManipulationOnHolidays
ON EMP
FOR INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @IsHoliday INT;

    SELECT @IsHoliday = COUNT(*)
    FROM Holiday
    WHERE holiday_date = CAST(GETDATE() AS DATE);

    IF @IsHoliday > 0
    BEGIN
        DECLARE @HolidayName NVARCHAR(100);
        SELECT @HolidayName = Holiday_name
        FROM Holiday
        WHERE holiday_date = CAST(GETDATE() AS DATE);

         DECLARE @ErrorMessage NVARCHAR(100);
        SET @ErrorMessage = 'Due to ' + @HolidayName + ', you cannot manipulate data.';
        
        THROW 50000, @ErrorMessage, 1;
        ROLLBACK TRANSACTION;  
    END
END;
INSERT INTO EMP (EMPNO,ENAME,SAL) VALUES (6162,'Ramya', 1000);