CREATE DATABASE TheTemperTrap

USE TheTemperTrap

CREATE TABLE Usuarios(
idUsuario INT PRIMARY KEY,
Nombres VARCHAR(50),
Correo VARCHAR(70),
Contra VARCHAR(100),
Direccion VARCHAR(100),
Telefono VARCHAR(50),
idTipoUsuario INT);

CREATE TABLE Comidas(
idComida INT PRIMARY KEY,
Nombre VARCHAR(50),
Precio DECIMAL(10,2),
Descripcion VARCHAR(100),
Imagen image,
idTipoComida INT);

CREATE TABLE TipoComidas(
idTipoComida INT PRIMARY KEY,
Descripcion VARCHAR(60));

CREATE TABLE TipoUsuario(
idTipoUsuario INT PRIMARY KEY,
Descripcion VARCHAR(60));

CREATE TABLE Pedido(
idPedido INT PRIMARY KEY,
Estado VARCHAR(50),
Comentario VARCHAR(100),
idUsuario INT);

CREATE TABLE Pedido_Comidas(
idPedido_Comidas INT PRIMARY KEY,
Comentario VARCHAR(100),
idPedido INT,
idComida INT);

CREATE TABLE ModoPago(
idModoPago INT PRIMARY KEY,
Descripcion VARCHAR(100));

CREATE TABLE DetalleCarrito(
idDetalle INT PRIMARY KEY,
PrecioFinal DECIMAL(10,2),
idModoPago INT,
idPedido INT);

ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_TipoUsuario FOREIGN KEY (idTipoUsuario) REFERENCES TipoUsuario(idTipoUsuario);

ALTER TABLE Comidas
ADD CONSTRAINT FK_Comidas_TipoComidas FOREIGN KEY (idTipoComida) REFERENCES TipoComidas(idTipoComida);

ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Usuarios FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario);

ALTER TABLE Pedido_Comidas
ADD CONSTRAINT FK_Pedido_Pedido_Comidas FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido);

ALTER TABLE Pedido_Comidas
ADD CONSTRAINT FK_Pedido_Comidas_Comidas FOREIGN KEY (idComida) REFERENCES Comidas(idComida);

ALTER TABLE DetalleCarrito
ADD CONSTRAINT FK_DetalleCarrito_ModoPago FOREIGN KEY (idModoPago) REFERENCES ModoPago(idModoPago);

ALTER TABLE DetalleCarrito
ADD CONSTRAINT FK_DetalleCarrito_Pedido FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido);


CREATE PROC sp_RegistrarUsuario(
@Nombres VARCHAR(50),
@Correo VARCHAR(70),
@Contra VARCHAR(100),
@Direccion VARCHAR(100),
@Telefono VARCHAR(50),
@Registrado BIT OUTPUT,
@Mensaje VARCHAR(100) OUTPUT
)
AS
BEGIN

IF(NOT EXISTS (SELECT * FROM Usuarios WHERE Correo = @Correo))
BEGIN
INSERT INTO Usuarios(Correo,Contra) VALUES (@Correo,@Contra)
SET @Registrado = 1
SET @Mensaje = 'Usuario Registrado'
END
ELSE
BEGIN
SET @Registrado = 0
SET @Mensaje = 'Correo existente'
END
END

CREATE PROC sp_ValidarUsuario(
@Correo VARCHAR(70),
@Contra VARCHAR(100))
AS
BEGIN
IF (EXISTS(SELECT * FROM Usuarios WHERE Correo = @Correo AND Contra = @Contra))
SELECT idUsuario FROM Usuarios WHERE Correo = @Correo AND Contra = @Contra
ELSE
SELECT '0'
END

SELECT * FROM USUARIOS



