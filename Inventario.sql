--CREATE DATABASE inventario;-- Crea la base de datos Inventario

USE inventario;
                      --/-----------Creacion de las tablas -----------/
CREATE TABLE Categoria_Producto  --TABLA DE CATEGORIAS
(
    Id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(15) NOT NULL,
    Descripcion NVARCHAR(25),
    Activo BIT DEFAULT 1 
);
CREATE TABLE Producto --TABLA PRODUCTOS
(
    Id_producto INT IDENTITY(1,1) PRIMARY KEY,
	IdCategoria INT FOREIGN KEY REFERENCES Categoria_Producto(Id_categoria),
    Nombre NVARCHAR(20) NOT NULL,
    Descripcion NVARCHAR(35) NOT NULL,
    Marca NVARCHAR(25) NOT NULL,
    Precio FLOAT NOT NULL,
    Stock INT NOT NULL,
    Activo BIT DEFAULT 1 
);

CREATE TABLE MediosPago -- CREACION DE LA TABLA PARA DETERMINAR EL MEDIO DE PAGO
(
    Id_mediospago INT IDENTITY(1,1) PRIMARY KEY,
    Metodo NVARCHAR(15) NOT NULL,
    Detalles NVARCHAR(25),
    Activo BIT DEFAULT 1 
);

CREATE TABLE Clientes --CREACION DE LA TABLA CLIENTES 
(
    Id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(15) NOT NULL,
    Apellido NVARCHAR(25) NOT NULL, 
	N_Identificacion NVARCHAR (12) NOT NULL,
	Sexo CHAR(1) NOT NULL,                      --TABLA DIRECTAMENTE RELACIONADA CON LA TABLA DE FACTURAS
    Direccion NVARCHAR(35) DEFAULT 'No tiene',         --
    Telefono NVARCHAR(12) DEFAULT 'No tiene',
    Email NVARCHAR(60) DEFAULT 'No tiene',
    Activo BIT DEFAULT 1 
);
CREATE TABLE Roles(
Id_Rol INT IDENTITY(1,1) PRIMARY KEY,
Tipo_Rol VARCHAR(20));
 
CREATE TABLE Usuarios
(
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,
	Id_Rol INT FOREIGN KEY REFERENCES Roles(Id_Rol),
    Nombre_Usuario NVARCHAR(15) NOT NULL,
	Apellido_usuario NVARCHAR(20) NOT NULL,
    Contraseña NVARCHAR(20) NOT NULL,
    Email NVARCHAR(35),
    Rol NVARCHAR(15),
    Activo BIT DEFAULT 1 
);


CREATE TABLE Factura
(
    Id_factura INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT FOREIGN KEY REFERENCES Clientes(Id_cliente),
	Id_Usuarios INT FOREIGN KEY REFERENCES Usuarios(Id_usuario),
    Fecha DATE NOT NULL,
	Hora TIME NOT NULL,
    IdMedioPago INT FOREIGN KEY REFERENCES MediosPago(Id_mediospago),
    Total FLOAT NOT NULL,
    Activo BIT DEFAULT 1 
);
CREATE TABLE Historial_Precios
(
    Id_historial INT IDENTITY(1,1) PRIMARY KEY,
    Id_producto INT FOREIGN KEY REFERENCES Producto(Id_producto), -- Relación con Producto
    Precio FLOAT NOT NULL, -- Precio vigente
    Fecha_inicio DATE NOT NULL, -- Fecha en que comienza a regir este precio
    Fecha_fin DATE NULL, -- Fecha en que deja de ser vigente este precio (NULL si aún está vigente)
    Activo BIT DEFAULT 1
);
CREATE TABLE Transaccion 
(
    Id_transaccion INT IDENTITY(1,1) PRIMARY KEY,
    Id_factura INT FOREIGN KEY REFERENCES Factura(Id_factura),
    Id_producto INT FOREIGN KEY REFERENCES Producto(Id_producto),
	Id_historia INT FOREIGN KEY REFERENCES Historial_Precios(Id_historial),
    Cantidad INT NOT NULL,
    PrecioUnitario FLOAT NOT NULL, -- Precio al momento de la transacciòn
    SubTotal AS (Cantidad * PrecioUnitario),
    Activo BIT DEFAULT 1 
);





go
CREATE TRIGGER trg_AfterUpdate_Precio
ON Producto
AFTER UPDATE
AS
BEGIN
    DECLARE @Id_producto INT;
    DECLARE @Nuevo_Precio FLOAT;
    DECLARE @FechaInicio DATE = GETDATE();

    -- Obtener el Id_producto y el nuevo precio de la actualización
    SELECT @Id_producto = INSERTED.Id_producto, @Nuevo_Precio = INSERTED.Precio
    FROM INSERTED;

    -- Actualizar el precio anterior en Historial_Precios cerrando su periodo de vigencia
    UPDATE Historial_Precios
    SET Fecha_fin = @FechaInicio
    WHERE Id_producto = @Id_producto 
    AND Fecha_fin IS NULL;

    -- Insertar el nuevo precio en Historial_Precios con la nueva vigencia
    INSERT INTO Historial_Precios (Id_producto, Precio, Fecha_inicio)
    VALUES (@Id_producto, @Nuevo_Precio, @FechaInicio);
END;
