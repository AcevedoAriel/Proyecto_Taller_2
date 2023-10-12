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
	id_usuario int identity (1,1) not null,	
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
	estado int NOT NULL,
	/*Restricciones*/
	CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT CK_estado CHECK (estado in (0,1)),
	CONSTRAINT FK_Usuario_Perfil FOREIGN KEY (usuario_perfil) REFERENCES perfil (cod_perfil)
	)

/*Lote de Perfi*/
insert into perfil (cod_perfil, nombre) values(1, 'Super Usuario');		
insert into perfil (cod_perfil, nombre) values(2, 'Administrador');		
insert into perfil (cod_perfil, nombre) values(3, 'Recepcionista');


CREATE TABLE servicios(
		cod_servicio int identity (1,1) not null,
		nombre	VARCHAR (150) NOT NULL,
		precio   DECIMAL (5 ,2),

		CONSTRAINT PK_cod_serv PRIMARY KEY (cod_servicio),

)

CREATE TABLE habitacion(
	id_habitacion int identity (1,1) not null,
	piso int not null,
	nro_habitacion int  not null,
	id_estado int not null,
	precio decimal (5,2) not null,
	id_categoria int not null,
	cantidad_camas int not null
)

CREATE TABLE categoriaHabitacion(
		id_categoria int identity (1,1) not null,
		descripcion varchar (150) not null
)

CREATE TABLE reserva(

)


select * from usuario