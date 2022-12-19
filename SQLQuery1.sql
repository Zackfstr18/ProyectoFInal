Create database SERVECHAPP
go
use SERVECHAPP
go


create table login(
UserID int  primary key,
LoginUser nvarchar(100) unique not null,
password nvarchar(100) not null,
Nombres nvarchar(100) not null,
Apellidos nvarchar(100) not null,
Posicion nvarchar(100) not null,
Email nvarchar(100) not null,
Telefono nvarchar(15) not null
)

insert into[dbo].[login] values (001,'Admin', 'admin12345','Isaac','Almanzar Lantigua','Administrador','lantigua0118@gmail.com','809-853-6167')
insert into[dbo].[login] values (101,'Caja1', 'box12345','Emmy Kelly','Cruz','Cajero','','809-853-6167')
insert into[dbo].[login] values (1001,'Inv1', 'wh012345','Antay','Aguayo','Inventario','','809-736-9667')

select * from [SERVECHAPP].[dbo].[login]

Select * from Login where LoginUser = 'Admin' and password= 'admin12345' and Posicion = 'Administrador'

delete from Login

alter table login alter column UserID int not null

update  login set Posicion = 'Caja' where UserID=101


drop proc ListarPos

create proc ListarPos
as
select [Posicion] from[SERVECHAPP].[dbo].[login]
go

exec ListarPos
