CREATE DATABASE bd_virtualBiblio;

CREATE TABLE Persona(
	Id_Persona INT NOT NULL IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	DNI VARCHAR(15) NOT NULL,
	Mail VARCHAR(100) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Baja VARCHAR(2) DEFAULT 'NO',
	CONSTRAINT PK_Persona PRIMARY KEY(Id_Persona),
	CONSTRAINT UQ_DNI UNIQUE(DNI),
	CONSTRAINT UQ_Mail UNIQUE(Mail),
	CONSTRAINT CK_Edad CHECK (DATEDIFF(YEAR,FechaNacimiento,GETDATE()) >= 18 AND DATEDIFF(YEAR,FechaNacimiento,GETDATE()) <= 100),
);

CREATE TABLE TipoPerfiles(
	Id INT NOT NULL ,
	Nombre VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoPerfiles PRIMARY KEY(Id),
);

INSERT INTO TipoPerfiles (Id, Nombre)
VALUES
    (1, 'Gerente'),
    (2, 'Administrador'),
    (3, 'Vendedor');

CREATE TABLE Usuario(
	Id INT NOT NULL IDENTITY(1,1),
	UserNombre VARCHAR(50) NOT NULL,
	Contraseña VARCHAR(100) NOT NULL,
	TipoPerfil INT NOT NULL,
	Id_Persona INT NOT NULL,
	CONSTRAINT PK_Usuario PRIMARY KEY(Id),
	CONSTRAINT FK_Persona_Usuario FOREIGN KEY(Id_Persona) REFERENCES Persona(Id_Persona),
	CONSTRAINT FK_TipoPerfil FOREIGN KEY(TipoPerfil) REFERENCES TipoPerfiles(Id),
	CONSTRAINT CK_TipoPerfil CHECK (TipoPerfil IN (1, 2, 3)),
);

CREATE TABLE Cliente(
	Id_Cliente INT NOT NULL IDENTITY(1,1),
	Telefono VARCHAR(15),
	Domicilio VARCHAR(100),
	FechaRegistro DATE NOT NULL DEFAULT(GETDATE()),
	Id_Persona INT NOT NULL,
	CONSTRAINT PK_Cliente PRIMARY KEY(Id_Cliente),
	CONSTRAINT FK_Persona_Cliente FOREIGN KEY(Id_Persona) REFERENCES Persona(Id_Persona),
);

CREATE TABLE Autor(
	Id_Autor INT NOT NULL IDENTITY(1,1),
	Nombre VARCHAR(200) NOT NULL,
	CONSTRAINT PK_Autor PRIMARY KEY(Id_Autor),
);

CREATE TABLE Editorial(
	Id_Editorial INT NOT NULL IDENTITY(1,1),
	NombreEditorial VARCHAR(200) NOT NULL,
	CONSTRAINT PK_Editorial PRIMARY KEY(Id_Editorial),
);

CREATE TABLE Categoria(
	Id_Categoria INT NOT NULL IDENTITY(1,1),
	Nombre VARCHAR(200) NOT NULL,
	CONSTRAINT PK_Categoria PRIMARY KEY(Id_Categoria),
);

INSERT INTO Categoria (Nombre)
VALUES ('Romance');

SELECT *FROM Categoria;

INSERT INTO Categoria (Nombre)
VALUES ('Terror');

-- Insertar categoría Acción
INSERT INTO Categoria (Nombre)
VALUES ('Acción');

-- Insertar categoría Fantasía
INSERT INTO Categoria (Nombre)
VALUES ('Fantasía');

-- Insertar categoría Suspenso
INSERT INTO Categoria (Nombre)
VALUES ('Suspenso');

-- Insertar categoría Drama
INSERT INTO Categoria (Nombre)
VALUES ('Drama');

-- Insertar categoría Comedia
INSERT INTO Categoria (Nombre)
VALUES ('Comedia');

-- Insertar categoría Infantil
INSERT INTO Categoria (Nombre)
VALUES ('Infantil');

CREATE TABLE Libro(
	Id_Libro INT NOT NULL IDENTITY(1,1),
	NombreProducto VARCHAR(200) NOT NULL,
	Descripcion VARCHAR(200) NOT NULL,
	PrecioUnitario FLOAT NOT NULL,
	Imagen VARCHAR(200) NOT NULL, 
	Stock INT NOT NULL,
	Baja VARCHAR(2) DEFAULT 'NO',
	Id_Categoria INT NOT NULL,
	Id_Editorial INT NOT NULL,
	Id_Autor INT NOT NULL,
	CONSTRAINT PK_Libro PRIMARY KEY(Id_Libro),
	CONSTRAINT FK_Libro_Categoria FOREIGN KEY(Id_Categoria) REFERENCES Categoria(Id_Categoria),
	CONSTRAINT FK_Libro_Editorial FOREIGN KEY(Id_Editorial) REFERENCES Editorial(Id_Editorial),
	CONSTRAINT FK_Libro_Autor FOREIGN KEY(Id_Autor) REFERENCES Autor(Id_Autor),
	CONSTRAINT UQ_Libro_Unico UNIQUE(NombreProducto, Id_Autor, Id_Editorial),
);

CREATE TABLE Metodo_Pago(
	Id_MetodoPago INT NOT NULL IDENTITY(1,1),
	TipoPago VARCHAR(20) NOT NULL,
	CONSTRAINT PK_MetodoPago PRIMARY KEY(Id_MetodoPago),
	CONSTRAINT UQ_MetodoPago UNIQUE(TipoPago),
);

INSERT INTO Metodo_Pago(TipoPago)
VALUES ('Credito/Debito');

INSERT INTO Metodo_Pago(TipoPago)
VALUES ('Efectivo');

INSERT INTO Metodo_Pago(TipoPago)
VALUES ('Mercado Pago');

CREATE TABLE Tipo_Factura(
	Id_TipoFactura INT NOT NULL IDENTITY(1,1),
	TipoFactura VARCHAR(10) NOT NULL,
	CONSTRAINT PK_TipoFactura PRIMARY KEY(Id_TipoFactura),
	CONSTRAINT UQ_TipoFactura UNIQUE(TipoFactura),
);

INSERT INTO Tipo_Factura(TipoFactura)
VALUES ('Factura A');

INSERT INTO Tipo_Factura(TipoFactura)
VALUES ('Factura B');

INSERT INTO Tipo_Factura(TipoFactura)
VALUES ('Factura C');

INSERT INTO Tipo_Factura(TipoFactura)
VALUES ('Factura E');

INSERT INTO Tipo_Factura(TipoFactura)
VALUES ('Factura M');

CREATE TABLE Venta_Cabecera(
	Id_VentaCabecera INT NOT NULL IDENTITY(1,1),
	FechaFactura DATETIME NOT NULL DEFAULT(GETDATE()),
	MontoTotal FLOAT NOT NULL,
	Id_Cliente INT NOT NULL,
	Id_Usuario INT NOT NULL,
	Id_MetodoPago INT NOT NULL,
	Id_TipoFactura INT NOT NULL,
	Estado VARCHAR(8) DEFAULT 'activo',
	CONSTRAINT PK_VentaCabecera PRIMARY KEY(Id_VentaCabecera),
	CONSTRAINT FK_Cliente FOREIGN KEY(Id_Cliente) REFERENCES Cliente(Id_Cliente),
	CONSTRAINT FK_Usuario FOREIGN KEY(Id_Usuario) REFERENCES Usuario(Id),
	CONSTRAINT FK_MetodoPago FOREIGN KEY(Id_MetodoPago) REFERENCES Metodo_Pago(Id_MetodoPago),
	CONSTRAINT FK_TipoFactura FOREIGN KEY(Id_TipoFactura) REFERENCES Tipo_Factura(Id_TipoFactura),
);

CREATE TABLE Venta_Detalle(
	Id_VentaDetalle INT NOT NULL IDENTITY(1,1),
	PrecioProducto FLOAT NOT NULL,
	Cantidad INT NOT NULL,
	SubTotalProducto FLOAT NOT NULL,
	Id_Libro INT NOT NULL,
	Id_VentaCabecera INT NOT NULL,
	CONSTRAINT PK_VentaDetalle PRIMARY KEY(Id_VentaDetalle),
	CONSTRAINT FK_Libro FOREIGN KEY(Id_Libro) REFERENCES Libro(Id_Libro),
	CONSTRAINT FK_VentaCabecera FOREIGN KEY(Id_VentaCabecera) REFERENCES Venta_Cabecera(Id_VentaCabecera),
);

INSERT INTO Persona (Nombre, Apellido, DNI, Mail, FechaNacimiento)
VALUES ('Mauro', 'Mur', '43208906', 'maurodmur@gmail.com', '2001-02-13');

INSERT INTO Usuario (UserNombre, Contraseña, TipoPerfil, Id_Persona)
VALUES ('admin', HASHBYTES('SHA2_256', 'admin'), 2, SCOPE_IDENTITY());


SELECT * FROM Usuario
SELECT *FROM Persona
SELECT *FROM Libro