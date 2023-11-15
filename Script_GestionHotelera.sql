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

insert into perfil (cod_perfil, nombre) values(1, 'Super Usuario');		
insert into perfil (cod_perfil, nombre) values(2, 'Administrador');		
insert into perfil (cod_perfil, nombre) values(3, 'Recepcionista');

/*Lote de Usuario*/


INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (37393962, N'Acevedo', N'Ariel', N'Arielo90', N'$2a$12$ABAlkdsDFwYmbMhJ2r3x8.u/vh39jzIS4.aWIYy3cZh/w9zStHdhW', N'37393962', 1, N'ariel@gmail.com', CAST(N'1993-06-16T14:30:00.000' AS DateTime), N'Hombre', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (38791452, N'Pineyro', N'Juan', N'Juanma10', N'$2a$12$UxM2AWJdaKV7DXW1MUQ.RuEXmSBr1lDxPlOQSa2RAnSsR52dtKpxa', N'64589874', 2, N'juanma@gmail.com', CAST(N'1996-06-10T02:00:00.000' AS DateTime), N'Hombre', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (14521369, N'Gomez', N'Maria', N'Maria18', N'$2a$12$NniDmVQTs1JLlW18X.czlemW1uVeBjyKw6sSjje7X8.U5HFXuIKcy', N'14525632', 3, N'mariagmz@gmail.com', CAST(N'1969-01-03T03:00:00.000' AS DateTime), N'Mujer', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (2345345, N'pineyrodos', N'juandos', N'juan2', N'$2a$12$GbWt.KpvduQEuryAgd.OLOxUTT0p8sK8K25t/yoWEZ0WpeQWX/NK2', N'2345345', 2, N'juan2@gmail.com', CAST(N'2021-11-05T10:15:50.000' AS DateTime), N'Hombre', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (43545, N'dfgsdfg', N'fgsfdg', N'efgdvsdfxcv', N'$2a$12$Q0KBnSzKgrEdFvHvrl2H8.fHo2eKeOpzgeqB9GtWEs7ufrAzLw.z2', N'4533456', 1, N'sdfgsdfgsdf@sf.com', CAST(N'2023-10-27T10:17:00.000' AS DateTime), N'Hombre', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (452345345, N'Fulano', N'Alguien', N'fulano', N'$2a$12$Q0KBnSzKgrEdFvHvrl2H8.fHo2eKeOpzgeqB9GtWEs7ufrAzLw.z2', N'45354234', 1, N'fulanosoy@gmial.com', CAST(N'2023-10-27T11:25:00.000' AS DateTime), N'Mujer', N'Activo')
INSERT [dbo].[usuario] ([dni], [apellido], [nombre], [nombreUsuario], [clave], [telefono], [usuario_perfil], [correo], [fechaNAc], [sexo], [estado]) 
VALUES (2352435, N'asdfasd', N'dsdasf', N'asdfasdf', N'$2a$10$CDOvZsw.v8s9MqKO/idIa.8f6oan3Pm.PcANI1MrnYcEj/KxpOKNi', N'363456', 1, N'sdfgd@d.com', CAST(N'2023-10-27T11:32:49.000' AS DateTime), N'Hombre', N'Activo')


select * from habitacion
delete from habitacion
insert into habitacion (piso, nro_habitacion, id_estado, precio, categoria, cantidad_camas)
values(1, 25, 2, 4200 , 1, 2)
insert into habitacion (piso, nro_habitacion, id_estado, precio, categoria, cantidad_camas)
values(1, 45, 1, 5500 , 2, 2)

select * from estado_habitacion
insert into estado_habitacion(descripcion) values ('Ocupada')
insert into estado_habitacion(descripcion) values ('Libre')
insert into estado_habitacion(descripcion) values ('Mantenimiento')


drop table factura
select * from categoriaHabitacion
delete from DetalleServicios
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
	precio varchar(20) not null,
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
delete from reserva
delete from factura

alter table factura drop column no_cuotas 

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
	precio decimal (10,2),
	constraint pk_idReserva primary key (id_reserva),
	constraint fk_idHabitacion foreign key (id_habitacion) references habitacion (id_habitacion),

)

alter table servicios alter column precio decimal(8,2) not null

select h.nro_habitacion, r.precio, sum(s.precio) as 'Total Servicios', STRING_AGG(s.nombre, ',') as 'Servicios' from reserva as r
full outer join DetalleServicios as ds on r.id_reserva = ds.id_reserva
full outer join servicios as s on ds.cod_servicio = s.cod_servicio
full outer join habitacion as h on r.id_habitacion = h.id_habitacion
where r.id_reserva = 39
GROUP BY  h.nro_habitacion, r.precio



delete from DetalleServicios
select * from servicios
CREATE TABLE servicios(
		cod_servicio int identity (1,1) not null,
		nombre	VARCHAR (150) NOT NULL,
		precio decimal(8,2) NOT NULL,
		CONSTRAINT PK_cod_serv PRIMARY KEY (cod_servicio),
)

CREATE TABLE DetalleServicios(
	id_detalle int identity (1,1) not null,
	id_reserva int  not null,
	cod_servicio int not null,
	constraint pk_id_detalle primary key (id_detalle),
	constraint fk_idReserva foreign key (id_reserva) references reserva (id_reserva),
	constraint fk_codServicioa foreign key (cod_servicio) references servicios (cod_servicio)
)
select id_habitacion from habitacion where nro_habitacion = 342 

CREATE TABLE factura(
		id_factura int identity (1,1) not null,
		id_tipo_pago int not null,
		id_cliente int not null,
		id_reserva int not null,
		fecha_pago date not null,
		costo_habitacion   DECIMAL (10 ,2),
		costo_servicios   DECIMAL (10 ,2),
		costo_total   DECIMAL (10 ,2),
		constraint fk_idCliente foreign key (id_cliente) references cliente (id_cliente),
		constraint fk_idTipoPago foreign key (id_tipo_pago) references tipo_pago (id_tipo_pago),
	    constraint fk_id_reserva foreign key (id_reserva) references reserva (id_reserva),
		CONSTRAINT PK_idFactura PRIMARY KEY (id_factura)
)

CREATE TABLE tipo_pago(
		id_tipo_pago int identity (1,1) not null,
		descripcion varchar (100) not null,
		CONSTRAINT PK_idTipoPago PRIMARY KEY (id_tipo_pago)

)

select * from DetalleServicios where id_reserva = 12


select * from perfil
select * from usuario
select * from estado_habitacion


update estado_habitacion
set descripcion = 'Deshabilitada'
where id_estado = 1


update estado_habitacion
set descripcion = 'Habilitada'
where id_estado = 2


delete from estado_habitacion where id_estado = 3
select * from habitacion
delete from habitacion
select * from cliente
select * from reserva
delete from reserva
select * from factura
delete from factura
select * from tipo_pago
select * from DetalleServicios
delete from DetalleServicios



select id_tipo_pago, descripcion from tipo_pago

insert into tipo_pago (descripcion) values ('Crédito')
insert into tipo_pago (descripcion) values ('Débito')
insert into tipo_pago (descripcion) values ('Efectivo')




select habitacion.id_habitacion as ID, habitacion.piso as Piso, habitacion.nro_habitacion as NroHabitacion, estado_habitacion.descripcion as Estado, habitacion.precio as Precio, categoriaHabitacion.descripcion 
as Categoria, habitacion.cantidad_camas as NroCamas
from habitacion
JOIN estado_habitacion ON habitacion.id_estado = estado_habitacion.id_estado
JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria






CREATE PROCEDURE ObtenerHabitacionesDisponibles
    @fechaDesde DATETIME,
    @fechaHasta DATETIME
AS
BEGIN
    SELECT
        habitacion.id_habitacion AS ID,
        habitacion.piso AS Piso,
        habitacion.nro_habitacion AS NroHabitacion,
        habitacion.precio AS Precio,
        categoriaHabitacion.descripcion AS Categoria,
        habitacion.cantidad_camas AS NroCamas
    FROM
        habitacion
        JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria
        LEFT JOIN reserva AS r ON r.id_habitacion = habitacion.id_habitacion
    WHERE
        habitacion.id_estado = 2
        AND (r.fecha_ingreso IS NULL OR NOT (@fechaDesde BETWEEN r.fecha_ingreso AND r.fecha_retiro OR @fechaHasta BETWEEN r.fecha_ingreso AND r.fecha_retiro));
END;




CREATE PROCEDURE ObtenerHabitacionesDisponiblesConFiltros
    @fechaDesde DATETIME,
    @fechaHasta DATETIME,
    @piso INT = NULL,
    @categoria INT = NULL
    
AS
BEGIN
    SELECT
        habitacion.id_habitacion AS ID,
        habitacion.piso AS Piso,
        habitacion.nro_habitacion AS 'Nro de Habitacion',
        habitacion.precio AS Precio,
        categoriaHabitacion.descripcion AS Categoria,
		habitacion.cantidad_camas AS 'Nro de Camas'
        
    FROM
        habitacion
        JOIN categoriaHabitacion ON habitacion.categoria = categoriaHabitacion.id_categoria
        LEFT JOIN reserva AS r ON r.id_habitacion = habitacion.id_habitacion
    WHERE
        habitacion.id_estado = 2
        AND (r.fecha_ingreso IS NULL OR NOT (@fechaDesde BETWEEN r.fecha_ingreso AND r.fecha_retiro OR @fechaHasta BETWEEN r.fecha_ingreso AND r.fecha_retiro))
        AND (@piso IS NULL OR habitacion.piso = @piso)
        AND (@categoria IS NULL OR habitacion.categoria = @categoria);
END;





SELECT DATENAME(MONTH, fecha_ingreso),  COUNT(*) AS CantidadReservas
                                  FROM reserva
                                  WHERE fecha_ingreso BETWEEN '2023-11-11' AND '2024-03-27' OR fecha_retiro BETWEEN '2023-11-11' AND '2023-11-27'
                                  GROUP BY DATENAME(MONTH, fecha_ingreso)  
								  order by DATENAME(MONTH, fecha_ingreso) asc
								  
								  DATEPART(MONTH, fecha_ingreso)

SELECT 
    MIN(DATEPART(MONTH, fecha_ingreso)) as MesInicio,
    MAX(DATEPART(MONTH, fecha_retiro)) as MesFin,
    COUNT(*) AS CantReservas 
FROM reserva 
WHERE 
    (fecha_ingreso BETWEEN '22-01-2023' AND '22-01-2025' ) OR 
    (fecha_retiro BETWEEN '22-01-2023' AND '22-01-2025') OR
    (fecha_ingreso < '22-01-2023' AND fecha_retiro > '22-01-2025')
GROUP BY 
    DATEDIFF(MONTH, 0, fecha_ingreso), 
    DATEDIFF(MONTH, 0, fecha_retiro);


 SELECT DATEPART(MONTH, fecha_ingreso) as MesIngreso, DATEPART(MONTH, fecha_retiro) as MesRetiro, COUNT (*) AS CantReservas 
 from reserva
  where DATEPART(YEAR, fecha_ingreso) = 2023 AND DATEPART(YEAR, fecha_retiro) = 2023
  GROUP BY DATEPART(MONTH, fecha_ingreso), DATEPART(MONTH, fecha_retiro)

 
 


 SELECT top 1  s.cod_servicio,  s.nombre,  count(*) as ServiciosCantidad 
 from DetalleServicios ds
 join servicios s ON ds.cod_servicio = s.cod_servicio
 GROUP BY s.cod_servicio, s.nombre
 ORDER BY ServiciosCantidad




