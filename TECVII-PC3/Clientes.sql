CREATE DATABASE Cliente 

USE Cliente 

Create table Clientes(
Cod_Cliente int PRIMARY KEY NOT NULL,
Cif int NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(50) NOT NULL,
Direccion VARCHAR(80) NOT NULL,
Codigo_Post int NOT NULL,
Poblacion VARCHAR(50) NOT NULL,
Provincia VARCHAR(50) NOT NULL,
Telefono int NOT NULL
);

drop table Clientes

select * from Clientes

INSERT INTO Clientes VALUES(1, 566873, 'Pedro', 'Hernandez', 'San Juan Sac. 8-81', 01059, 'San Juan', 'Mejia', '48673116')