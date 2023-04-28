use Supermarker
create table Product
(
 Product_Id int identity (100000,1) primary key,
 Product_Name nvarchar (50) not null,
 Product_Observation nvarchar (50) not null,
 Product_Price Int not null,
)
go
insert into Product values('Arroz', 'Libra', '3000')
insert into Product values('Panela', 'Unidad', '2000')
