use infdb

--Retrieve a list of MANAGERS. 

select * from EMP
where JOB = 'manager';

--Find out the names and salaries of all employees earning more than 1000 per month.

select ENAME , SAL from EMP
WHERE SAL > 1000;

--Display the names and salaries of all employees except JAMES. 

select ENAME , SAL from EMP
where not ENAME = 'JAMES';

--Find out the details of employees whose names begin with ‘S’. 

select ENAME from EMP
where ENAME like 'S%';

--Find out the names of all employees that have ‘A’ anywhere in their name. 

select ENAME from EMP
WHERE ENAME like '%a%';

--Find out the names of all employees that have ‘L’ as their third character in their name. 

select ENAME from EMP
WHERE ENAME like '__L%';

--Compute daily salary of JONES.
SELECT ENAME, SAL/30 AS daily_salary
FROM EMP
WHERE ENAME = 'jones';

--Calculate the total monthly salary of all employees. 
select sum(SAL) as Totalemployeesalary from EMP;

--Print the average annual salary . 
select AVG(SAL*12)
from EMP;

--Select the name, job, salary, department number of all employees except SALESMAN from department number 30.

select ENAME, JOB, SAL, DEPTNO FROM EMP
where not (deptno = 30 AND JOB = 'SALESMAN');

--List unique departments of the EMP table. 
SELECT DISTINCT DEPTNO FROM EMP;

--List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.

Select ENAME as Employee, SAL as MonthlySalary from EMP
where (SAL > 1500 and ( DEPTNO = 10 or DEPTNO = 30));

--Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 

Select ENAME, job, SAL from EMP
where((JOB = 'Manager'or JOB = 'Analyst') and ( SAL! = 1000 or SAL! = 3000 or SAL! = 5000));

--Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.

select ENAME, SAL, COMM FROM EMP
WHERE (COMM > 1.1 * SAL);

--Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 

select ENAME FROM EMP
WHERE ((ENAME like '%L%L%') and ( DEPTNO = 30 or MGR_ID = 7782));

--Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 

select ENAME from EMP
where HIREDATE between DATEADD(year, -40 ,getdate()) and DATEADD(year, -30, getdate());
Select count(*) as total_count
from EMP
where HIREDATE between DATEADD(year, -40,getdate()) and DATEADD(year, -30, getdate());

-- Retrieve the names of departments in ascending order and their employees in descending order. 

SELECT * FROM EMP
ORDER BY DEPTNO ASC, ENAME DESC;


