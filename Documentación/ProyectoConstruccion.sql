use db_a7eb45_sga;
select *from cooperativa;
select * from vendedor;
select *from InicioSesion;
select * from rol_usuario;
Drop table Cooperativa;
drop table usuario;
create table Cooperativa(
idCooperativa int primary key auto_increment,
Ruc varchar(10) not null,
Propietario varchar(45) not null,
NombreCooperativa varchar(45) not null,
Telefono varchar(10) not null,
Estado Char(1) NOT NULL,
idCredencial int not null
);
select *from cooperativa;
-- delete from cooperativa;
Delimiter $$
drop procedure if exists spl_insertarCooperativa $$
CREATE PROCEDURE spl_insertarCooperativa(Ruc varchar(10), Propietario varchar(45), NombreCooperativa varchar(45), Telefono varchar (10), Correo varchar (30), Contrasena varchar (10),Foreking_RolesUsuario int)
begin
Call Registrodecooperativa(Ruc, Propietario, NombreCooperativa, Telefono);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(Correo,Contrasena,Foreking_RolesUsuario);
set @credencial = LAST_INSERT_ID();
insert into Cooperativa (Ruc, Propietario, NombreCooperativa, Telefono, Estado,IdCredencial) values (Ruc, Propietario, NombreCooperativa, Telefono, 'A',@credencial);
end;
Delimiter;


select * from persona;
select *from Vendedor;
select *from iniciosesion;
select * from cliente c
inner join persona p on c.idCliente = p.idPersona
inner join rol_usuario r on r.idRol_Usuario = i.Foreking_RolesUsuario
inner join iniciosesion i on i.Foreking_RolesUsuario = c.IdCredencial
where c.idCliente = p.Cedula;
select * from iniciosesion;
-- '27', 'dora@gmail.com', 'dorala123', '3'
-- '5', 'ChavareaCSE90@hotmail.com', 'Emelec90', '4'



create table Vendedor(
idVendedor int primary key auto_increment,
Sueldo double not null,
Estado Char(1) NOT NULL,
idPersona int,
IdCredencial int
);
select *from vendedor;
select *from InicioSesion;
Delimiter $$
drop procedure if exists  spl_insertarVendedor $$
CREATE PROCEDURE spl_insertarVendedor(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into vendedor (Sueldo, Estado,idPersona,IdCredencial) values (SueldoFx, 'A',@persona,@credencial);
end;
Delimiter;
Drop table chofer;
create table Chofer(
idChofer int primary key auto_increment,
Licencia varchar(10) not null,
Sueldo double not null,
Estado Char(1) NOT NULL,
idPersona int,
IdCredencial int
);
Delimiter $$
drop procedure if exists spl_insertarChofer $$
CREATE PROCEDURE spl_insertarChofer(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), Licencia varchar(10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into vendedor (Licencia, Sueldo, Estado,idPersona,IdCredencial) values (LicenciaFx, SueldoFx, 'A',@persona,@credencial);
end;
Delimiter;
drop table administrador;
create table Administrador(
idAdmnistrador int primary key auto_increment,
CodAcceso varchar(10) not null,
Sueldo double not null,
Estado Char(1) NOT NULL,
idPersona int,
IdCredencial int
);
Delimiter $$
drop procedure if exists spl_insertarAdministrador $$
CREATE PROCEDURE spl_insertarAdministrador(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), CodAcceso varchar(10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into vendedor (CodAcceso, Sueldo, Estado,idPersona,IdCredencial) values (CodAccesoFx, SueldoFx, 'A',@persona,@credencial);
end;
Delimiter;
-- '25', 'joel@gmail.com', '039832334', '4'
-- '5', 'ChavareaCSE90@hotmail.com', 'Emelec90', '4'
-- '1', 'Kaas7520@hotmail.com', '1234', '1'


select *from iniciosesion;

CREATE PROCEDURE `ModificarCliente`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
update cliente set Telefono = Telefono1, 
    Correo = Correo1, 
    Contraseña = Contraseña1 where Cedula = Cedula1 ;
    End