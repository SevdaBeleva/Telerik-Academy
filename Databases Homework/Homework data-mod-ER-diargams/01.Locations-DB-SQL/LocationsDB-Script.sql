USE [master]
GO
/****** Object:  Database [LocationsDB]    Script Date: 07/13/2013 12:21:25 ******/
CREATE DATABASE [LocationsDB];
GO
ALTER DATABASE [LocationsDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LocationsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LocationsDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [LocationsDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [LocationsDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [LocationsDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [LocationsDB] SET ARITHABORT OFF
GO
ALTER DATABASE [LocationsDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [LocationsDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [LocationsDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [LocationsDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [LocationsDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [LocationsDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [LocationsDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [LocationsDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [LocationsDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [LocationsDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [LocationsDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [LocationsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [LocationsDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [LocationsDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [LocationsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [LocationsDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [LocationsDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [LocationsDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [LocationsDB] SET  READ_WRITE
GO
ALTER DATABASE [LocationsDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [LocationsDB] SET  MULTI_USER
GO
ALTER DATABASE [LocationsDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [LocationsDB] SET DB_CHAINING OFF
GO
USE [LocationsDB]
GO
/****** Object:  User [beleva]    Script Date: 07/13/2013 12:21:25 ******/
CREATE USER [beleva] FOR LOGIN [beleva] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Continents]    Script Date: 07/13/2013 12:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Continents] ON
INSERT [dbo].[Continents] ([id], [name]) VALUES (1, N'Европа')
INSERT [dbo].[Continents] ([id], [name]) VALUES (2, N'Азия')
INSERT [dbo].[Continents] ([id], [name]) VALUES (3, N'Северна Америка')
INSERT [dbo].[Continents] ([id], [name]) VALUES (4, N'Южна Америка')
INSERT [dbo].[Continents] ([id], [name]) VALUES (5, N'Австралия')
SET IDENTITY_INSERT [dbo].[Continents] OFF
/****** Object:  Table [dbo].[Countries]    Script Date: 07/13/2013 12:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON
INSERT [dbo].[Countries] ([id], [name], [country_id]) VALUES (2, N'България', 1)
INSERT [dbo].[Countries] ([id], [name], [country_id]) VALUES (3, N'Германия', 2)
INSERT [dbo].[Countries] ([id], [name], [country_id]) VALUES (4, N'Италия', 3)
SET IDENTITY_INSERT [dbo].[Countries] OFF
/****** Object:  Table [dbo].[Towns]    Script Date: 07/13/2013 12:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Towns_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Towns] ON
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (4, N'София', 1)
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (5, N'Кьолн', 2)
INSERT [dbo].[Towns] ([id], [name], [country_id]) VALUES (6, N'Венеция', 3)
SET IDENTITY_INSERT [dbo].[Towns] OFF
/****** Object:  Table [dbo].[Addresses]    Script Date: 07/13/2013 12:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address_text] [nvarchar](100) NOT NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON
INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (6, N'ул. Васил Янев 12', 4)
INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (7, N'WeisStrasse 123', 5)
INSERT [dbo].[Addresses] ([id], [address_text], [town_id]) VALUES (8, N'Santa maria 54', 6)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
/****** Object:  Table [dbo].[People]    Script Date: 07/13/2013 12:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[People] ON
INSERT [dbo].[People] ([id], [first_name], [last_name], [address_id]) VALUES (7, N'Александър', N'Йовчев', 6)
INSERT [dbo].[People] ([id], [first_name], [last_name], [address_id]) VALUES (8, N'Wilhem', N'Muller', 7)
INSERT [dbo].[People] ([id], [first_name], [last_name], [address_id]) VALUES (9, N'Antonella ', N'Capaso', 8)
SET IDENTITY_INSERT [dbo].[People] OFF
/****** Object:  ForeignKey [FK_Countries_Continents]    Script Date: 07/13/2013 12:21:25 ******/
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([id])
REFERENCES [dbo].[Continents] ([id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
/****** Object:  ForeignKey [FK_Towns_Countries]    Script Date: 07/13/2013 12:21:25 ******/
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([country_id])
REFERENCES [dbo].[Countries] ([country_id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
/****** Object:  ForeignKey [FK_Addresses_Towns]    Script Date: 07/13/2013 12:21:25 ******/
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([town_id])
REFERENCES [dbo].[Towns] ([id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
/****** Object:  ForeignKey [FK_People_Addresses]    Script Date: 07/13/2013 12:21:25 ******/
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([address_id])
REFERENCES [dbo].[Addresses] ([id])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
