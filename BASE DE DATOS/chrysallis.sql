USE [Chrysallis]
GO
/****** Object:  Database [chrysallis]    Script Date: 11/03/2021 12:45:04 ******/
CREATE DATABASE [chrysallis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'chrysallis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\chrysallis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'chrysallis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\chrysallis_log.ldf' , SIZE = 3840KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [chrysallis] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chrysallis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chrysallis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chrysallis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chrysallis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chrysallis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chrysallis] SET ARITHABORT OFF 
GO
ALTER DATABASE [chrysallis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chrysallis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chrysallis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chrysallis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chrysallis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chrysallis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chrysallis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chrysallis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chrysallis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chrysallis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chrysallis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chrysallis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chrysallis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chrysallis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chrysallis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chrysallis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chrysallis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chrysallis] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [chrysallis] SET  MULTI_USER 
GO
ALTER DATABASE [chrysallis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chrysallis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chrysallis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chrysallis] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [chrysallis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [chrysallis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [chrysallis] SET QUERY_STORE = OFF
GO
USE [chrysallis]
GO
/****** Object:  Table [dbo].[assistir]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assistir](
	[id_soci] [int] NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
	[quantitat_persones] [int] NOT NULL,
	[valoracio] [int] NOT NULL,
 CONSTRAINT [PK_assistir] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_esdeveniment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comunitats]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comunitats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [PK_comunitats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comunitats_socis]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comunitats_socis](
	[id_soci] [int] NOT NULL,
	[id_comunitat] [int] NOT NULL,
 CONSTRAINT [PK_comunitats_socis] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_comunitat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[documents]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](100) NOT NULL,
	[ruta] [varchar](100) NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
 CONSTRAINT [PK_documents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[esdeveniments]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[esdeveniments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[titol] [varchar](50) NOT NULL,
	[descripcio] [varchar](140) NOT NULL,
	[data] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[adreca] [varchar](140) NOT NULL,
	[id_comunitat] [int] NOT NULL,
	[latitud] [nchar](10) NULL,
	[longitud] [nchar](10) NULL,
	[imatge] [nchar](10) NULL,
	[quantitat_max] [nchar](10) NULL,
	[quantitat_mínima] [nchar](10) NULL,
	[preu] [nchar](10) NULL,
	[pagament] [nchar](10) NULL,
	[data_max] [date] NULL,
	[cont_assitents] [nchar](10) NULL,
	[meet] [nchar](10) NULL,
 CONSTRAINT [PK_esdeveniments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localitats]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[localitats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[id_provincia] [int] NOT NULL,
 CONSTRAINT [PK_localitats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menors]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](100) NULL,
 CONSTRAINT [PK_menors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menors_socis]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menors_socis](
	[id_soci] [int] NOT NULL,
	[id_menor] [int] NOT NULL,
	[relacio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_menors_socis] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_menor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preferits]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preferits](
	[id_soci] [int] NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
 CONSTRAINT [PK_preferits] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_esdeveniment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provincies]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[id_comunitat] [int] NOT NULL,
 CONSTRAINT [PK_provincies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rols]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rols](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [PK_rols] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[socis]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[socis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[num] [int] NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[cognoms] [varchar](50) NULL,
	[actiu] [bit] NOT NULL,
	[telefon1] [varchar](15) NOT NULL,
	[telefon2] [varchar](15) NULL,
	[email] [varchar](100) NOT NULL,
	[dni] [varchar](11) NOT NULL,
	[contrasenya] [varchar](255) NULL,
	[data_naixement] [date] NULL,
	[data_baixa] [date] NULL,
	[data_alta] [date] NOT NULL,
	[permis_app] [bit] NOT NULL,
	[codi_postal] [varchar](8) NULL,
	[id_localitat] [int] NOT NULL,
 CONSTRAINT [PK_socis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuaris]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuaris](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contrasenya] [varchar](256) NOT NULL,
	[id_rol] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_usuaris] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuaris_comunitats]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuaris_comunitats](
	[id_usuari] [int] NOT NULL,
	[id_comunitat] [int] NOT NULL,
 CONSTRAINT [PK_usuaris_comunitats] PRIMARY KEY CLUSTERED 
(
	[id_usuari] ASC,
	[id_comunitat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[valoracions]    Script Date: 11/03/2021 12:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[valoracions](
	[id_soci] [int] NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
	[valoracio] [int] NOT NULL,
 CONSTRAINT [PK_valoracions] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_esdeveniment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_comunitats_nom]    Script Date: 11/03/2021 12:45:04 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_comunitats_nom] ON [dbo].[comunitats]
(
	[nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[assistir]  WITH CHECK ADD  CONSTRAINT [FK_assistir_esdeveniments] FOREIGN KEY([id_esdeveniment])
REFERENCES [dbo].[esdeveniments] ([id])
GO
ALTER TABLE [dbo].[assistir] CHECK CONSTRAINT [FK_assistir_esdeveniments]
GO
ALTER TABLE [dbo].[assistir]  WITH CHECK ADD  CONSTRAINT [FK_assistir_socis] FOREIGN KEY([id_soci])
REFERENCES [dbo].[socis] ([id])
GO
ALTER TABLE [dbo].[assistir] CHECK CONSTRAINT [FK_assistir_socis]
GO
ALTER TABLE [dbo].[comunitats_socis]  WITH CHECK ADD  CONSTRAINT [FK_comunitats_socis_comunitats] FOREIGN KEY([id_comunitat])
REFERENCES [dbo].[comunitats] ([id])
GO
ALTER TABLE [dbo].[comunitats_socis] CHECK CONSTRAINT [FK_comunitats_socis_comunitats]
GO
ALTER TABLE [dbo].[comunitats_socis]  WITH CHECK ADD  CONSTRAINT [FK_comunitats_socis_socis] FOREIGN KEY([id_soci])
REFERENCES [dbo].[socis] ([id])
GO
ALTER TABLE [dbo].[comunitats_socis] CHECK CONSTRAINT [FK_comunitats_socis_socis]
GO
ALTER TABLE [dbo].[documents]  WITH CHECK ADD  CONSTRAINT [FK_documents_esdeveniments] FOREIGN KEY([id_esdeveniment])
REFERENCES [dbo].[esdeveniments] ([id])
GO
ALTER TABLE [dbo].[documents] CHECK CONSTRAINT [FK_documents_esdeveniments]
GO
ALTER TABLE [dbo].[esdeveniments]  WITH CHECK ADD  CONSTRAINT [FK_esdeveniments_comunitats] FOREIGN KEY([id_comunitat])
REFERENCES [dbo].[comunitats] ([id])
GO
ALTER TABLE [dbo].[esdeveniments] CHECK CONSTRAINT [FK_esdeveniments_comunitats]
GO
ALTER TABLE [dbo].[localitats]  WITH CHECK ADD  CONSTRAINT [FK_localitats_provincies] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[provincies] ([id])
GO
ALTER TABLE [dbo].[localitats] CHECK CONSTRAINT [FK_localitats_provincies]
GO
ALTER TABLE [dbo].[menors_socis]  WITH CHECK ADD  CONSTRAINT [FK_menors_socis_menors] FOREIGN KEY([id_menor])
REFERENCES [dbo].[menors] ([id])
GO
ALTER TABLE [dbo].[menors_socis] CHECK CONSTRAINT [FK_menors_socis_menors]
GO
ALTER TABLE [dbo].[menors_socis]  WITH CHECK ADD  CONSTRAINT [FK_menors_socis_socis] FOREIGN KEY([id_soci])
REFERENCES [dbo].[socis] ([id])
GO
ALTER TABLE [dbo].[menors_socis] CHECK CONSTRAINT [FK_menors_socis_socis]
GO
ALTER TABLE [dbo].[preferits]  WITH CHECK ADD  CONSTRAINT [FK_preferits_esdeveniments] FOREIGN KEY([id_esdeveniment])
REFERENCES [dbo].[esdeveniments] ([id])
GO
ALTER TABLE [dbo].[preferits] CHECK CONSTRAINT [FK_preferits_esdeveniments]
GO
ALTER TABLE [dbo].[preferits]  WITH CHECK ADD  CONSTRAINT [FK_preferits_socis] FOREIGN KEY([id_soci])
REFERENCES [dbo].[socis] ([id])
GO
ALTER TABLE [dbo].[preferits] CHECK CONSTRAINT [FK_preferits_socis]
GO
ALTER TABLE [dbo].[provincies]  WITH CHECK ADD  CONSTRAINT [FK_provincies_comunitats] FOREIGN KEY([id_comunitat])
REFERENCES [dbo].[comunitats] ([id])
GO
ALTER TABLE [dbo].[provincies] CHECK CONSTRAINT [FK_provincies_comunitats]
GO
ALTER TABLE [dbo].[socis]  WITH CHECK ADD  CONSTRAINT [FK_socis_localitats] FOREIGN KEY([id_localitat])
REFERENCES [dbo].[localitats] ([id])
GO
ALTER TABLE [dbo].[socis] CHECK CONSTRAINT [FK_socis_localitats]
GO
ALTER TABLE [dbo].[usuaris]  WITH CHECK ADD  CONSTRAINT [FK_usuaris_rols] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rols] ([id])
GO
ALTER TABLE [dbo].[usuaris] CHECK CONSTRAINT [FK_usuaris_rols]
GO
ALTER TABLE [dbo].[usuaris_comunitats]  WITH CHECK ADD  CONSTRAINT [FK_usuaris_comunitats_comunitats] FOREIGN KEY([id_comunitat])
REFERENCES [dbo].[comunitats] ([id])
GO
ALTER TABLE [dbo].[usuaris_comunitats] CHECK CONSTRAINT [FK_usuaris_comunitats_comunitats]
GO
ALTER TABLE [dbo].[usuaris_comunitats]  WITH CHECK ADD  CONSTRAINT [FK_usuaris_comunitats_usuaris] FOREIGN KEY([id_usuari])
REFERENCES [dbo].[usuaris] ([id])
GO
ALTER TABLE [dbo].[usuaris_comunitats] CHECK CONSTRAINT [FK_usuaris_comunitats_usuaris]
GO
ALTER TABLE [dbo].[valoracions]  WITH CHECK ADD  CONSTRAINT [FK_valoracions_esdeveniments] FOREIGN KEY([id_esdeveniment])
REFERENCES [dbo].[esdeveniments] ([id])
GO
ALTER TABLE [dbo].[valoracions] CHECK CONSTRAINT [FK_valoracions_esdeveniments]
GO
ALTER TABLE [dbo].[valoracions]  WITH CHECK ADD  CONSTRAINT [FK_valoracions_socis] FOREIGN KEY([id_soci])
REFERENCES [dbo].[socis] ([id])
GO
ALTER TABLE [dbo].[valoracions] CHECK CONSTRAINT [FK_valoracions_socis]
GO
USE [master]
GO
ALTER DATABASE [chrysallis] SET  READ_WRITE 
GO
