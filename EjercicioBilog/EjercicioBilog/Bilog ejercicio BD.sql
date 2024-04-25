create database GestionEmpleados;

﻿create table Empleados(
	PrimaryID int not null identity(1,1),
	ID varchar(max) not null,
	Nombre varchar(max) not null,
	Apellido varchar (max) not null,
);

CREATE PROCEDURE SP_AgregarEmpleado(
	@ID varchar(max),
    @Nombre varchar,
    @Apellido varchar 
)
as
INSERT INTO Empleados (ID, Nombre, Apellido) VALUES (@ID, @Nombre, @Apellido);

CREATE PROCEDURE SP_BorrarEmpleado(
	@ID varchar(max)
)
as
delete from Empleados where LOWER(ID) = LOWER(@ID)

CREATE PROCEDURE SP_ModificarEmpleado(
	@ID varchar(max),
    @Nombre varchar,
    @Apellido varchar
)
as
UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido where LOWER(ID) = LOWER(@ID)

