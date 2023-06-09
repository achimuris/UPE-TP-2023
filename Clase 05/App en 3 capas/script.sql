USE [UniversidadEjemplo]
GO
/****** Object:  StoredProcedure [dbo].[sp_materiasxcarrera]    Script Date: 10/04/2023 21:38:30 ******/
DROP PROCEDURE [dbo].[sp_materiasxcarrera]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_carreras]    Script Date: 10/04/2023 21:38:30 ******/
DROP PROCEDURE [dbo].[sp_listar_carreras]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_materia]    Script Date: 10/04/2023 21:38:30 ******/
DROP PROCEDURE [dbo].[sp_insertar_materia]
GO
ALTER TABLE [dbo].[Materia] DROP CONSTRAINT [FK_Materia_Carrera]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 10/04/2023 21:38:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Materia]') AND type in (N'U'))
DROP TABLE [dbo].[Materia]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 10/04/2023 21:38:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Carrera]') AND type in (N'U'))
DROP TABLE [dbo].[Carrera]
GO
USE [master]
GO
/****** Object:  Database [UniversidadEjemplo]    Script Date: 10/04/2023 21:38:30 ******/
DROP DATABASE [UniversidadEjemplo]
GO
/****** Object:  Database [UniversidadEjemplo]    Script Date: 10/04/2023 21:38:30 ******/
CREATE DATABASE [UniversidadEjemplo] ON  PRIMARY 
( NAME = N'UniversidadEjemplo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UniversidadEjemplo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UniversidadEjemplo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UniversidadEjemplo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversidadEjemplo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversidadEjemplo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversidadEjemplo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversidadEjemplo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversidadEjemplo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversidadEjemplo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversidadEjemplo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UniversidadEjemplo] SET  MULTI_USER 
GO
ALTER DATABASE [UniversidadEjemplo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversidadEjemplo] SET DB_CHAINING OFF 
GO
USE [UniversidadEjemplo]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 10/04/2023 21:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[IdCarrera] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 10/04/2023 21:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[IdCarrera] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[IdMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Carrera] ON 

INSERT [dbo].[Carrera] ([IdCarrera], [Nombre]) VALUES (1, N'Tecnicatura en Desarrollo de Software')
INSERT [dbo].[Carrera] ([IdCarrera], [Nombre]) VALUES (2, N'Lic. en Turismo')
SET IDENTITY_INSERT [dbo].[Carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[Materia] ON 

INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (1, N'SW y Los Nuevos Escenarios', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (2, N'Técnicas de Programación', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (3, N'Programación en Tiempo Real', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (4, N'Sistemas Operativos', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (5, N'EDA 1', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (6, N'EDA 2', 1)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (7, N'Matemática I', 2)
INSERT [dbo].[Materia] ([IdMateria], [Descripcion], [IdCarrera]) VALUES (8, N'Inglés I', 2)
SET IDENTITY_INSERT [dbo].[Materia] OFF
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Carrera]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_materia]    Script Date: 10/04/2023 21:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertar_materia]
(
	@descripcion varchar(50),
	@idCarrera int
)
as
insert into Materia (Descripcion, IdCarrera)
values (@descripcion, @idCarrera)
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_carreras]    Script Date: 10/04/2023 21:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_carreras]
as
select idcarrera as 'Identificador', nombre as 'Descripción' from Carrera
GO
/****** Object:  StoredProcedure [dbo].[sp_materiasxcarrera]    Script Date: 10/04/2023 21:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_materiasxcarrera]
(
	@pIdCarrera int
)
as
select 
	mat.IdMateria,
	mat.Descripcion,
	car.IdCarrera,
	car.Nombre
from
	materia mat
inner join Carrera car on  car.IdCarrera = mat.IdCarrera
where
	car.IdCarrera = @pIdCarrera
GO
USE [master]
GO
ALTER DATABASE [UniversidadEjemplo] SET  READ_WRITE 
GO
