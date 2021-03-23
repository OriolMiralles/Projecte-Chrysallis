USE [Chrysallis]
GO
/****** Object:  Table [dbo].[assistir]    Script Date: 23/03/2021 13:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assistir](
	[id_soci] [int] NOT NULL,
	[id_esdeveniment] [int] NOT NULL,
	[quantitat_persones] [int] NOT NULL,
	[textValoracio] [varchar](250) NULL,
	[cantidadTotal] [decimal](18, 0) NULL,
	[haPagado] [bit] NULL,
	[valoracio] [int] NOT NULL,
 CONSTRAINT [PK_assistir] PRIMARY KEY CLUSTERED 
(
	[id_soci] ASC,
	[id_esdeveniment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comunitats]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[comunitats_socis]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[documents]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[esdeveniments]    Script Date: 23/03/2021 13:35:08 ******/
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
	[imatge] [varchar](30) NULL,
	[quantitat_max] [int] NULL,
	[quantitat_mínima] [int] NULL,
	[preu] [decimal](18, 0) NULL,
	[pagament] [bit] NULL,
	[data_max] [date] NULL,
	[cont_assitents] [int] NULL,
	[id_localitat] [int] NULL,
	[id_tipus] [int] NULL,
	[meet] [varchar](50) NULL,
 CONSTRAINT [PK_esdeveniments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localitats]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[menors]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[menors_socis]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[preferits]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[provincies]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[rols]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[socis]    Script Date: 23/03/2021 13:35:08 ******/
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
	[adresa] [varchar](50) NULL,
	[codi_postal] [varchar](8) NULL,
	[id_localitat] [int] NOT NULL,
 CONSTRAINT [PK_socis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipus_events]    Script Date: 23/03/2021 13:35:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipus_events](
	[idTipus] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](25) NOT NULL,
	[imatge] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipus_events] PRIMARY KEY CLUSTERED 
(
	[idTipus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuaris]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[usuaris_comunitats]    Script Date: 23/03/2021 13:35:08 ******/
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
/****** Object:  Table [dbo].[valoracions]    Script Date: 23/03/2021 13:35:08 ******/
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
SET IDENTITY_INSERT [dbo].[comunitats] ON 

INSERT [dbo].[comunitats] ([id], [nom]) VALUES (1, N'Andalucía')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (2, N'Aragón')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (3, N'Asturias')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (5, N'Canarias')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (6, N'Cantabria')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (8, N'Castilla y León')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (7, N'Castilla-La Mancha')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (9, N'Cataluña')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (18, N'Ceuta')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (10, N'Comunidad Valenciana')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (11, N'Extremadura')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (12, N'Galícia')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (4, N'Islas Baleares')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (13, N'La Rioja')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (14, N'Madrid')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (19, N'Melilla')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (16, N'Navarra')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (17, N'PaísVasco')
INSERT [dbo].[comunitats] ([id], [nom]) VALUES (15, N'Región de Múrcia')
SET IDENTITY_INSERT [dbo].[comunitats] OFF
GO
SET IDENTITY_INSERT [dbo].[provincies] ON 

INSERT [dbo].[provincies] ([id], [nom], [id_comunitat]) VALUES (2, N'Barcelona', 7)
INSERT [dbo].[provincies] ([id], [nom], [id_comunitat]) VALUES (3, N'Girona', 7)
INSERT [dbo].[provincies] ([id], [nom], [id_comunitat]) VALUES (4, N'Lleida', 7)
INSERT [dbo].[provincies] ([id], [nom], [id_comunitat]) VALUES (5, N'Tarragona', 7)
SET IDENTITY_INSERT [dbo].[provincies] OFF
GO
SET IDENTITY_INSERT [dbo].[rols] ON 

INSERT [dbo].[rols] ([id], [nom]) VALUES (1, N'SuperAdministrador')
INSERT [dbo].[rols] ([id], [nom]) VALUES (2, N'Administrador')
SET IDENTITY_INSERT [dbo].[rols] OFF
GO
SET IDENTITY_INSERT [dbo].[usuaris] ON 

INSERT [dbo].[usuaris] ([id], [contrasenya], [id_rol], [username], [email]) VALUES (1, N'$2a$11$qNB71PdTsW1UzFPsHJE4m.RSmkYJn5fiU8sPw3OT8GxcuWktSO3Je', 2, N'eafaefeafaefaefae', N'faefaefaefaefeafaefefea')
INSERT [dbo].[usuaris] ([id], [contrasenya], [id_rol], [username], [email]) VALUES (2, N'$2a$11$FO0JfFDESP8szFuj9CpkauwxdpHCskklmfwwZXKAdTp7whW0dDgR6', 1, N'sa', N'sa@sa.com')
INSERT [dbo].[usuaris] ([id], [contrasenya], [id_rol], [username], [email]) VALUES (3, N'$2a$11$CUo.UMBZ0ov3sViUUiJ0gOz0h4duAnreJt.MYllQFvMBs5gfXkh6u', 2, N'olga', N'olga@mfakgeql.com')
SET IDENTITY_INSERT [dbo].[usuaris] OFF
GO
INSERT [dbo].[usuaris_comunitats] ([id_usuari], [id_comunitat]) VALUES (3, 9)
INSERT [dbo].[usuaris_comunitats] ([id_usuari], [id_comunitat]) VALUES (3, 10)
GO
ALTER TABLE [dbo].[assistir] ADD  CONSTRAINT [DF_assistir_haPagado]  DEFAULT ((0)) FOR [haPagado]
GO
ALTER TABLE [dbo].[esdeveniments] ADD  CONSTRAINT [DF_esdeveniments_pagament]  DEFAULT ((0)) FOR [pagament]
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
ALTER TABLE [dbo].[esdeveniments]  WITH CHECK ADD  CONSTRAINT [FK_esdeveniments_localitats] FOREIGN KEY([id_localitat])
REFERENCES [dbo].[localitats] ([id])
GO
ALTER TABLE [dbo].[esdeveniments] CHECK CONSTRAINT [FK_esdeveniments_localitats]
GO
ALTER TABLE [dbo].[esdeveniments]  WITH CHECK ADD  CONSTRAINT [FK_esdeveniments_tipus_events] FOREIGN KEY([id_tipus])
REFERENCES [dbo].[tipus_events] ([idTipus])
GO
ALTER TABLE [dbo].[esdeveniments] CHECK CONSTRAINT [FK_esdeveniments_tipus_events]
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
