CREATE DATABASE TemperTrap

USE TemperTrap

CREATE TABLE Empleados(
idEmpleado INT PRIMARY KEY NOT NULL,
Nombres VARCHAR(50),
Correo VARCHAR(70),
Contra VARCHAR(100),
Direccion VARCHAR(100),
Telefono VARCHAR(50),
idTipoEmpleado INT NOT NULL);

CREATE TABLE Comidas(
idComida INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(50),
Precio DECIMAL(10,2),
Descripcion VARCHAR(100),
Imagen image,
idTipoComida INT);

CREATE TABLE TipoComidas(
idTipoComida INT PRIMARY KEY NOT NULL,
Descripcion VARCHAR(60));

CREATE TABLE TipoEmpleado(
idTipoEmpleado INT PRIMARY KEY NOT NULL,
Descripcion VARCHAR(60));

CREATE TABLE Pedido(
idPedido INT PRIMARY KEY NOT NULL,
Estado VARCHAR(50),
Comentario VARCHAR(100),
idEmpleado INT);

CREATE TABLE Pedido_Comidas(
idPedido_Comidas INT PRIMARY KEY NOT NULL,
Comentario VARCHAR(100),
idPedido INT,
idComida INT);

CREATE TABLE ModoPago(
idModoPago INT PRIMARY KEY NOT NULL,
Descripcion VARCHAR(100));

CREATE TABLE DetalleCarrito(
idDetalle INT PRIMARY KEY NOT NULL,
PrecioFinal DECIMAL(10,2),
idModoPago INT,
idPedido INT);

ALTER TABLE Empleados
ADD CONSTRAINT FK_Empleados_TipoEmpleado FOREIGN KEY (idTipoEmpleado) REFERENCES TipoEmpleado(idTipoEmpleado);

ALTER TABLE Comidas
ADD CONSTRAINT FK_Comidas_TipoComidas FOREIGN KEY (idTipoComida) REFERENCES TipoComidas(idTipoComida);

ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Empleados FOREIGN KEY (idEmpleado) REFERENCES Empleados(idEmpleado);

ALTER TABLE Pedido_Comidas
ADD CONSTRAINT FK_Pedido_Pedido_Comidas FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido);

ALTER TABLE Pedido_Comidas
ADD CONSTRAINT FK_Pedido_Comidas_Comidas FOREIGN KEY (idComida) REFERENCES Comidas(idComida);

ALTER TABLE DetalleCarrito
ADD CONSTRAINT FK_DetalleCarrito_ModoPago FOREIGN KEY (idModoPago) REFERENCES ModoPago(idModoPago);

ALTER TABLE DetalleCarrito
ADD CONSTRAINT FK_DetalleCarrito_Pedido FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido);
