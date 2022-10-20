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
-----
