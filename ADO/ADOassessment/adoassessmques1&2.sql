-- 1. Create a database called Employeemanagement
--2. Create a table in the database called Employee_Details (Empno int Primary Key,
--EmpName varchar(50) not null,
--Empsal numeric(10,2) apply a check condition that empsal >=25000
--Emptype char(1) check whether type is 'F' or 'P' (Fulltime or Parttime)

--To do :
 
--1. Create a stored procedure that adds new rows to the Employee_Details Table. The procedure should accept all the details as input except empno. You need to write the code in the procedure to generate the empno and then insert
 
--2. Check the procedure
 
--3. Using ADO.net classes/methods, insert employee details by calling the procedure
 
--4. Display all employee rows
 
Create database Employeemanagement;

Use Employeemanagement;

Create table Employee_Details (
    Empno int primary key,
    EmpName varchar(50) not null,
    Empsal numeric(10,2) check (Empsal >= 25000),
    Emptype char(1) check (Emptype in ('F', 'P'))
);

select * from Employee_Details 
Create procedure sp_InsertEmployeeDetails
    @EmpName varchar(50),
    @Empsal numeric(10,2),
    @Emptype char(1)
As
Begin
    Declare @Empno int;

    Select @Empno = Coalesce(max(Empno), 0) + 1 from Employee_Details;

    Insert into Employee_Details (Empno, EmpName, Empsal, Emptype)
    values (@Empno, @EmpName, @Empsal, @Emptype);

    Select @Empno as EmpnoGenerated;
End
Go

EXEC sp_InsertEmployeeDetails 'Saajana', 40000.00, 'F';



