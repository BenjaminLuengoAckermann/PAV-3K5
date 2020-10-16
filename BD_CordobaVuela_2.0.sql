--Ejecutar primer linea y luego el resto--

CREATE DATABASE CordobaVuela				--Crea la BD

-- Creacion de Tablas --
USE [CordobaVuela]
GO

CREATE TABLE pais (
	id INT IDENTITY (1, 1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL
	)

CREATE TABLE usuario (
	idUsuario VARCHAR(100) PRIMARY KEY,
	password VARCHAR(50) NOT NULL
	)

CREATE TABLE avion (
	id INT PRIMARY KEY,
	capacidadMax INT NOT NULL,
	añoFabricacion INT NOT NULL,
	descripcion VARCHAR(100),
	borrado VARCHAR(1)
	)

CREATE TABLE pasajero (
	documento INT, 
	idTipoDoc INT, 
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(60) NOT NULL,
	fecha_nac DATETIME NOT NULL, 
	idUsuario VARCHAR(100) NOT NULL, 
	sexo VARCHAR(50) NOT NULL,
	CONSTRAINT pk_pasajero_doc PRIMARY KEY (documento, idTipoDoc)
	)

CREATE TABLE empleado (
	legajo INT IDENTITY (1, 1) PRIMARY KEY, 
	idUsuario VARCHAR(100) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(60) NOT NULL,
	fecha_nac DATETIME NOT NULL,
	sexo VARCHAR(50) NOT NULL
	)



CREATE TABLE tipoDocumento (
	id INT IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(50) NOT NULL, 
	idPais INT NOT NULL
	)

CREATE TABLE pasaje ( 
	nro INT IDENTITY(1, 1) PRIMARY KEY,
	fecha DATETIME NOT NULL, 
	idVuelo INT NOT NULL, 
	idUsuario VARCHAR(100) NOT NULL,
	nroAsiento INT NOT NULL
	)

CREATE TABLE ciudad (
	id INT  IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(50) NOT NULL, 
	idProvincia INT NOT NULL
	)

CREATE TABLE provincia (
	id INT  IDENTITY (1, 1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL, 
	idPais INT NOT NULL
	)


CREATE TABLE aeropuerto (
	id INT  IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(60) NOT NULL, 
	idCiudad INT NOT NULL,
	borrado VARCHAR(1)
	)

CREATE TABLE vuelo (
	nro INT  IDENTITY (1, 1) PRIMARY KEY, 
	fecha DATETIME NOT NULL, 
	precio INT NOT NULL,
	idAeroDestino INT NOT NULL, 
	idAeroOrigen INT NOT NULL, 
	idAvion INT NOT NULL,
	cantVendida INT NOT NULL
	)


--------- FK's ------------

ALTER TABLE provincia ADD CONSTRAINT fk_prov_ciudades FOREIGN KEY (idPais) REFERENCES pais(id)

ALTER TABLE ciudad ADD CONSTRAINT fk_ciudadesAprov FOREIGN KEY (idProvincia) REFERENCES provincia(id)

ALTER TABLE tipoDocumento ADD CONSTRAINT fk_tipoDoc_pais FOREIGN KEY (idPais) REFERENCES pais(id)

ALTER TABLE pasajero ADD CONSTRAINT fk_pasajero_tipDoc FOREIGN KEY (idTipoDoc) REFERENCES tipoDocumento(id)

ALTER TABLE pasajero ADD CONSTRAINT fk_pasajero_user FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)



ALTER TABLE aeropuerto ADD CONSTRAINT fk_aeropuerto_ciudad FOREIGN KEY (idCiudad) REFERENCES ciudad(id)

ALTER TABLE empleado ADD CONSTRAINT fk_empleado_user FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)



ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_destino FOREIGN KEY (idAeroDestino) REFERENCES aeropuerto(id)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_origen FOREIGN KEY (idAeroOrigen) REFERENCES aeropuerto(id)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_avion FOREIGN KEY (idAvion) REFERENCES avion(id)



------ LLENAMOS DE DATOS LAS TABLAS ------

INSERT INTO usuario(idUsuario, password)
VALUES ('Leandro', 'Test123')

INSERT INTO usuario(idUsuario, password)
VALUES ('CheezyB', '79120123')

INSERT INTO usuario(idUsuario, password)
VALUES ('Facu', '78659123')

INSERT INTO usuario(idUsuario, password)
VALUES ('Martin', 'PAV3K52020')




SET IDENTITY_INSERT empleado ON

INSERT INTO	empleado (legajo, idUsuario, nombre, apellido, fecha_nac, sexo)
VALUES (9874, 'CheezyB', 'Benjamin', 'Luengo', CONVERT(DATETIME, '1/01/2001', 103), 'Masculino')

INSERT INTO	empleado (legajo, idUsuario, nombre, apellido, fecha_nac, sexo)
VALUES (8457, 'Facu', 'Facundo', 'Vilanova', CONVERT(DATETIME, '30/07/1998', 103), 'Masculino' )

INSERT INTO	empleado (legajo, idUsuario, nombre, apellido, fecha_nac, sexo)
VALUES (7456, 'Leandro', 'Leandro', 'Rostagno', CONVERT(DATETIME, '30/10/2000', 103), 'Masculino')

INSERT INTO	empleado (legajo, idUsuario, nombre, apellido, fecha_nac, sexo)
VALUES (6847, 'Martin', 'Martin', 'Profe', CONVERT(DATETIME, '10/08/1985', 103), 'Masculino')

SET IDENTITY_INSERT empleado OFF


SET IDENTITY_INSERT pais ON

INSERT INTO pais (id, nombre)
VALUES (1, 'Argentina')

INSERT INTO pais (id, nombre)
VALUES (2, 'Brasil')

INSERT INTO pais (id, nombre)
VALUES (3, 'Colombia')

INSERT INTO pais (id, nombre)
VALUES (4, 'Uruguay')

SET IDENTITY_INSERT Pais OFF


SET IDENTITY_INSERT tipoDocumento ON

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (1, 'Documento Nacional de Identidad', 1)

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (2, 'Cedula', 1)

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (3, 'Tarjeta Nacional', 3)

SET IDENTITY_INSERT tipoDocumento OFF


SET IDENTITY_INSERT Provincia ON

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (1, 'Buenos Aires', 1)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (2, 'Cordoba', 1)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (3, 'Distrito Federal', 2)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (4, 'Rio de Janeiro', 2)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (5, 'Bogota', 3)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (6, 'Bolivar', 3)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (7, 'Montevideo', 4)

INSERT INTO	provincia (id, nombre ,idPais)
VALUES (8, 'Maldonado', 4)

SET IDENTITY_INSERT Provincia OFF


SET IDENTITY_INSERT Ciudad ON

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (1, 'La Plata', 1)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (2, 'Cordoba', 2)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (3, 'Bahia Blanca', 1)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (4, 'Brasilia', 3)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (5, 'Rio de Janeiro', 4)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (6, 'Cabo Frio', 4)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (7, 'Bogota', 5)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (8, 'Cartagena', 6)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (9, 'Montevideo', 7)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (10, 'Punta del Este', 8)

INSERT INTO	ciudad (id, nombre, idProvincia)
VALUES (11, 'Punta Ballena', 8)

SET IDENTITY_INSERT Ciudad OFF


INSERT INTO aeropuerto (nombre, idCiudad)
VALUES ('Aeroparque', 1)

INSERT INTO aeropuerto (nombre, idCiudad)
VALUES ('Pajas Blancas', 2)

INSERT INTO aeropuerto (nombre, idCiudad)
VALUES ('Aeropuerto de Rio de Janeiro', 5)


INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario, sexo)
VALUES (42252333, 1, 'Leandro', 'Rostagno', CONVERT(DATETIME, '30/10/2000', 103), 'Leandro', 'Masculino') 

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario, sexo)
VALUES (42262334, 2, 'Benjamin', 'Luengo Ackermann', CONVERT(DATETIME, '1/01/2001', 103), 'CheezyB', 'Masculino') 

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario, sexo)
VALUES (12313245, 3, 'Facundo', 'Amaranto Vilanova', CONVERT(DATETIME, '30/08/1996', 103), 'Facu', 'Masculino') 

INSERT INTO avion VALUES (757, 200, 2014, 'Boeing 747 Mini', 'N') 
INSERT INTO avion VALUES (213, 450, 2018, 'Boeing 737 MAX', 'N') 
INSERT INTO avion VALUES (852, 300, 2000, 'Boeing 727 Jumbo', 'N') 


UPDATE aeropuerto SET borrado = 'N'
UPDATE avion SET borrado = 'N'




-- Stored Procedures --


-- ATENCION!!! EJECUTAR UN PROCEDIMIENTO POR VEZ



-- =============================================
-- Author:		<Author, Grupo 5 PAV>
-- Description:	<Busca todos los vuelos disponibles con un origen y destino>
-- =============================================

CREATE PROCEDURE FindAll_SP
	@Param1 INT, -- ID Aeropuerto origen
	@Param2 INT, -- ID Aeropuerto destino
	@Param3 VARCHAR(100), -- Fecha
	@Param4 INT --CantidadPasajeros
AS
BEGIN
				SELECT A.id, A.capacidadMax, V.fecha, V.precio, ORI.nombre AS 'origen', DEST.nombre AS 'destino', V.cantVendida, A.capacidadMax - V.cantVendida AS 'Disponibilidad', V.nro AS 'idVuelo' 
                FROM vuelo V JOIN aeropuerto ORI ON V.idAeroOrigen = ORI.id 
                JOIN aeropuerto DEST ON V.idAeroDestino = DEST.id JOIN avion A ON A.id = V.idAvion 
                WHERE 1 = 1 
				AND ORI.id = @Param1 AND DEST.id = @Param2 AND V.fecha = CONVERT(DATETIME, @Param3, 103) AND (A.capacidadMax - V.cantVendida) >= @Param4

END


-- =============================================
-- Author:		<Author, Grupo 5 PAV>
-- Description:	<Busca todos los vuelos disponibles con un origen>
-- =============================================

CREATE PROCEDURE FindAllSinDestino_SP
	@Param1 INT, -- ID Aeropuerto origen
	@Param2 VARCHAR(100), -- Fecha
	@Param3 INT --CantidadPasajeros
AS
BEGIN
				SELECT A.id, A.capacidadMax, V.fecha, V.precio, ORI.nombre AS 'origen', DEST.nombre AS 'destino', V.cantVendida, A.capacidadMax - V.cantVendida AS 'Disponibilidad', V.nro AS 'idVuelo' 
                FROM vuelo V JOIN aeropuerto ORI ON V.idAeroOrigen = ORI.id 
                JOIN aeropuerto DEST ON V.idAeroDestino = DEST.id JOIN avion A ON A.id = V.idAvion 
                WHERE 1 = 1 
				AND ORI.id = @Param1 AND V.fecha = CONVERT(DATETIME, @Param2, 103) AND (A.capacidadMax - V.cantVendida) >= @Param3

END

-- =============================================
-- Author:		<Author, Grupo 5 PAV>
-- Description:	<Busca todos los vuelos disponibles con un origen y destino con fechas posteriores a la elegida>
-- =============================================

CREATE PROCEDURE FindAllConFechasPosteriores_SP
	@Param1 INT, -- ID Aeropuerto origen
	@Param2 INT, -- ID Aeropuerto destino
	@Param3 VARCHAR(100), -- Fecha
	@Param4 INT --CantidadPasajeros
AS
BEGIN
				SELECT A.id, A.capacidadMax, V.fecha, V.precio, ORI.nombre AS 'origen', DEST.nombre AS 'destino', V.cantVendida, A.capacidadMax - V.cantVendida AS 'Disponibilidad', V.nro AS 'idVuelo' 
                FROM vuelo V JOIN aeropuerto ORI ON V.idAeroOrigen = ORI.id 
                JOIN aeropuerto DEST ON V.idAeroDestino = DEST.id JOIN avion A ON A.id = V.idAvion 
                WHERE 1 = 1 
				AND ORI.id = @Param1 AND DEST.id = @Param2 AND V.fecha >= CONVERT(DATETIME, @Param3, 103) AND (A.capacidadMax - V.cantVendida) >= @Param4

END



-- =============================================
-- Author:		<Author, Grupo 5 PAV>
-- Description:	<Busca todos los vuelos disponibles con un origen y fechas posteriores a la elegida>
-- =============================================

CREATE PROCEDURE FindAllSinDestinoConFechasPosteriores_SP
	@Param1 INT, -- ID Aeropuerto origen
	@Param2 VARCHAR(100), -- Fecha
	@Param3 INT --CantidadPasajeros
AS
BEGIN
				SELECT A.id, A.capacidadMax, V.fecha, V.precio, ORI.nombre AS 'origen', DEST.nombre AS 'destino', V.cantVendida, A.capacidadMax - V.cantVendida AS 'Disponibilidad', V.nro AS 'idVuelo' 
                FROM vuelo V JOIN aeropuerto ORI ON V.idAeroOrigen = ORI.id 
                JOIN aeropuerto DEST ON V.idAeroDestino = DEST.id JOIN avion A ON A.id = V.idAvion 
                WHERE 1 = 1 
				AND ORI.id = @Param1 AND V.fecha >= CONVERT(DATETIME, @Param2, 103) AND (A.capacidadMax - V.cantVendida) >= @Param3

END

