Create database Train_Ticket_Booking

use Train_Ticket_Booking

--user login

create table users(
   userid int identity primary key,
   username varchar(20) unique,
   password varchar(20),
   role varchar(10)  check (role in ('user'))
);

--Table Creation

Create table Trains(
   TrainNo int primary key,
   TrainName varchar(50),
   FirstClassTotalBerths int,
   SecondClassTotalBerths int,
   SleeperClassTotalBerths int,
   FirstClassAvailableBerths int,
   SecondClassAvailableBerths int,
   SleeperClassAvailableBerths int,
   Source varchar(25),
   Destination varchar(25),
   isactive bit default 1
);

--Booking Creation

Create table Bookings (
   Bookingid int identity primary key,
   TrainNo int,
   Class varchar(50) check (class in ('FirstClass','SecondClass','SleeperClass')),
   Tickets int,
   Status varchar(200) default 'Booked',
   BookingDate datetime default getdate()
);

--Stored procedures

---Admin Menu

--Add Train

 Create or alter proc AddTrains
	  @TrainNo int,
	  @TrainName varchar(50),
	  @FirstClassTotalBerths int,
	  @SecondClassTotalBerths int,
	  @SleeperClassTotalBerths int,
	  @FirstClassAvailableBerths int,
	  @SecondClassAvailableBerths int,
	  @SleeperClassAvailableBerths int,
	  @Source varchar(20),
	  @Destination varchar(25)
  as
  begin
   if not exists (select 1 from Trains where TrainNo = @TrainNo and isactive = 1)
   begin
       raiserror ('Invalid Train  Number or Train is not Active', 8,1);
	   return;
   end
	insert into Trains(TrainNo, TrainName, FirstClassTotalBerths, SecondClassTotalBerths, SleeperClassTotalBerths, FirstClassAvailableBerths, SecondClassAvailableBerths, SleeperClassAvailableBerths, Source, Destination, Isactive)
	values (@TrainNo, @TrainName, @FirstClassTotalBerths, @SecondClassTotalBerths, @SleeperClassTotalBerths, @FirstClassAvailableBerths, @SecondClassAvailableBerths, @SleeperClassAvailableBerths, @Source, @Destination, 1);
 end

--Modify Train

Create or alter proc ModifyTrain
   @TrainNo int,
   @TrainName varchar(20),
   @FirstClassTotalBerths int,
   @SecondClassTotalBerths int,
   @SleeperClassTotalBerths int,
   @FirstClassAvailableBerths int,
   @SecondClassAvailableBerths int,
   @SleeperClassAvailableBerths int,
   @Source varchar(20),
   @Destination varchar(20)
as
begin
    update Trains
	set TrainName = @TrainName,
	FirstClassTotalBerths = @FirstClassTotalBerths,
    SecondClassTotalBerths = @SecondClassTotalBerths,
    SleeperClassTotalBerths = @SleeperClassTotalBerths ,
	FirstClassAvailableBerths = @FirstClassAvailableBerths , 
	SecondClassAvailableBerths = @SecondClassAvailableBerths, 
	SleeperClassAvailableBerths = @SleeperClassAvailableBerths,
	Source = @Source,
	Destination = @Destination where TrainNo = @TrainNo;
end

--Soft Delete Train

Create or alter proc DeleteTrain
   @TrainNo int
as
begin
  update Trains
  set isactive = 0 where TrainNo = @TrainNo
end


--User Menu

--Book Tickets

Create or alter proc BookTickets
   @TrainNo int,
   @Class varchar(50),
   @Tickets int
as
begin
   if @Class ='FirstClass'
   begin
       update Trains
	   set FirstClassAvailableBerths = FirstClassAvailableBerths - @Tickets
       where TrainNo = @TrainNo and FirstClassAvailableBerths >=@Tickets;
       if @@ROWCOUNT > 0
       begin
	    insert into Bookings(TrainNo, Class, Tickets)
	   values (@TrainNo, @Class, @Tickets);
       end
	   else
	   begin
	      raiserror('Insufficient Berths in First Class', 8, 1);
       end
	end

	else if @Class ='SecondClass'
   begin
       update Trains
	   set SecondClassAvailableBerths = SecondClassAvailableBerths - @Tickets
       where TrainNo = @TrainNo and SecondClassAvailableBerths >=@Tickets;
       if @@ROWCOUNT > 0
       begin
	   insert into Bookings(TrainNo, Class, Tickets)
	   values (@TrainNo, @Class, @Tickets);
       end
	   else
	   begin
	      raiserror('Insufficient Berths in Second Class', 8, 1);
       end
	end

   else if @Class ='SleeperClass'
   begin
       update Trains
	   set SleeperClassAvailableBerths = SleeperClassAvailableBerths - @Tickets
       where TrainNo = @TrainNo and SleeperClassAvailableBerths >=@Tickets;
       if @@ROWCOUNT > 0
       begin
	   insert into Bookings(TrainNo, Class, Tickets)
	   values (@TrainNo, @Class, @Tickets);
       end
	   else
	   begin
	      raiserror('Insufficient Berths in Sleeper Class', 8, 1);
       end
	end
	else 
	begin
	    raiserror ('Invalid Class Provided by the User',8,1);
    end
end

--Cancel tickets

Create or alter proc CancelTickets
   @BookingID int
as
begin
   declare @TrainNo int, @Class  varchar(50), @Tickets int;

   select @TrainNo = TrainNo, @Class = Class, @Tickets = Tickets
   from Bookings where Bookingid = @BookingID and Status = 'Booked';
   if @Class = 'FirstClass'
   begin
       update Trains
	   set FirstClassAvailableBerths = FirstClassAvailableBerths + @Tickets
	   where TrainNo = @TrainNo;
   end
  
   else if @Class = 'SecondClass'
   begin
       update Trains
	   set SecondClassAvailableBerths = SecondClassAvailableBerths + @Tickets
	   where TrainNo = @TrainNo;
   end

   else if @Class = 'SleeperClass'
   begin
       update Trains
	   set SleeperClassAvailableBerths = SleeperClassAvailableBerths + @Tickets
	   where TrainNo = @TrainNo;
   end
   update Bookings 
   set Status = 'Tickets Cancelled/Booking Cancelled'
   where Bookingid = @BookingID;
end

--Show All Trains

Create or alter proc ShowAllTrains
as
begin
   select TrainNo, TrainName, FirstClassAvailableBerths, SecondClassAvailableBerths, SleeperClassAvailableBerths, Source, Destination, isactive  from Trains;
end

--Show Bookings/Cancellations

create or alter proc Show_BookingsandCancellations
as
begin
   select Bookingid, TrainNo, Class, Tickets, Status, BookingDate
   from Bookings
end

   

select * from Trains

select * from Bookings

select * from users