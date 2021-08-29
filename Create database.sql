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
hierarchyid::GetRoot(), '����������', Getdate()
)

insert into Cars values(
('/1/'), '���������', Getdate()
)

insert into Cars values(
('/1/1/'), '�������', Getdate()
)

insert into Cars values(
('/2/'), '�����', Getdate()
)

insert into Cars values(
('/2/1/'), '�����', Getdate()
)