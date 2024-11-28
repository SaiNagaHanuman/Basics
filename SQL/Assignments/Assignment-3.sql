use SQLAssignment

--1. Retrieve a list of MANAGERS. 
select *
from Emp
where job = 'manager'; 

--2. Find out the names and salaries of all employees earning more than 1000 per month.
select Ename, Sal
from Emp
Where Sal > 1000;

--3. Display the names and salaries of all employees except JAMES.
select Ename, Sal
from Emp
where Ename != 'James';

--4. Find out the details of employees whose names begin with ‘S’.
select *
from Emp
where Ename like 's%';

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select Ename
from Emp
where Ename like '%a%';


--6. Find out the names of all employees that have ‘L’ as their third character in their name.
select Ename
from Emp
where Ename like '__L%';

--7. Compute daily salary of JONES.
select Ename, Sal / 30 as daily_salary
from Emp
where Ename = 'Jones';

--8. Calculate the total monthly salary of all employees. 
select sum(sal) as total_monthly_salary
from Emp;

--9. Print the average annual salary.
select avg(sal) * 12 as Average_Annual_Salary
from Emp;

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select Ename, Job, Sal, Deptno
from Emp
where Deptno = 30 and job != 'SALESMAN';

--11. List unique departments of the EMP table.
select distinct Deptno
from Emp;

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select Ename as Employees, Sal as "Monthly Salary" 
from Emp
where sal > 1500 and Deptno in (10, 30);

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
select Ename, Sal, Job
from Emp
where (job = 'Manager' or job ='Analyst') and Sal not in (1000, 3000, 5000);

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select Ename, Sal
from EMP
where comm > Sal* 1.10;

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select Ename
from emp
where (Ename like '%l%l%' and Deptno = 30)  or Mgr_id = 7782;

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees.
select ename
from Emp
where DATEDIFF(year,hiredate,getdate()) between 30 and 40
select count(*)
from Emp 
where DATEDIFF(year,hiredate,getdate()) between 30 and 40

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname, e.ename
from dept d
join Emp e on d.Deptno =e.Deptno
order by d.dname asc, e.ename desc;

--18. Find out experience of MILLER. 
select DATEDIFF(year,hiredate,getdate()) as experience
from Emp 
where ename='miller';

select * from EMP