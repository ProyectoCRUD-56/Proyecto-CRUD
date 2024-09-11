CREATE DATABASE inventario5;-- Crea la base de datos Inventario
USE inventario5;
                      --/-----------Creacion de las tablas -----------/
CREATE TABLE Categoria_Producto  --TABLA DE CATEGORIAS
(
    Id_categoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(100),
    Activo BIT DEFAULT 1
);
CREATE TABLE Producto --TABLA PRODUCTOS
(
    Id_producto INT IDENTITY(1,1) PRIMARY KEY,
IdCategoria INT FOREIGN KEY REFERENCES Categoria_Producto(Id_categoria),
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(70) NOT NULL,
    Marca NVARCHAR(70) NOT NULL,
    Precio FLOAT NOT NULL,
    Stock INT NOT NULL,
    Activo BIT DEFAULT 1
);

CREATE TABLE MediosPago -- CREACION DE LA TABLA PARA DETERMINAR EL MEDIO DE PAGO
(
    Id_mediospago INT IDENTITY(1,1) PRIMARY KEY,
    Metodo NVARCHAR(70) NOT NULL,
    Detalles NVARCHAR(100),
    Activo BIT DEFAULT 1
);

CREATE TABLE Clientes --CREACION DE LA TABLA CLIENTES
(
    Id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(60) NOT NULL,
    Apellido NVARCHAR(60) NOT NULL,
N_Identificacion NVARCHAR (30) NOT NULL,
Sexo CHAR(1) NOT NULL,                      --TABLA DIRECTAMENTE RELACIONADA CON LA TABLA DE FACTURAS
    Direccion NVARCHAR(100) DEFAULT 'No tiene',         --
    Telefono NVARCHAR(20) DEFAULT 'No tiene',
    Email NVARCHAR(100) DEFAULT 'No tiene',
    Activo BIT DEFAULT 1
);
CREATE TABLE Roles(
Id_Rol INT IDENTITY(1,1) PRIMARY KEY,
Tipo_Rol VARCHAR(40));

CREATE TABLE Usuarios
(
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,
Id_Rol INT FOREIGN KEY REFERENCES Roles(Id_Rol),
    Nombre_Usuario NVARCHAR(60) NOT NULL,
Apellido_usuario NVARCHAR(70) NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
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

CREATE PROCEDURE RegistrarUsuario
    @Nombre_Usuario NVARCHAR(60),
    @Apellido_usuario NVARCHAR(70),
    @Contraseña NVARCHAR(100),  -- Contraseña en texto plano que será hasheada
    @Email NVARCHAR(100),
    @IdRol INT,
    @Activo BIT = 1
AS
BEGIN
    -- Declarar la variable para almacenar el hash de la contraseña
    DECLARE @HashedPassword NVARCHAR(64);

    -- Hashear la contraseña usando SHA2_256
    SET @HashedPassword = CONVERT(NVARCHAR(64), HASHBYTES('SHA2_256', CONVERT(NVARCHAR(4000), @Contraseña)), 2);

    -- Insertar los datos en la tabla Usuarios con la contraseña hasheada
    INSERT INTO Usuarios VALUES (@IdRol, @Nombre_Usuario, @Apellido_usuario, @HashedPassword, @Email, @Activo);
END;

drop proc RegistrarUsuario

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
-- Insertar datos en la tabla Categoria_Producto
INSERT INTO Categoria_Producto (Nombre, Descripcion) VALUES
('Electrónica', 'Dispositivos y accesorios electrónicos'),
('Ropa', 'Prendas de vestir y accesorios'),
('Hogar', 'Artículos para el hogar'),
('Juguetes', 'Juguetes y juegos para niños'),
('Deportes', 'Equipos y accesorios deportivos');


INSERT INTO Roles (Tipo_Rol) VALUES
('Gerente de Proyecto'),
('Administrador'),
('Vendedor'),
('Soporte'),
('Recepcionista');


--agregar un usuario para probar el hash
EXEC RegistrarUsuario 'Juan', 'Mona', '123', 'juan.perez@example.com',  1,1;

