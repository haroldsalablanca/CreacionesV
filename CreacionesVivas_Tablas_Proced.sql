CREATE DATABASE BD_CREACIONESVIVAS
GO

USE BD_CREACIONESVIVAS
GO

-- Versión: SQL Server 2014 Managerment Studio: 12.0.2000.8

-- Creación de tablas --
create table Usuario(								--->	-- [Usuario]: Asignada para los administradores 
idUsuario int Primary key identity (1,1),					-- que tengan acceso al sistema e ingresar los datos 
Cedula varchar (15),				 						-- y especificaciones de cada Usuario que sea autorizado	
Nombres varchar (50),										-- en "CREACIONES VIVAS".
Apellidos varchar (50),
Direccion varchar (80),
Telefono varchar(10),
constraint Usuario_Cedula unique (Cedula, Telefono));

create table Clientes(								--->	-- [Clientes]: El administrador agrega al sistema 
idCliente int primary key identity (1,1),					-- datos específicos de los clientes que realicen 
Nombres varchar (80),										-- compras de los productos, para mejor seguridad y 
Apellidos varchar (80),										-- contar con la información necesaria al realizar el envío.
Cedula varchar(15),
Direccion varchar (100),
Telefono varchar(10),
Email varchar (80),
constraint Clientes_Cedula unique (Cedula, Email, Telefono));

create table RedSocial(							   --->     -- [REdSocial]: Específicamente del Cliente el idRedSocial, 
idRedSocial int primary key identity (1,1),					-- Nombre de la Red Social del Cliente, como referencia de donde   
NombreR varchar (80),										-- ha realizado la visualización de los productos que son publicados  
idCliente int,												-- en las redes sociales: Facebook, Instagram.
foreign key (idCliente) references Clientes (idCliente));

create table Factura(							    --->    -- [Factura]: Será el registro de las compras realiazas por los
idFactura int primary key identity (1,1),					-- clientes con idFactura diferente por cada una de ellas, la fecha 
Fecha varchar(30),												-- que es realizada la compra y un idCliente. 
idCliente int,
foreign key (idCliente) references Clientes (idCliente));

create table Producto(							    --->    -- [Producto]: Aquí se especifica detalladamente los productos que son 
idProducto int primary key identity (1,1),					-- vendidos y publicados en las redes sociales, con idProducto para dada uno,
Nombre varchar (100),										-- nombres, colores, descripción que tienen, así como el tamaño y el precio.
Colores varchar (80),										-- Estos datos solo serán agregados por el administrador.
Descripcion varchar (150),
Tamaño varchar(10),
Precio int);

create table DetalleFact(							--->    -- [DetalleFact]: En dicha tabla son datos que se presentaran en 
Descripcion varchar (180),									-- los datos generales de la factura que son muy importantes para el 
CantidadV int,												-- administrador por que se determina la descripción del producto, cantidad
Precio int,													-- que compra, precio de cada producto o servicio. Como detalles de la 
idFactura int,												-- factura se requiere del idFactura de la tabla [Factura] y el idProducto 
idProducto int,											    -- de la tabla [Producto] para que sean reflejadas como referencias.
foreign key (idFactura) references Factura (idFactura),
foreign key (idProducto) references Producto (idProducto));

create table Pedidos(								--->	-- [Pedidos]: El usuario o administrador del sistema 
idPedido int primary key identity (1,1),					-- llena los datos en el sistema de los pedidos que se
DireccionEnvio varchar (80),								-- realicen por los clientes, especificando la Dirección 
CatidadSolicitada varchar (20),								-- del envío, cantidad, fecha solicitada del producto y
FechaSolicitud varchar(50),									-- fecha de entrega. Con una llave foranea del idUsuario
FechaEntrega varchar(50),										-- de la tabla USUARIO y una llave foranea del idCliente
idUsuario int,												-- de la tabla Cliente, como referencias para realizar el pedido.
idCliente int,
foreign key (idUsuario) references Usuario (idUsuario),
foreign key (idCliente) references Clientes (idCliente));

----------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[Cliente]    Script Date: 15/06/2020 4:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author: Harold Salablanca>
-- Create date: <Create Date: 23-05-2020>
-- Description:	<Description, Precedimiento almacenado de Clientes>
-- =============================================
CREATE PROCEDURE [dbo].[Cliente]
	-- Add the parameters for the stored procedure here
	@b int, @idCliente int, @Nombres varchar(80), @Apellidos varchar(80), @Cedula varchar(15),
	@Direccion varchar(100), @Telefono Varchar(10), @Email varchar(80)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into Clientes values (@Nombres, @Apellidos, @Cedula,	@Direccion, @Telefono, @Email);
	IF @b=2
		delete from Clientes where idCliente=@idCliente;
	IF @b=3
		select * from Clientes
	If @b=4
	UPDATE Clientes SET Nombres=@Nombres, Apellidos=@Apellidos, Cedula=@Cedula,	Direccion=@Direccion, Telefono=@Telefono, Email=@Email
		WHERE idCliente=@IdCliente
	IF @b=5
		SELECT * FROM Clientes
		WHERE Nombres LIKE '%' +@Nombres + '%'
END
go

------------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[DetalleFactura]    Script Date: 15/06/2020 4:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author: Harold Salablanca>
-- Create date: <Create Date: 23-05-2020>
-- Description:	<Description, Precedimiento almacenado de DetalleFact>
-- =============================================
CREATE PROCEDURE [dbo].[DetalleFactura]
	-- Add the parameters for the stored procedure here
	@b int, @Descripcion varchar(180), @CantidadV int, @Precio int,	@idFactura int, @idProducto int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into DetalleFact values (@Descripcion, @CantidadV, @Precio,	@idFactura, @idProducto)
--	IF @b=2
	--	delete from DetalleFact where idCliente=@idCliente;
	IF @b=3
		select * from DetalleFact
	If @b=4
	UPDATE DetalleFact SET Descripcion=@Descripcion, CantidadV=@CantidadV, Precio=@Precio, idFactura=@idFactura, idProducto=@idProducto
		WHERE Descripcion=@Descripcion
	IF @b=5
		SELECT * FROM DetalleFact
		WHERE Descripcion LIKE '%' +@Descripcion + '%'
END

-------------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[Facturas]    Script Date: 14/06/2020 23:55:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author: Harold Salablanca>
-- Create date: <Create Date: 23-05-2020>
-- Description:	<Description, Precedimiento almacenado de Factura>
-- =============================================
CREATE PROCEDURE [dbo].[Facturas]
	-- Add the parameters for the stored procedure here
	@b int, @idFactura int, @Fecha varchar(30), @idCliente int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into Factura values (@Fecha, @idCliente)
	IF @b=2
		delete from Factura where idCliente=@idCliente;
	IF @b=3
		select * from Factura
	If @b=4
	UPDATE Factura SET Fecha=@Fecha, idCliente=@idCliente
		WHERE idFactura=@idFactura
	IF @b=5
		SELECT * FROM Factura
		WHERE Fecha LIKE '%' +@Fecha + '%'
END
go

----------------------------------------------------------------
/****** Object:  StoredProcedure [dbo].[Pedido]    Script Date: 15/06/2020 4:12:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Pedido]
	-- Add the parameters for the stored procedure here
	@b int, @idPedido int, @DireccionEnvio varchar(80), @CantidadSolicitada Varchar(20), @FechaSolicitud varchar(50), @FechaEntrega varchar(50),
	@idUsuario int, @idCliente int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into Pedidos values (@DireccionEnvio, @CantidadSolicitada, @FechaSolicitud, @FechaEntrega, @idUsuario, @idCliente)
	IF @b=2
		delete from Pedidos where idPedido=@idPedido;
	IF @b=3
		select * from Pedidos
	IF @b=4
		UPDATE Pedidos SET DireccionEnvio=@DireccionEnvio, CatidadSolicitada=@CantidadSolicitada, FechaSolicitud=@FechaSolicitud,
		FechaEntrega=@FechaEntrega, idUsuario=@idUsuario, idCliente=@idCliente
		WHERE idPedido=@idPedido
	IF @b=5
		SELECT * FROM Pedidos
		WHERE idPedido LIKE '%' +@idPedido + '%'
END
go
-----------------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[Productos]    Script Date: 15/06/2020 4:13:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Productos]
	-- Add the parameters for the stored procedure here
	@b int, @idProducto int, @Nombre varchar(100), @Colores Varchar(80), @Descripcion varchar(150), @Tamaño varchar(10),
	@Precio int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into Producto values (@Nombre, @Colores, @Descripcion, @Tamaño, @Precio)
	IF @b=2
		delete from Producto where idProducto=@idProducto;
	IF @b=3
		select * from Producto
	IF @b=4
	update Producto set Nombre=@Nombre, Colores=@Colores, Descripcion=@Descripcion, Tamaño=@Tamaño, Precio=@Precio
	where idProducto=@idProducto

	IF @b=5 
	Select * from Producto
	Where Nombre LIKE '%'+ @Nombre + '%'

END
go

------------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[RedesSociales]    Script Date: 15/06/2020 4:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RedesSociales]
-- Add the parameters for the stored procedure here
	@b int, @idRedSocial int, @NombreR varchar(80), @idCliente int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into RedSocial values (@NombreR, @idCliente)
	IF @b=2
		delete from RedSocial where idRedSocial=@idRedSocial;
	IF @b=3
		select * from RedSocial
	IF @b=4
	update RedSocial set NombreR=@NombreR, idCliente=@idCliente
	where idRedSocial=@idRedSocial
	IF @b=5 
	Select * from RedSocial
	Where NombreR LIKE '%'+ @NombreR + '%'
END
GO
--------------------------------------------------------

/****** Object:  StoredProcedure [dbo].[Usuarios]    Script Date: 15/06/2020 4:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuarios]
	-- Add the parameters for the stored procedure here
	@b int, @idUsuario int, @Cedula varchar(15), @Nombres Varchar(50), @Apellidos varchar(50), @Direccion varchar(80), @Telefono varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @b=1
		Insert into Usuario values (@Cedula, @Nombres, @Apellidos, @Direccion, @Telefono)
	IF @b=2
		delete from Usuario where idUsuario = @idUsuario;
	IF @b=3
		select * from Usuario
	IF @b=4
	update Usuario set Cedula=@Cedula, Nombres=@Nombres, Apellidos=@Apellidos, Direccion=@Direccion, Telefono=@Telefono
	where idUsuario=@idUsuario
	IF @b=5 
	Select * from Usuario
	Where Nombres LIKE '%'+ @Nombres + '%'
END
go

------------------------------------------------------

USE [BD_CREACIONESVIVAS]
GO
/****** Object:  StoredProcedure [dbo].[RespaldoBD_CreacionesV]    Script Date: 15/06/2020 4:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RespaldoBD_CreacionesV] 
	AS
BEGIN
	SET NOCOUNT ON;

	BACKUP DATABASE [BD_CREACIONESVIVAS]
	TO DISK = N'C:\Users\harol\Desktop\2020\RespaldoCreacionesVivas'
	WITH CHECKSUM;
END





