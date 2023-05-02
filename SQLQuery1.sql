use Supermarker
create table Purchase
(
 Purchase_Id int identity (100000,1) primary key,
 Provider_Id nvarchar (50) not null,
 Purchase_ProductId int not null,
 Purchase_Pay_Mode nvarchar (50) not null,
 Total_Purchase int not null,
 Purchase_Observation nvarchar (200) not null,
)
go

