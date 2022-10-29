create database stadiumdatabsefinal
use stadiumdatabsefinal

create table tblUser
(
id int primary key identity,
firstname varchar(30) not null,
lastname varchar(30),
email varchar(50),
userName varchar(60),
password varchar(30),
photo image,
role varchar(30)
)

go
 alter procedure [dbo].[spGetRole]
@userName varchar(50),
@password varchar(50)
as
select role from tblUser
where userName =@userName and password=@password
go

go
alter proc [dbo].[spCreateUser]
@id varchar(50),
@firstName varchar(50),
@lastName varchar(50),
@email varchar(50),
@userName varchar(50),
@password varchar(50),
@photo image

as 
begin

insert into tblUser(firstName,lastName,email,userName,password,photo,role) 
values (@firstName,@lastName,@email,@userName,@password,@photo,'User')
end
go
 select * from tblUser
 ----------------
 create table tblEvent
(
eventid int primary key identity(1000,1),
name varchar(30) not null,
eventdate varchar(30) not null,
eventtime varchar(30) not null
)

go
alter proc [dbo].[spInsertEvent]
@name varchar(50),
@eventdate varchar(30),
@eventtime varchar(30)
as 
begin

insert into tblEvent(name,eventdate,eventtime) 
values (@name,@eventdate,@eventtime)
end

go
alter proc [dbo].[spDisplayEvent]
as 
begin
select * from tblEvent
end 
go


go
create proc [dbo].[spUpdateEvent]
@eventid int,
@name varchar(50),
@eventdate varchar(30),
@eventtime varchar(30)
as 
begin
Update tblEvent set name=@name, eventdate=@eventdate,eventtime=@eventtime
where eventid = @eventid
end

go
create proc [dbo].[spDeleteEvent]
@eventid int
as 
begin
update tblTicket set event=null where event=@eventid
delete from tblEvent
where eventid = @eventid
end
go
-----
go
create proc [dbo].[spGetEventbyName]
@eventName varchar(30)
as 
begin
select *from tblEvent 
where name like @eventName+'%' 
end
go




go
create proc [dbo].[spGetEventbyID]
@eventID int
as 
begin
select * from tblEvent 
where eventid = @eventID 
end
go

------
--table for tickets
create table tblTicket
(
ticketid int primary key identity(100,1),
tickettype varchar(30) not null,
amount money,
event int
)

alter table tblTicket
add constraint fk_ev
foreign key (event) references tblEvent(eventid)

--sp to insert ticket for an event
go
alter proc [dbo].[spInsertTicket]
@tickettype varchar(30),
@amount varchar(30),
@event varchar(30)
as 
begin
declare @eventno int
select @eventno= e.eventid from tblEvent as e where name=@event
insert into tblTicket(tickettype,amount,event) 
values (@tickettype,@amount,@eventno)
end

--sp to display all tickets
go
create proc [dbo].[spDisplayTicket]
as 
begin
select ticketid,tickettype,amount,name from tblTicket as t
join tblEvent as e
on t.event=e.eventid
where ticketid not in (select ticket from tblReservation)
end

--sp to update ticket
go
alter proc [dbo].[spUpdateTicket]
@ticketid int,
@tickettype varchar(30),
@amount varchar(30),
@event varchar(30)
as 
begin
declare @eventno int
select @eventno = event from tblticket as t
join tblEvent as e
on t.event=e.eventid
where name=@event
Update tblTicket set tickettype=@tickettype, amount=@amount,event=@eventno
where ticketid = @ticketid
end

--sp to delete ticket
go
alter proc [dbo].[spDeleteTicket]
@ticketid int
as 
begin
update tblTicket set event=null where ticketid=@ticketid
delete from tblTicket
where ticketid = @ticketid
end
select * from tblTicket

--sp to search ticket by type
go
alter proc [dbo].[TicketbyType]
@tickettype varchar(30)
as
begin
select ticketid,tickettype,amount,name from tblTicket as t
join tblEvent as e
on t.event=e.eventid
where tickettype=@tickettype
end
---
--sp to display all users
go
create proc [dbo].[AllUsers]
as
begin
select count(id)from tblUser
where role ='User'
end
 
 --sp to display all admins
go
create proc [dbo].[AllAdminstrator]
as
begin
select count(id)from tblUser
where role ='Adminstrator'
end

--sp to display users for specific event
go
create proc [dbo].[UserByEvent]
@eventName varchar(30)
as 
begin
select count(users) from tblReservation as r
join tblTicket as t
on r.ticket=t.ticketid
join tblEvent as e
on t.event=e.eventid
where e.name=@eventName
end


--table for reservation

create table tblReservation
(
resid int primary key identity(1000,1),
resdate varchar(30) not null,
restime varchar(30) not null,
numberofreservation int,
users int,
ticket int,
)

alter table tblReservation
add constraint fk_cu
foreign key (users) references tblUser(id) 

alter table tblReservation
add constraint fk_ti
foreign key (ticket) references tblTicket(ticketid)

--sp for inserting into tblReservation and updating seat

go 
alter proc [insertReserandUpdateSeat]
@resdatee varchar(30),
@restimee varchar(30),
@userr varchar(30),
@tickett int,
@seatNumber int
--@seatType varchar(30)
as
begin
declare @identityval int, @userss int, @seatType varchar(30)
select @userss= u.id from tblUser as u where u.userName=@userr
insert into tblReservation (resdate,restime,numberofreservation,users,ticket)
values (@resdatee,@restimee,1,@userss,@tickett)

set @identityval= SCOPE_IDENTITY()
select @seatType= seattype from tblSeat where seatnumber=@seatNumber
update tblSeat set reservation=@identityVal
where seatnumber=@seatNumber
end


--sp for displaying all reservation



--sp for searching user reservation
go
alter proc[dbo].[spDisplayUserreservation]
@userID varchar(30)
as
begin
select r.resid, r.resdate, r.restime,r.numberofreservation,userName ,t.ticketid,t.amount,t.tickettype ,e.name,s.seatnumber,s.seattype from tblReservation as r
join tblUser as u 
on r.users= u.id
join tblTicket as t
on r.ticket=t.ticketid
join tblEvent as e
on t.event=e.eventid
join tblSeat as s
on r.resid=s.reservation
where u.id=@userID
end


--sp for update reservation

go
alter proc [dbo].[spupdateReser]
@resid int,
@resdate varchar(30),
@restime varchar(30),
@user varchar(30),
@ticket int
as 
begin
declare @users int,@identityval int,@seatType varchar(30)
select @users= users from tblReservation as r
join tblUser as u
on r.users=u.id
where username=@user
update tblReservation set resdate=@resdate,restime=@restime,users=@users,ticket=@ticket
where resid=@resid
end

--sp for deleteing reservation
go
alter proc [dbo].[spDeleteReservation]
@resid int
as 
begin
update tblSeat set reservation=null where reservation=@resid
delete from tblReservation
where resid = @resid
end
go
--

--table for seat

create table tblSeat
(
seatnumber int primary key ,
seattype varchar(30) not null,
reservation int
)


alter table tblSeat
add constraint fk_re
foreign key (reservation) references tblReservation(resid)


--inserting seats 
insert into tblSeat values

(1,'VIP',null),(2,'REGULAR',null),
(3,'VIP',null),(4,'REGULAR',null),
(5,'VIP',null),(6,'REGULAR',null),
(7,'VIP',null),(8,'VIP',null),
(9,'VIP',null),(10,'VIP',null),
(11,'REGULAR',null),(12,'REGULAR',null),
(13,'REGULAR',null),(14,'REGULAR',null)

--sp to display seats available
go
alter proc [dbo].[spDisplaySeat]
as 
begin
select seatnumber,seattype,reservation from tblSeat as s
where s.reservation is null
end

--
 select * from tblReservation
 select * from tblSeat
 select * from tblUser
 
 --Triggers
 --1
 go
alter trigger [checkpasswordamount]
on tblUser
after insert
as
begin
declare @password varchar(30)
select @password= password from tblUser
if(LEN(@password)>16)
  begin
 raiserror('password too long',16,1)
 rollback
 end
 end
insert into tblUser values('Oumer','Muktar','oumerm@gmail.com','oumer0989','samrawit0982314678',null,'Adminstrator')


  /*--2 is not working
--go
--alter trigger [checkemail]
--on tblUser
--after insert
--as
--begin
--if exists(select  email from tblUser)
--  begin
-- raiserror('Email already registered',16,1)
rollback
 end
 end*/

 -----------
 select * from tblUser
--3
 go
alter trigger [checkclashdate]
on tblEvent
after insert
as
begin
if exists(select  eventdate,eventtime from tblEvent)
  begin
 raiserror('event date and event time clashes',16,1)
 rollback
 end
 end

 select * from tblEvent
 insert into tblEvent values ('clash date','Wednesday, October 26, 2022','12:09PM')

 --4
 go
alter trigger [ReservationGreaterthan10000]
on tblReservation
after insert
as
begin
declare @count int
select @count=count(numberofreservation) from tblReservation
if @count>10000
begin
 raiserror('All Tickets are soled out',16,1)
 rollback
 end
end

--5
go
alter trigger [checkinsertname]
on tblUser
after insert
as
begin
declare @fullname varchar(30)
select @fullname= firstname  from tblUser

if(@fullname=null or @fullname='')
  begin
 raiserror('name not entered',11,1)
 rollback
 end
 end

 insert into tblUser values('Oumer','Muktar','mhw@gmail.com','muk98','jdjsj23',null,'User')
 select * from tblUser

 --functions

--1
go
create function [DisplayAllEvents]()
returns table
as 
return(select  * from tblEvent)
go
select * from DisplayAllEvents()

--2
 go
create function [usdAllEvents]()
returns table
as 
return(select  count(eventid) as AllEvents from tblEvent)
go
select * from usdAllEvents()

--3
/*go
alter function [calculatesEventDate]
(@eventName varchar(30))
returns int
as
begin
declare @daysleft int
select @daysleft=datediff(day,e.eventdate,getdate())  from tblEvent as e
where e.name=@eventName

return @daysleft
end
go
select  dbo.calculatesEventDate ('super Bowl')
select * from tblEvent
*/

select * from tblUser
 select * from tblEvent
 select * from tblTicket
select * from tblReservation
 select * from tblSeat
 ---
 --2 
go
create trigger [checkamount]
on tblTicket
after insert
as
begin
declare @amountt money
select @amountt= amount from tblTicket
if(@amountt < 0 )
  begin
 raiserror('invalid amount ',16,1)
 rollback
 end