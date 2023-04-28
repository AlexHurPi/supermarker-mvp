use Supermarker
create table Sell
(
 Sell_Id int identity (100000,1) primary key,
 Sell_Customer_id int not null,
 Sell_Total int not null,
 Sell_Pay_Mode nvarchar (50) not null,
 Sell_Observation nvarchar (50) not null,
)
go
insert into Sell values('100001', '25000', 'Credit card mode', 'Luis Gomez')
insert into Sell values('100000', '150000', 'Cash', 'Pedro Perez')