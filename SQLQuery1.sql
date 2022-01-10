create database PruebaAc;


use PruebaAc;
CREATE TABLE chofer
(
 
  Id_Chofer      int  identity (1,1) not null,
  cedula         VARCHAR (40) not null,
  nombre              VARCHAR (40) not null ,
  licencia           VARCHAR (40) unique not null ,
  sexo                 VARCHAR(40)  not null ,
  telefono			int  not null ,
  correo			VARCHAR(40)  not null ,
  usuario			VARCHAR(40)  not null ,
  contraseña		VARCHAR(40)  not null ,


  Primary Key(Id_Chofer)
);


insert into chofer values('1','1','1','1',1,'1','1','1')

insert into chofer values('2','1','1','1',1,'1','1','1')


select *from chofer;