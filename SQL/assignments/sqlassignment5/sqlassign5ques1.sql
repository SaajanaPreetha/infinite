--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

   --a) HRA as 10% of Salary
   --b) DA as 20% of Salary
   --c) PF as 8% of Salary
   --d) IT as 5% of Salary
   --e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary, HRA, DA
   --g) Net Salary as Gross Salary - Deductions

--Print the payslip neatly with all details
use infdb

CREATE PROCEDURE GeneratePayslip
    @EmployeeName VARCHAR(55) = NULL,
    @Salary DECIMAL(16, 2)
AS
BEGIN

    DECLARE @HRA DECIMAL(16, 2)
    DECLARE @DA DECIMAL(16, 2)
    DECLARE @PF DECIMAL(16, 2)
    DECLARE @IT DECIMAL(16, 2)
    DECLARE @Deductions DECIMAL(16, 2)
    DECLARE @GrossSalary DECIMAL(16, 2)
    DECLARE @NetSalary DECIMAL(16, 2)

    SET @HRA = 0.10 * @Salary
    SET @DA = 0.20 * @Salary
    SET @PF = 0.08 * @Salary
    SET @IT = 0.05 * @Salary

    SET @Deductions = @PF + @IT

    SET @GrossSalary = @Salary + @HRA + @DA
    SET @NetSalary = @GrossSalary - @Deductions
    PRINT '               PAYSLIP                   '
    PRINT '----------------------------------------'
    
    BEGIN
        PRINT 'Employee Name: ' + @EmployeeName
    END
    PRINT 'Basic Salary: ' + CAST(@Salary AS VARCHAR(16))
    PRINT 'HRA (10%): ' + CAST(@HRA AS VARCHAR(16))
    PRINT 'DA (20%): ' + CAST(@DA AS VARCHAR(16))
    PRINT 'Gross Salary: ' + CAST(@GrossSalary AS VARCHAR(16))
    PRINT 'PF (8%): ' + CAST(@PF AS VARCHAR(16))
    PRINT 'IT (5%): ' + CAST(@IT AS VARCHAR(16))
    PRINT 'Deductions: ' + CAST(@Deductions AS VARCHAR(16))
    PRINT 'Net Salary: ' + CAST(@NetSalary AS VARCHAR(16))
END

EXEC GeneratePayslip @EmployeeName = 'Saajana', @Salary = 54000;
