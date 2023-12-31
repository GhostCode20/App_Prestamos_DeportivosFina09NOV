USE [master]
GO
/****** Object:  Database [dbs_prestamos_deportivos]    Script Date: 9/11/2023 5:16:50 p. m. ******/
CREATE DATABASE [dbs_prestamos_deportivos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbs_prestamos_deportivos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbs_prestamos_deportivos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbs_prestamos_deportivos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  MULTI_USER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbs_prestamos_deportivos]
GO
/****** Object:  Table [dbo].[tbl_det_prestamos]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_det_prestamos](
	[PkItem] [bigint] IDENTITY(1,1) NOT NULL,
	[FkNumero_tbl_prestamos] [bigint] NOT NULL,
	[Fk_Codigo_tbl_implementos] [varchar](10) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha_devolucion] [date] NULL,
	[Hora_devolucion] [time](7) NULL,
	[Observaciones] [varchar](5000) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estado]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estado](
	[PkCodigo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_implemnentos]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_implemnentos](
	[PkCodigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](80) NOT NULL,
	[Especificaciones] [varchar](5000) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Valor] [float] NOT NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_personas]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_personas](
	[PkId] [varchar](10) NOT NULL,
	[P_nombre] [varchar](40) NOT NULL,
	[S_nombre] [varchar](40) NULL,
	[P_apellido] [varchar](40) NOT NULL,
	[S_apellido] [varchar](40) NULL,
	[Contacto] [varchar](10) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[FkId_tbl_sexo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_prestamos]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_prestamos](
	[PkNumero] [bigint] IDENTITY(1,1) NOT NULL,
	[FkId_tbl_personas] [varchar](10) NOT NULL,
	[FkUsuario_tbl_usuarios] [varchar](100) NOT NULL,
	[Fecha_registro] [date] NULL,
	[Hora_registro] [time](7) NULL,
	[Fecha_devolucion] [date] NULL,
	[Hora_devolucion] [time](7) NULL,
	[Observaciones] [varchar](5000) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkNumero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_rol]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rol](
	[PkCodigo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PkCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sexo]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sexo](
	[PkId] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[PkUsuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](10) NOT NULL,
	[FkId_tbl_personas] [varchar](10) NOT NULL,
	[Fecha] [date] NULL,
	[FkCodigo_tbl_estado] [char](1) NULL,
	[FkCodigo_tbl_rol] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PkUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_det_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_det_prestamos_tbl_implemnentos] FOREIGN KEY([Fk_Codigo_tbl_implementos])
REFERENCES [dbo].[tbl_implemnentos] ([PkCodigo])
GO
ALTER TABLE [dbo].[tbl_det_prestamos] CHECK CONSTRAINT [FK_tbl_det_prestamos_tbl_implemnentos]
GO
ALTER TABLE [dbo].[tbl_det_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_det_prestamos_tbl_prestamos] FOREIGN KEY([FkNumero_tbl_prestamos])
REFERENCES [dbo].[tbl_prestamos] ([PkNumero])
GO
ALTER TABLE [dbo].[tbl_det_prestamos] CHECK CONSTRAINT [FK_tbl_det_prestamos_tbl_prestamos]
GO
ALTER TABLE [dbo].[tbl_personas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_personas_tbl_sexo] FOREIGN KEY([FkId_tbl_sexo])
REFERENCES [dbo].[tbl_sexo] ([PkId])
GO
ALTER TABLE [dbo].[tbl_personas] CHECK CONSTRAINT [FK_tbl_personas_tbl_sexo]
GO
ALTER TABLE [dbo].[tbl_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_prestamos_tbl_personas] FOREIGN KEY([FkId_tbl_personas])
REFERENCES [dbo].[tbl_personas] ([PkId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_prestamos] CHECK CONSTRAINT [FK_tbl_prestamos_tbl_personas]
GO
ALTER TABLE [dbo].[tbl_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_prestamos_tbl_usuarios] FOREIGN KEY([FkUsuario_tbl_usuarios])
REFERENCES [dbo].[tbl_usuarios] ([PkUsuario])
GO
ALTER TABLE [dbo].[tbl_prestamos] CHECK CONSTRAINT [FK_tbl_prestamos_tbl_usuarios]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_estado] FOREIGN KEY([FkCodigo_tbl_estado])
REFERENCES [dbo].[tbl_estado] ([PkCodigo])
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_estado]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_personas] FOREIGN KEY([FkId_tbl_personas])
REFERENCES [dbo].[tbl_personas] ([PkId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_personas]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_rol] FOREIGN KEY([FkCodigo_tbl_rol])
REFERENCES [dbo].[tbl_rol] ([PkCodigo])
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_rol]
GO
/****** Object:  StoredProcedure [dbo].[dboSP_ConsultarImplemento]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Dulfran Montaño>
-- Create date: <Create Date,,26 de octubre del 2023>
-- Description:	<Description, Consultar implemento>
-- =============================================
create procedure [dbo].[dboSP_ConsultarImplemento]
@codigo varchar(10)
as begin
	select
	Nombre,
	Especificaciones,
	Cantidad,
	Valor
	from tbl_implementos
	where
	PKCodigo = @codigo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarImplemento]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Dulfran Montaño>
-- Create date: <Create Date, 26 de octubre del 2023>
-- Description:	<Description,,Agregar implementos>
-- =============================================
create procedure [dbo].[SP_AgregarImplemento]
@codigo varchar(10),@nombre varchar(80),@especificaciones varchar(5000),
@cantidad int, @valor float
as begin
	insert into tbl_implementos
	(PKCodigo,Nombre,Especificaciones,Cantidad,Valor,Fecha)
	values
	(@codigo,@nombre,@especificaciones,@cantidad,@valor,GETDATE())
end
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarPersonas]    Script Date: 9/11/2023 5:16:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Dulfran Montaño>
-- Create date: <Create Date, 12 de octubre del 2023>
-- Description:	<Description, Registrar personas>
-- =============================================
CREATE procedure [dbo].[SP_RegistrarPersonas]
@id varchar(10),@p_nombre varchar(40),@s_nombre varchar(40),@p_apellido varchar(40),
@s_apellido varchar(40),@contacto varchar(10),@correo varchar(80),
@direccion varchar(100),@sexo char
as begin
	insert into tbl_personas
	(PKId,P_nombre,S_nombre,P_apellido,S_apellido,Contacto,Correo,Direccion,FKId_tbl_sexo)
	values
	(@id,@p_nombre,@s_nombre,@p_apellido,@s_apellido,@contacto,@correo,@direccion,@sexo)
end
GO
USE [master]
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  READ_WRITE 
GO
