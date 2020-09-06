--Ejecturar primer linea y luego el resto--

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

CREATE TABLE estado (
	id INT  IDENTITY (1, 1) PRIMARY KEY, 
	descripcion VARCHAR(50) NOT NULL
	)

CREATE TABLE equipaje (
	id INT PRIMARY KEY, 
	peso FLOAT NOT NULL
	)

CREATE TABLE cobro (
	nro INT IDENTITY (1, 1) PRIMARY KEY,
	fechaCobro DATETIME NOT NULL,
	importe FLOAT NOT NULL
	)

CREATE TABLE clase (
	id INT IDENTITY (1, 1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL
	)

CREATE TABLE cargo (
	id INT IDENTITY (1, 1) PRIMARY KEY,
	descripcion VARCHAR(100)
	)

CREATE TABLE avion (
	id INT PRIMARY KEY,
	descripcion VARCHAR(100)
	)

CREATE TABLE reserva (
	nro INT  IDENTITY (1, 1) PRIMARY KEY, 
	fecha DATETIME NOT NULL,
	idEstado INT NOT NULL, 
	nroCobro INT
	)

CREATE TABLE venta (
	nro  INT IDENTITY (1, 1) PRIMARY KEY, 
	nroCobro INT NOT NULL, 
	fechaVenta DATETIME NOT NULL
	)

CREATE TABLE pasajero (
	documento INT, 
	idTipoDoc INT, 
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(60) NOT NULL,
	fecha_nac DATETIME NOT NULL, 
	idUsuario VARCHAR(100) NOT NULL, 
	CONSTRAINT pk_pasajero_doc PRIMARY KEY (documento, idTipoDoc)
	)

CREATE TABLE provincia (
	id INT  IDENTITY (1, 1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL, 
	idPais INT NOT NULL
	)


CREATE TABLE tipoDocumento (
	id INT IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(50) NOT NULL, 
	idPais INT NOT NULL
	)

CREATE TABLE tarifa (
	idClase INT, 
	nroVuelo INT, 
	capacidad INT NOT NULL, 
	precio FLOAT NOT NULL, 
	CONSTRAINT pk_tarifa_idClaseyVuelo PRIMARY KEY (idClase, nroVuelo)
	)

CREATE TABLE ciudad (
	id INT  IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(50) NOT NULL, 
	idProvincia INT NOT NULL
	)

CREATE TABLE empleado (
	legajo INT  IDENTITY (1, 1) PRIMARY KEY, 
	idUsuario VARCHAR(100) NOT NULL
	)

CREATE TABLE aeropuerto (
	id INT  IDENTITY (1, 1) PRIMARY KEY, 
	nombre VARCHAR(60) NOT NULL, 
	idCiudad INT NOT NULL
	)

CREATE TABLE vuelo (
	nro INT PRIMARY KEY, 
	fecha DATETIME NOT NULL, 
	horaEmbarque VARCHAR(5),
	idEstado INT NOT NULL, 
	idDestino INT NOT NULL, 
	idOrigen INT NOT NULL, 
	idAvion INT NOT NULL, 
	fechaReal DATETIME, 
	horaEmReal VARCHAR(5)
	)

CREATE TABLE pasaje (
	docPasajero INT, 
	idTipoDoc INT, 
	nroVuelo INT, 
	idClase INT NOT NULL, 
	fila INT NOT NULL, 
	asiento INT NOT NULL, 
	nroReserva INT, 
	nroVenta INT NOT NULL, 
	idEquipaje INT, 
	CONSTRAINT pk_pasaje_DocyVuelo PRIMARY KEY (docPasajero, idTipoDoc, nroVuelo)
	)

CREATE TABLE vueloXempleado (
	nroVuelo INT,
	legajoEmpleado INT, 
	idCargo INT NOT NULL, 
	CONSTRAINT pk_vueloXempleado PRIMARY KEY (nroVuelo, legajoEmpleado)
	)


--------- FK's ------------

ALTER TABLE provincia ADD CONSTRAINT fk_prov_ciudades FOREIGN KEY (idPais) REFERENCES pais(id)

ALTER TABLE ciudad ADD CONSTRAINT fk_ciudadesAprov FOREIGN KEY (idProvincia) REFERENCES provincia(id)

ALTER TABLE reserva ADD CONSTRAINT fk_reserva_estado FOREIGN KEY (idEstado) REFERENCES estado(id)

ALTER TABLE reserva ADD CONSTRAINT fk_reserva_nroCobro FOREIGN KEY (nroCobro) REFERENCES cobro(nro)

ALTER TABLE venta ADD CONSTRAINT fk_venta_nroCobro FOREIGN KEY (nroCobro) REFERENCES cobro(nro)

ALTER TABLE tipoDocumento ADD CONSTRAINT fk_tipoDoc_pais FOREIGN KEY (idPais) REFERENCES pais(id)

ALTER TABLE pasajero ADD CONSTRAINT fk_pasajero_tipDoc FOREIGN KEY (idTipoDoc) REFERENCES tipoDocumento(id)

ALTER TABLE pasajero ADD CONSTRAINT fk_pasajero_user FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)

ALTER TABLE tarifa ADD CONSTRAINT fk_tarifa_clase FOREIGN KEY (idClase) REFERENCES clase(id)

ALTER TABLE tarifa ADD CONSTRAINT fk_tarifa_nroVuelo FOREIGN KEY (nroVuelo) REFERENCES vuelo(nro)

ALTER TABLE aeropuerto ADD CONSTRAINT fk_aeropuerto_ciudad FOREIGN KEY (idCiudad) REFERENCES ciudad(id)

ALTER TABLE empleado ADD CONSTRAINT fk_empleado_user FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_estado FOREIGN KEY (idEstado) REFERENCES estado(id)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_destino FOREIGN KEY (idDestino) REFERENCES aeropuerto(id)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_origen FOREIGN KEY (idOrigen) REFERENCES aeropuerto(id)

ALTER TABLE vuelo ADD CONSTRAINT fk_vuelo_avion FOREIGN KEY (idAvion) REFERENCES avion(id)

ALTER TABLE vueloXempleado ADD CONSTRAINT fk_vueloXempleado_vuelo FOREIGN KEY (nroVuelo) REFERENCES vuelo(nro)

ALTER TABLE vueloXempleado ADD CONSTRAINT fk_vueloXempleado_empleado FOREIGN KEY (legajoEmpleado) REFERENCES empleado(legajo)

ALTER TABLE vueloXempleado ADD CONSTRAINT fk_vueloXempleado_cargo FOREIGN KEY (idCargo) REFERENCES cargo(id)

ALTER TABLE pasaje ADD CONSTRAINT fk_pasaje_nroDoc FOREIGN KEY (docPasajero, idTipoDoc) REFERENCES pasajero(documento, idTipoDoc)

ALTER TABLE pasaje ADD CONSTRAINT fk_pasaje_nroVuelo FOREIGN KEY (nroVuelo) REFERENCES vuelo(nro)



------ LLENAMOS DE DATOS LAS TABLITAS ------

INSERT INTO usuario(idUsuario, password)
VALUES ('Leandro', 'test123')

INSERT INTO usuario(idUsuario, password)
VALUES ('CheezyB', 'marceloGallardo')

INSERT INTO usuario(idUsuario, password)
VALUES ('Kundo', 'laJoya')

INSERT INTO usuario(idUsuario, password)
VALUES ('daddy_issues777', '777')


SET IDENTITY_INSERT pais ON

INSERT INTO pais (id, nombre)
VALUES (1, 'Argentina')

INSERT INTO pais (id, nombre)
VALUES (2, 'Francia')

INSERT INTO pais (id, nombre)
VALUES (3, 'Congo')

SET IDENTITY_INSERT pais OFF

SET IDENTITY_INSERT tipoDocumento ON

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (1, 'Documento Nacional de Identidad', 1)

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (2, 'Cedula', 1)

INSERT INTO	tipoDocumento (id, nombre, idPais)
VALUES (3, 'Tarjeta Nacional', 3)

SET IDENTITY_INSERT tipoDocumento OFF

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario)
VALUES (42252333, 1, 'Leandro', 'Rostagno', CONVERT(DATETIME, '30/10/2000', 103), 'Leandro') 

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario)
VALUES (42262333, 2, 'Benjamin', 'Luengo Ackermann', CONVERT(DATETIME, '1/01/2001', 103), 'CheezyB') 

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario)
VALUES (12313245, 3, 'Facundo', 'Amaranto', CONVERT(DATETIME, '30/08/1996', 103), 'Kundo') 

INSERT INTO pasajero (documento, idTipoDoc, nombre, apellido, fecha_nac, idUsuario)
VALUES (40005333, 2, 'Ramiro', 'Schopenhauer', CONVERT(DATETIME, '5/04/1950', 103), 'daddy_issues777') 


















