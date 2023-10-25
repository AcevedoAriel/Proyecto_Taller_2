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
	estado varchar(10) NOT NULL,
	/*Restricciones*/
	CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT CK_estado CHECK (estado in ('Inactivo','Activo')),
	CONSTRAINT FK_Usuario_Perfil FOREIGN KEY (usuario_perfil) REFERENCES perfil (cod_perfil)
	)


/*Lote de Perfi*/
select * from perfil
insert into perfil (cod_perfil, nombre) values(1, 'Super Usuario');		
insert into perfil (cod_perfil, nombre) values(2, 'Administrador');		
insert into perfil (cod_perfil, nombre) values(3, 'Recepcionista');

/*Lote de Usuario*/
select * from usuario
insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc,sexo, estado)
values(37393962, 'Acevedo', 'Ariel', 'Arielo90', '123456', '37393962', 1, 'ariel@gmail.com', '1993-16-06 14:30:00', 'Hombre', 'Activo');
insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc,sexo, estado)
values(38791452, 'Pineyro', 'Juan', 'Juanma10', '7891011', '64589874', 2, 'juanma@gmail.com', '1996-10-06 02:00:00', 'Hombre', 'Activo');
insert into usuario(dni, apellido, nombre, nombreUsuario, clave, telefono, usuario_perfil, correo, fechaNAc,sexo, estado)
values(14521369, 'Gomez', 'Maria', 'Maria18', '12131415', '14525632', 3, 'mariagmz@gmail.com', '1969-03-01 03:00:00', 'Mujer', 'Activo');

select * from habitacion
delete from habitacion
insert into habitacion (piso, nro_habitacion, id_estado, precio, categoria, cantidad_camas)
values(1, 25, 2, 42.12 , 1, 2)
insert into habitacion (piso, nro_habitacion, id_estado, precio, categoria, cantidad_camas)
values(1, 45, 1, 42.12 , 2, 1)

select * from estado_habitacion
insert into estado_habitacion(descripcion) values ('Ocupada')
insert into estado_habitacion(descripcion) values ('Libre')
insert into estado_habitacion(descripcion) values ('Mantenimiento')

select * from categoriaHabitacion
delete from categoriaHabitacion
TRUNCATE TABLE categoriaHabitacion;
DBCC CHECKIDENT ('categoriaHabitacion', RESEED, 0);
insert into categoriaHabitacion(descripcion) values ('Simple')
insert into categoriaHabitacion(descripcion) values ('Matrimonial')
insert into categoriaHabitacion(descripcion) values ('Ejecutivo')


CREATE TABLE habitacion(
	id_habitacion int identity (1,1) not null,
	piso int not null,
	nro_habitacion int  not null,
	id_estado int not null,
	precio decimal (5,2) not null,
	categoria int not null,
	cantidad_camas int not null,
	constraint pk_idHabitacion primary key (id_habitacion),
	constraint fk_categoria foreign key (categoria) references categoriaHabitacion (id_categoria),
	constraint fk_id_estado foreign key (id_estado) references estado_habitacion (id_estado)
)

CREATE TABLE estado_habitacion(
		id_estado int identity (1,1) not null,
		descripcion varchar (150) not null,
		constraint pk_id_estado primary key (id_estado)
)


CREATE TABLE categoriaHabitacion(
		id_categoria int identity (1,1) not null,
		descripcion varchar (150) not null,
		constraint pk_categoria primary key (id_categoria)
)

select * from habitacion


CREATE TABLE cliente(
	id_cliente int identity (1,1) not null,
	dni int not null,
	apellido varchar (100) not null,
	nombre varchar (100) not null,
	telefono varchar (100) not null,
	constraint pk_idCliente primary key (id_cliente)
)

CREATE TABLE reserva(
	id_reserva int identity (1,1) not null,
	cant_personas int not null,
	fecha_ingreso date not null,
	fecha_retiro date not null,
	id_habitacion int not null,
	id_cliente int not null,
	precio decimal (10,2),
	constraint pk_idReserva primary key (id_reserva),
	constraint fk_idHabitacion foreign key (id_habitacion) references habitacion (id_habitacion),
	constraint fk_id_cliente foreign key (id_cliente) references cliente (id_cliente)
)

CREATE TABLE servicios(
		cod_servicio int identity (1,1) not null,
		id_detalle int not null,
		nombre	VARCHAR (150) NOT NULL,
		precio   DECIMAL (5 ,2),
		CONSTRAINT PK_cod_serv PRIMARY KEY (cod_servicio),
)

CREATE TABLE DetalleServicios(
	id_reserva int  not null,
	cod_servicio int not null,
	precio decimal (5, 2),
	constraint pk_id_reserva_servicio primary key (id_reserva, cod_servicio),
	constraint fk_id_reserva foreign key (id_reserva) references reserva (id_reserva),
	constraint fk_codServicioa foreign key (cod_servicio) references servicios (cod_servicio)
)


CREATE TABLE factura(
		id_factura int identity (1,1) not null,
		id_tipo_pago int not null,
		id_cliente int not null,
		no_cuotas int not null,
		fecha_pago date not null,
		costo_habitacion   DECIMAL (10 ,2),
		costo_servicios   DECIMAL (10 ,2),
		costo_total   DECIMAL (10 ,2),
		constraint fk_idCliente foreign key (id_cliente) references cliente (id_cliente),
		constraint fk_idTipoPago foreign key (id_tipo_pago) references tipo_pago (id_tipo_pago),
		CONSTRAINT PK_idFactura PRIMARY KEY (id_factura)
)

CREATE TABLE tipo_pago(
		id_tipo_pago int identity (1,1) not null,
		descripcion varchar (100) not null,
		CONSTRAINT PK_idTipoPago PRIMARY KEY (id_tipo_pago)

)



select habitacion.id_habitacion as ID, habitacion.piso as Piso, habitacion.nro_habitacion as NroHabitacion, estado_habitacion.descripcion as Estado, habitacion.precio as Precio, categoriaHabitacion.descripcion 
as Categoria, habitacion.cantidad_camas as NroCamas
from habitacion
JOIN estado_habitacion ON habitacion.id_estado = estado_habitacion.id_estado
JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria