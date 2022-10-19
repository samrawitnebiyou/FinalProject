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