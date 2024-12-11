create database ADO_Assessment
use ADO_Assessment

create table CalculateCourse_duration
(
C_id Varchar(15)Not null,
C_name Varchar(25),
Start_date Date ,
End_date Date,
Fee int Not null
)
 
Insert into CalculateCourse_duration 
values
('DN003','DotNet','2018-02-01','2018-02-28',15000),
('DV004','DataVisualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),
('JC001','CoreJava','2018-01-02','2018-01-12',3000)

--1.Create a Function to calculate the course duration for the above relation by receiving start date and end date as input.

create or alter function fn_CalculateCourse_duration(@start_date date,@end_date date)
  returns int
  as
  begin
  declare @duration int
  set @duration = datediff(day, @start_date, @end_date)
  return @duration
  end
 
  select dbo.fn_CalculateCourse_duration(Start_date,End_date) Course_durationdays
  from CalculateCourse_duration;


--2nd (1). Create a trigger to display the Course Name and Start date of the course.

CREATE TABLE T_CourseInfo(
C_Name VARCHAR(30),
Start_date DATE)
 

 create table CalculateCourse
(
C_id Varchar(15),
C_name Varchar(25),
Start_date Date ,
End_date Date,
Fee int 
)

create or alter trigger tgrDisplay
on CalculateCourse
for insert
as
begin
insert into CalculateCourse(C_Name,Start_Date)
select C_name,Start_date from inserted
end
 
INSERT INTO CalculateCourse VALUES
('CA001','css','2020-10-12','2020-11-22',9000)
 
SELECT * FROM CalculateCourse



--3rd

create table ProductsDetails(ProductId int, ProductName varchar(30), Price Float, DiscountedPrice Float);
create procedure sp_productdetails
@ProductId int,
@ProductName varchar(30),
@Price Float,
@DiscountedPrice Float
as
Begin
insert into ProductsDetails(ProductId, ProductName, Price, DiscountedPrice) values(@ProductId, @ProductName, @Price, @DiscountedPrice);
end

go
drop procedure sp_productdetails;
drop table ProductsDetails;

select * from ProductsDetails;
-----------------------------------------

create table ProductsDetail(ProductId int, ProductName varchar(30), Price Float, DiscountedPrice Float);
create procedure sp_productdetail
@ProductId int,
@ProductName varchar(30),
@Price Float,
@DiscountedPrice Float
as
Begin
insert into ProductsDetail(ProductId, ProductName, Price, DiscountedPrice) values(@ProductId, @ProductName, @Price, @DiscountedPrice);
end
 
go
drop procedure sp_productdetails;
drop table ProductsDetail;
 
select * from ProductsDetail;



