/*Creacion de la Base de Datos Hotel*/
CREATE	DATABASE GESTION_HOTELERA

USE GESTION_HOTELERA

/*Creacion de Tablas*/
CREATE TABLE perfil(
	cod_perfil int NOT NULL,
	nombre VARCHAR(110) NOT NULL,
	CONSTRAINT PK_perfil PRIMARY KEY (cod_perfil)
)
CREATE TABLE usuario(
	dni INT NOT NULL,
	apellido VARCHAR(100) NOT NULL,
	nombre VARCHAR (100) NOT NULL,
    nombreUsuario VARCHAR(100) NOT NULL,
    clave VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
	usuario_perfil INT NOT NULL,
    correo VARCHAR(100) NOT NULL,
    fechaNAc DATETIME NOT NULL,
	sexo varchar(10)  NOT NULL,
	estado varchar(150) NOT NULL
	/*Restricciones*/
	CONSTRAINT PK_dniUsuario PRIMARY KEY (dni),
	CONSTRAINT FK_Usuario_Perfil FOREIGN KEY (usuario_perfil) REFERENCES perfil (cod_perfil)
	)

/*Lote de Perfi*/
insert into perfil (cod_perfil, nombre) values(1, 'Super Usuario');		
insert into perfil (cod_perfil, nombre) values(2, 'Administrador');		
insert into perfil (cod_perfil, nombre) values(3, 'Recepcionista');


		