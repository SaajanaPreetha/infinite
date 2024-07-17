--1.	Write a query to display your birthday (day of week)

SELECT DATENAME(WEEKDAY, '2002-12-18') AS BirthdayWeek;
 
 
--2.	Write a query to display your age in days

DECLARE @Ageyearwise INT = 22; 

SELECT @Ageyearwise * 365 AS Agedaywise;

 
--3.	Write a query to display all employees information those who joined before 5 years in the current month.
 
--(Hint : If required update some HireDates in your EMP table of the assignment)

use infdb

select * from EMP

Insert into EMP
values (8791,'sweta','clerk', 7698, '2001-07-14', 1400, 200, 20),
(8763, 'sneha','analyst', 7839, '2000-07-12', 1200, 328, 20);

Select * from EMP
WHERE HIREDATE <= DATEADD(YEAR, -5, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)); 
--4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    --c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.

use infdb

CREATE TABLE Employee (
    empno int,
    ename VARCHAR(55),
    sal DECIMAL(10, 2),
    doj DATE
);
INSERT INTO Employee (empno, ename, sal, doj)
 VALUES (121, 'Sweta', 32000, '2022-05-13'),
       (432, 'Riya', 30000, '2020-09-20'),
       (321, 'Preetha', 32000, '2023-10-16');
	   Select * from employee

 BEGIN Tran;
       UPDATE Employee
       SET sal = sal * 1.15
       WHERE empno = 121;
	   
	   DELETE FROM Employee
       WHERE empno = 432;
	   COMMIT TRANSACTION;

	  

--5.      Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

	use infdb
	SELECT empno, ename, sal, deptno, dbo.calculateBonus(deptno, sal) AS bonus
FROM DBO.EMP

CREATE FUNCTION calculateBonus(DEPTNO INT, sal DECIMAL(10, 2)) 
RETURNS DECIMAL(10, 2)
BEGIN
    DECLARE bonus DECIMAL(10, 2);

    IF deptNO = 10 THEN
        SET bonus = sal * 0.15;
    ELSEIF dEPTNO = 20 THEN
        SET bonus = sal * 0.20;
    ELSE
        SET bonus = sal * 0.05;
    END IF;

    RETURN bonus;
END;
SELECT empno, ename, sal, deptno, dbo.calculateBonus(deptno, sal) AS bonus
FROM DBO.EMP




