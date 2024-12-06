use SQLAssignment

--1. Write a T-SQL Program to find the factorial of a given number.
 
create function dbo.Factorial (@number int)
returns bigint
as
begin
    declare @result bigint
    set @result = 1
    while @number > 1
    begin
        set @result = @result * @number
        set @number = @number - 1
    end
    return @result
end
 
select dbo.Factorial(9) as Factorial
 
--2. Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create procedure GenerateMultiplicate_table
    @Number int,
    @Limit int
as
begin
set nocount on;
  declare @Counter int = 1;
  print 'Multiplicate Table' + cast(@Number as varchar(10)) + ' up to ' + cast(@Limit as varchar(10));
   while @Counter <= @Limit
    begin
        print cast(@Number as varchar(10)) + ' x ' + cast(@Counter as varchar(10)) + ' = ' + cast(@Number * @Counter as varchar(10));
        set @Counter = @Counter + 1;
    end
end;
 
Exec GenerateMultiplicate_table @Number = 12, @Limit = 15;

--3. Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly.
 
create table Students (
    Stid int primary key,
    Sname varchar(50)
);
 
insert into Students 
values(1, 'Jack'),
(2, 'Rithvik'),
(3, 'Jaspreeth'),
(4, 'Praveen'),
(5, 'Bisa'),
(6, 'Suraj');
 
 
create table Marks (
    Markid int primary key,
    Stid int,
    Score int,
    foreign key (Stid) references Students(Stid)
);
 
insert into Marks (Markid, Stid, Score)
values (1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);

 
create function GetStudents_Status (@Score int)
returns varchar(10)
as
begin
declare @status varchar(10);
    if @Score >= 50
	return 'Pass';
    else 
	return 'Fail';
	return @status;
end;
 
select
    s.Stid as StudentID,
    s.Sname as StudentName,
    m.Score as Score,
    dbo.GetStudents_Status(m.Score) as Status
from   Students s LEFT JOIN 
Marks m on s.Stid = m.Stid 
order by s.Stid;

