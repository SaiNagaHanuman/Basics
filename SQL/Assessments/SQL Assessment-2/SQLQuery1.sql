use SQL_Assesment_1
use SQLAssignment

--1st Write a query to display your birthday( day of week).

select DATENAME (WEEKDAY, '09-12-2002') as Dayofweek;

--2. Write a query to display your age in days.

select DATEDIFF (DAY, '09-12-2002',getdate())
as Ageindays;

--3. Write a query to display all employees information those who joined before 5 years in the current month.

select * 
from EMP
where year(getdate()) - year(hiredate) > 5
  AND month(hiredate) = month(getdate());


--4. Create table Employee with empno, ename, sal, doj columns or use and perform the following operations in a single transaction.
	
create table Employees (
    empno int primary key,
    ename varchar(50),
    sal decimal(10, 2),
    doj date
);
 
--A. First insert 3 rows
insert into Employees (empno, ename, sal, doj) values (1, 'sai', 54000, '2012-02-19');
insert into Employees (empno, ename, sal, doj) values (2, 'pavan', 46000, '2013-02-10');
insert into Employees(empno, ename, sal, doj) values (3, 'siva', 60000, '2011-07-20');
 
select * from Employees

--B. Update the second row sal with 15% increment.

update Employees
set sal = sal * 1.15
where empno = 2;
select * from Employees
 
--c. Delete the first row.

delete from Employees
where empno = 1;
 
select * from Employees
 
--D. To recall the deleted row, re-insert it using the deleted data.

insert into Employees values (1, 'sai', 54000, '2012-02-19');

--5.Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

	create Function Calculate_Bonus
(
  @deptno int,
  @sal decimal(18,2)
  )
  returns decimal(18,2)
  as 
  begin
  declare @Bonus float;
  if  @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;

  
   
--6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)

create procedure updatesal
  as
  begin
    update EMP
    set Sal=Sal+500
	where deptno=(select deptno from dept where dname='SALES') and Sal<1500
  end
  Exec updatesal
  select *from EMP