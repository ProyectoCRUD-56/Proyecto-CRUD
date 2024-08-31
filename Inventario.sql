-- Crear la base de datos y usarla
CREATE DATABASE inventario;
GO

USE inventario;
GO

-- Crear tabla Productos
CREATE TABLE Productos 
(
    Id_producto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(20),
    Descripcion NVARCHAR(35),
    Marca NVARCHAR(25),
    Precio FLOAT,
    Stock INT,
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

-- Crear procedimientos almacenados
--------------------------MOSTRAR 
CREATE PROC MostrarProductos
AS
    SELECT * FROM Productos WHERE Activo = 1;
GO

--------------------------INSERTAR 
CREATE PROC InsertarProductos
    @nombre NVARCHAR(20),
    @descrip NVARCHAR(35),
    @marca NVARCHAR(25),
    @precio FLOAT,
    @stock INT
AS
BEGIN
    INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Stock, Activo) 
    VALUES (@nombre, @descrip, @marca, @precio, @stock, 1); -- 1 indica que el registro está activo
END;
GO

------------------------ELIMINAR
CREATE PROC EliminarProducto
    @idpro INT
AS
BEGIN
    UPDATE Productos
    SET Activo = 0
    WHERE Id_producto = @idpro;
END;
GO

------------------EDITAR
CREATE PROC EditarProductos
    @nombre NVARCHAR(20),
    @descrip NVARCHAR(35),
    @marca NVARCHAR(25),
    @precio FLOAT,
    @stock INT,
    @id INT
AS
BEGIN
    UPDATE Productos 
    SET Nombre = @nombre, 
        Descripcion = @descrip, 
        Marca = @marca, 
        Precio = @precio, 
        Stock = @stock 
    WHERE Id_producto = @id AND Activo = 1; -- Solo edita si el producto está activo
END;
GO

-- Crear otras tablas
CREATE TABLE Categoria_Producto
(
    Id_categoria INT IDENTITY(1,1) PRIMARY KEY,
	Idproducto INT FOREIGN KEY REFERENCES Productos(Id_producto),
    Nombre NVARCHAR(15) NOT NULL,
    Descripcion NVARCHAR(25),
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

CREATE TABLE MediosPago
(
    Id_mediospago INT IDENTITY(1,1) PRIMARY KEY,
    Metodo NVARCHAR(15) NOT NULL,
    Detalles NVARCHAR(25),
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

CREATE TABLE Clientes
(
    Id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(15) NOT NULL,
    Apellido NVARCHAR(25) NOT NULL,
    Direccion NVARCHAR(35) DEFAULT 'No tiene',
    Telefono NVARCHAR(12) DEFAULT 'No tiene',
    Email NVARCHAR(60) DEFAULT 'No tiene',
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

CREATE TABLE Factura
(
    Id_factura INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT FOREIGN KEY REFERENCES Clientes(Id_cliente),
    Fecha DATE NOT NULL,
    IdMedioPago INT FOREIGN KEY REFERENCES MediosPago(Id_mediospago),
    Total FLOAT NOT NULL,
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

CREATE TABLE Usuarios
(
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(15) NOT NULL,
    Contraseña NVARCHAR(25) NOT NULL,
    Email NVARCHAR(35),
    Rol NVARCHAR(20),
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

CREATE TABLE Transaccion 
(
    Id_transaccion INT IDENTITY(1,1) PRIMARY KEY,
    Id_factura INT FOREIGN KEY REFERENCES Factura(Id_factura),
    Id_producto INT FOREIGN KEY REFERENCES Productos(Id_producto),

    Cantidad INT NOT NULL,
    PrecioUnitario FLOAT NOT NULL,
    SubTotal AS (Cantidad * PrecioUnitario),
    Activo BIT DEFAULT 1 -- Añadido el campo Activo
);
GO

-- Ejemplo de llamada a procedimientos
-- Insertar un producto
--EXEC InsertarProductos @nombre = 'Gaseosa', @descrip = '3 litros', @marca = 'marcacola', @precio = 7000, @stock = 24;

-- Eliminar un producto (marcarlo como inactivo)
--EXEC EliminarProducto @idpro = 2;
