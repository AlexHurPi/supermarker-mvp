use Supermarker
create table Customer
(
 Customer_Id int identity (100000,1) primary key,
 Customer_Name nvarchar (50) not null,
 Customer_Observation nvarchar (50) not null,
)
go
insert into Customer values('Pedro Perez', '87322547')
insert into Customer values('Luis Gomez', '55846239')
