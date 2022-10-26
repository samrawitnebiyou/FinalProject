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