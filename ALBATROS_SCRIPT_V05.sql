USE [master]
GO
/****** Object:  Database [ALBATROS]    Script Date: 7/3/2022 6:02:38 PM ******/
CREATE DATABASE [ALBATROS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ALBATROS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ALBATROS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ALBATROS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ALBATROS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ALBATROS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ALBATROS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ALBATROS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ALBATROS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ALBATROS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ALBATROS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ALBATROS] SET ARITHABORT OFF 
GO
ALTER DATABASE [ALBATROS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ALBATROS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ALBATROS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ALBATROS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ALBATROS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ALBATROS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ALBATROS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ALBATROS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ALBATROS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ALBATROS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ALBATROS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ALBATROS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ALBATROS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ALBATROS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ALBATROS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ALBATROS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ALBATROS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ALBATROS] SET RECOVERY FULL 
GO
ALTER DATABASE [ALBATROS] SET  MULTI_USER 
GO
ALTER DATABASE [ALBATROS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ALBATROS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ALBATROS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ALBATROS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ALBATROS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ALBATROS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ALBATROS', N'ON'
GO
ALTER DATABASE [ALBATROS] SET QUERY_STORE = OFF
GO
USE [ALBATROS]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[ID_CLIENTE] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](150) NULL,
	[RTN] [varchar](15) NULL,
	[DIRECCION] [varchar](300) NULL,
	[FECHA_CREACION]  AS (getdate()),
	[FECHA_MODIFICACION] [date] NULL,
	[STATUS] [char](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_HEADER]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_HEADER](
	[ID_FACTURA] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ID_CLIENTE] [numeric](15, 0) NULL,
	[TOTAL_IMPUESTO] [numeric](14, 2) NULL,
	[TOTAL_FACTURA] [numeric](14, 2) NULL,
	[FECHA_CREACION]  AS (getdate()),
	[FECHA_ANULACION] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RP_Factura_resumen]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[RP_Factura_resumen]
AS
select b.NOMBRE CLIENTE, b.RTN AS RTN
				, A.ID_FACTURA as NUMERO_FACTURA
			 , A.TOTAL_FACTURA AS TOTAL
			, A.TOTAL_IMPUESTO AS IMPUESTO , A.FECHA_CREACION as FECHA_EMISION   
from [ALBATROS].DBO.[FACTURA_HEADER] A 
inner join ALBATROS.DBO.CLIENTES B on A.ID_CLIENTE=B.ID_CLIENTE and b.status='A'

GO
/****** Object:  Table [dbo].[FACTURA_DETAIL]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_DETAIL](
	[ID_FACTURA] [numeric](18, 0) NULL,
	[CODIGO_PRODUCTO] [numeric](18, 0) NULL,
	[CANTIDAD] [numeric](18, 0) NULL,
	[PRECIO] [numeric](14, 2) NULL,
	[TOTAL_PRODUCTO] [numeric](14, 2) NULL,
	[FECHA_CREACION]  AS (getdate())
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IMPUESTO]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPUESTO](
	[ID_IMPUESTO] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[FECHA_CREACION]  AS (getdate()),
	[impuesto] [numeric](14, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[CODIGO_PRODUCTO] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](30) NULL,
	[PRECIO] [numeric](14, 2) NULL,
	[ID_IMPUESTO] [int] NULL,
	[FECHA_CREACION]  AS (getdate()),
	[FECHA_MODIFICACION] [date] NULL,
	[status] [char](1) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_CLIENTE_DELETE]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ALBATROS_CLIENTE_DELETE]
	@ID_CLIENTE int  ,@PARAM_ACTION INT--,@MENSAJE-- NVARCHAR(50) OUTPUT
AS

/**********************************************
Descripcion: CRUD DE PRODUCTOS
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/

/****************************************/


/***************************************/
IF @PARAM_ACTION=2 --delete 
BEGIN 
   	    UPDATE  ALBATROS.[dbo].[CLIENTES]
		SET STATUS='I',FECHA_MODIFICACION=GETDATE()
		WHERE ID_CLIENTE=@ID_CLIENTE AND STATUS='A'
		--SELECT @MENSAJE='EL CLIENTE HA SIDO ELIMINADO CON EXITO :)'

END 











GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_CLIENTE_UPDATE]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_CLIENTE_UPDATE]
	@ID_CLIENTE int ,@DIRECCION VARCHAR(300) ,@PARAM_ACTION INT--,@MENSAJE NVARCHAR(50) OUTPUT
AS

/**********************************************
Descripcion: CRUD DE PRODUCTOS
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/
/****************************************/

DECLARE @MENSAJE_1 NVARCHAR(30) =''

/***************************************/

IF @PARAM_ACTION=3 --INSERCION

BEGIN 
		update ALBATROS.[dbo].[CLIENTES]
		set [DIRECCION]=@DIRECCION,FECHA_MODIFICACION=getdate()
		where [ID_CLIENTE]=@ID_CLIENTE and STATUS='A'
	--	SELECT @MENSAJE='El Cliente ha sido actualizado con Exito :)'
END 














GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_CLIENTES]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_CLIENTES]
	@NOMBRE VARCHAR(150),@RTN VARCHAR(15),@DIRECCION VARCHAR(300),@PARAM_ACTION INT--,@MENSAJE NVARCHAR(50) OUTPUT
AS

/**********************************************
Descripcion: CRUD DE clientes
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/
/****************************************/

DECLARE @MENSAJE_1 NVARCHAR(30) =''

/***************************************/

IF @PARAM_ACTION=1 --INSERCION
BEGIN 

INSERT INTO ALBATROS.[dbo].[CLIENTES]
           ([NOMBRE]
           ,[RTN]
           ,[DIRECCION]
           ,[FECHA_MODIFICACION]
           ,[STATUS])
		SELECT @NOMBRE,@RTN,@DIRECCION,null,'A'
		--SELECT @MENSAJE='El Cliente ha sido ingresado con Exito :)'
END 
GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_FACTURA_DETAIL]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_FACTURA_DETAIL]
	  @CODIGO_PRODUCTO INT
	 ,@CANTIDAD numeric(14,2)
	 ,@PRECIO numeric(14,2)
	 ,@TOTAL_PRODUCTO NUMERIC(14,2)
	 --,@MENSAJE NVARCHAR(50) OUTPUT
AS
/**********************************************
Descripcion: CRUD DE DETAIL
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/
/****************************************/

DECLARE @IDFACTURA INT = (SELECT MAX(ID_FACTURA)FROM Albatros.[dbo].[FACTURA_HEADER])
/***************************************/
	INSERT INTO [ALBATROS].[dbo].[FACTURA_DETAIL]
           ([ID_FACTURA]
           ,[CODIGO_PRODUCTO]
           ,[CANTIDAD]
           ,[PRECIO]
           ,[TOTAL_PRODUCTO])
     SELECT @IDFACTURA,@CODIGO_PRODUCTO,@CANTIDAD,@PRECIO,@TOTAL_PRODUCTO













GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_FACTURA_HEADER_UPDATE]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_FACTURA_HEADER_UPDATE]
	  @ID_CLIENTE int,@total_impuesto numeric(14,6),@total_factura numeric(14,6)--,@MENSAJE NVARCHAR(50) OUTPUT
AS
/**********************************************
Descripcion: CRUD DE HEADER
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/
/****************************************/

DECLARE @IDFACTURA INT = (SELECT MAX(ID_FACTURA)FROM Albatros.[dbo].[FACTURA_HEADER])

/***************************************/
		update ALBATROS.[dbo].[FACTURA_HEADER]
		set ID_CLIENTE=@ID_CLIENTE,TOTAL_IMPUESTO=@total_impuesto,TOTAL_FACTURA=@total_factura
		where ID_FACTURA=@IDFACTURA
	--	SELECT @MENSAJE='El Cliente ha sido actualizado con Exito :)'















GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_FACTURACION_HEADER]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ALBATROS_FACTURACION_HEADER]
AS
/**********************************************
Descripcion: CRUD DE FACTURACION
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento
**************************************************/

/****************************************/


/***************************************/
INSERT INTO ALBATROS.[dbo].[FACTURA_HEADER]
           ([ID_CLIENTE]
           ,[TOTAL_IMPUESTO]
           ,[TOTAL_FACTURA]
           ,[FECHA_ANULACION])
     
SELECT 	NULL,NULL,NULL,NULL




GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_PRODUCTOS]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_PRODUCTOS]
	@DESCRIPCION VARCHAR(30),@PRECIO NUMERIC(14,2),@ID_IMPUESTO NUMERIC,@PARAM_ACTION INT--,@MENSAJE NVARCHAR(30) OUTPUT
AS


/**********************************************
Descripcion: CRUD DE PRODUCTOS
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/

/****************************************/

DECLARE @MENSAJE_1 NVARCHAR(30) =''

/***************************************/

IF @PARAM_ACTION=1 --INSERCION
BEGIN 

		INSERT INTO ALBATROS.[dbo].[PRODUCTO]
							([DESCRIPCION]
							,[PRECIO]
							,[ID_IMPUESTO]
							,[FECHA_MODIFICACION]
							,status
							)
		SELECT @DESCRIPCION,@PRECIO,@ID_IMPUESTO,null,'A'
		--SELECT @MENSAJE='El Producto ha sido ingresado con Exito :)'

END 









GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_PRODUCTOS_DELETE]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_PRODUCTOS_DELETE]
	@CODIGO_PRODUCTO int  ,@PARAM_ACTION INT--,@MENSAJE NVARCHAR(30) OUTPUT
AS

/**********************************************
Descripcion: CRUD DE PRODUCTOS
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/

/****************************************/

DECLARE @MENSAJE_1 NVARCHAR(30) =''

/***************************************/
IF @PARAM_ACTION=2 --delete 
BEGIN 
   	    UPDATE  ALBATROS.[DBO].[PRODUCTO]
		SET STATUS='I',FECHA_MODIFICACION=GETDATE()
		WHERE CODIGO_PRODUCTO=@CODIGO_PRODUCTO and status='A'
		--SELECT @MENSAJE='EL PRODUCTO HA SIDO ELIMINADO CON EXITO :)'

END 











GO
/****** Object:  StoredProcedure [dbo].[ALBATROS_PRODUCTOS_UPDATE]    Script Date: 7/3/2022 6:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ALBATROS_PRODUCTOS_UPDATE]
	@CODIGO_PRODUCTO int ,@DESCRIPCION VARCHAR(30),@PRECIO NUMERIC(14,2),@ID_IMPUESTO NUMERIC,@PARAM_ACTION INT--,@MENSAJE NVARCHAR(50) OUTPUT
AS

/**********************************************
Descripcion: CRUD DE PRODUCTOS
===============================================
FECHA        VERSION		OBSERVACIONES
20220703	 rohero			Creacion del procedimiento

**************************************************/
/****************************************/

DECLARE @MENSAJE_1 NVARCHAR(30) =''

/***************************************/

IF @PARAM_ACTION=3 --INSERCION

BEGIN 
	
		update ALBATROS.[dbo].[PRODUCTO]
		set DESCRIPCION=@DESCRIPCION,precio=@PRECIO,ID_IMPUESTO=@ID_IMPUESTO,FECHA_MODIFICACION=getdate()
		where CODIGO_PRODUCTO=@CODIGO_PRODUCTO AND STATUS='A'
	
	--	SELECT @MENSAJE='El Producto ha sido actualizado con Exito :)'

END 



--delete











GO
USE [master]
GO
ALTER DATABASE [ALBATROS] SET  READ_WRITE 
GO
