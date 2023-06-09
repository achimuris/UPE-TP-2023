USE [UniversidadEjemplo]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_carreras]    Script Date: 03/04/2023 21:39:01 ******/
DROP PROCEDURE [dbo].[sp_listar_carreras]
GO
ALTER TABLE [dbo].[Materia] DROP CONSTRAINT [FK_Materia_Carrera]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 03/04/2023 21:39:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Materia]') AND type in (N'U'))
DROP TABLE [dbo].[Materia]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 03/04/2023 21:39:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Carrera]') AND type in (N'U'))
DROP TABLE [dbo].[Carrera]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 03/04/2023 21:39:01 ******/
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
/****** Object:  Table [dbo].[Materia]    Script Date: 03/04/2023 21:39:01 ******/
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
SET IDENTITY_INSERT [dbo].[Materia] OFF
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Carrera]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_carreras]    Script Date: 03/04/2023 21:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_carreras]
as
select idcarrera as 'Identificador', nombre as 'Descripción' from Carrera
GO
