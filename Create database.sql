create database test_project_db;
go

use test_project_db;
go

create table Cars(
Id int primary key identity not null,
Parent_Id hierarchyid not null,
Name nvarchar(50) not null,
DateTime datetime not null
)
go

insert into Cars values(
hierarchyid::GetRoot(), 'Автомобиль', Getdate()
)

insert into Cars values(
('/1/'), 'Двигатель', Getdate()
)

insert into Cars values(
('/1/1/'), 'Цилиндр', Getdate()
)

insert into Cars values(
('/2/'), 'Кузов', Getdate()
)

insert into Cars values(
('/2/1/'), 'Крыша', Getdate()
)