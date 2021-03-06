USE [master]
GO
/****** Object:  Database [UniversityIIDB]    Script Date: 07/13/2013 18:39:58 ******/
CREATE DATABASE [UniversityIIDB] 
GO
ALTER DATABASE [UniversityIIDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityIIDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityIIDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [UniversityIIDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [UniversityIIDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [UniversityIIDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [UniversityIIDB] SET ARITHABORT OFF
GO
ALTER DATABASE [UniversityIIDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [UniversityIIDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [UniversityIIDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [UniversityIIDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [UniversityIIDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [UniversityIIDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [UniversityIIDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [UniversityIIDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [UniversityIIDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [UniversityIIDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [UniversityIIDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [UniversityIIDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [UniversityIIDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [UniversityIIDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [UniversityIIDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [UniversityIIDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [UniversityIIDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [UniversityIIDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [UniversityIIDB] SET  READ_WRITE
GO
ALTER DATABASE [UniversityIIDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [UniversityIIDB] SET  MULTI_USER
GO
ALTER DATABASE [UniversityIIDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [UniversityIIDB] SET DB_CHAINING OFF
GO
USE [UniversityIIDB]
GO
/****** Object:  User [beleva]    Script Date: 07/13/2013 18:39:58 ******/
CREATE USER [beleva] FOR LOGIN [beleva] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Titles]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[title_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[title_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Titles] ON
INSERT [dbo].[Titles] ([title_id], [name]) VALUES (2, N'Phd')
INSERT [dbo].[Titles] ([title_id], [name]) VALUES (3, N'Junior Assistant')
INSERT [dbo].[Titles] ([title_id], [name]) VALUES (4, N'Senior Assistant')
SET IDENTITY_INSERT [dbo].[Titles] OFF
/****** Object:  Table [dbo].[Faculties]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[faculty_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[faculty_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Faculties] ON
INSERT [dbo].[Faculties] ([faculty_id], [name]) VALUES (1, N'Science')
INSERT [dbo].[Faculties] ([faculty_id], [name]) VALUES (2, N'Mathematics and Informatics')
INSERT [dbo].[Faculties] ([faculty_id], [name]) VALUES (3, N'History and Philosophy')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
/****** Object:  Table [dbo].[Departments]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[faculty_id] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (1, N'Nanotechnology', 1)
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (2, N'Nuclear Physics', 1)
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (3, N'History', 3)
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (4, N'Phylosophy of traditional and modern societies', 3)
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (5, N'Applied Mathematics', 2)
INSERT [dbo].[Departments] ([department_id], [name], [faculty_id]) VALUES (6, N'Informatics', 2)
SET IDENTITY_INSERT [dbo].[Departments] OFF
/****** Object:  Table [dbo].[Students]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[student_id] [nvarchar](10) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[faculty_id] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Students] ([student_id], [first_name], [last_name], [faculty_id]) VALUES (N'06023128', N'Hristo', N'Prodanov', 3)
INSERT [dbo].[Students] ([student_id], [first_name], [last_name], [faculty_id]) VALUES (N'12340590', N'Ivan', N'Todorov', 1)
INSERT [dbo].[Students] ([student_id], [first_name], [last_name], [faculty_id]) VALUES (N'12357689', N'Ralica', N'Osmanova', 1)
INSERT [dbo].[Students] ([student_id], [first_name], [last_name], [faculty_id]) VALUES (N'SDR34612', N'Oktai', N'Choban', 2)
/****** Object:  Table [dbo].[Professors]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[professor_id] [int] IDENTITY(1,1) NOT NULL,
	[title_id] [int] NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[department_id] [int] NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[professor_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Professors] ON
INSERT [dbo].[Professors] ([professor_id], [title_id], [first_name], [last_name], [department_id]) VALUES (1, 2, N'Antoan', N'Ane', 1)
INSERT [dbo].[Professors] ([professor_id], [title_id], [first_name], [last_name], [department_id]) VALUES (2, 2, N'Maria', N'Ivanovna', 1)
INSERT [dbo].[Professors] ([professor_id], [title_id], [first_name], [last_name], [department_id]) VALUES (3, 3, N'Evgeni', N'Radoev', 3)
INSERT [dbo].[Professors] ([professor_id], [title_id], [first_name], [last_name], [department_id]) VALUES (4, 4, N'Samuel', N'Hollow', 4)
INSERT [dbo].[Professors] ([professor_id], [title_id], [first_name], [last_name], [department_id]) VALUES (5, 2, N'Nikolay', N'Kostov', 6)
SET IDENTITY_INSERT [dbo].[Professors] OFF
/****** Object:  Table [dbo].[Courses]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[department_id] [int] NOT NULL,
	[professor_id] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON
INSERT [dbo].[Courses] ([course_id], [name], [department_id], [professor_id]) VALUES (2, N'History of Philosophy', 4, 4)
INSERT [dbo].[Courses] ([course_id], [name], [department_id], [professor_id]) VALUES (3, N'Nanotechnology', 1, 1)
INSERT [dbo].[Courses] ([course_id], [name], [department_id], [professor_id]) VALUES (4, N'C#', 6, 5)
SET IDENTITY_INSERT [dbo].[Courses] OFF
/****** Object:  Table [dbo].[StudentsAndCourses]    Script Date: 07/13/2013 18:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsAndCourses](
	[student_id] [nvarchar](10) NOT NULL,
	[course_id] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[StudentsAndCourses] ([student_id], [course_id]) VALUES (N'06023128', 2)
INSERT [dbo].[StudentsAndCourses] ([student_id], [course_id]) VALUES (N'06023128', 3)
INSERT [dbo].[StudentsAndCourses] ([student_id], [course_id]) VALUES (N'06023128', 4)
INSERT [dbo].[StudentsAndCourses] ([student_id], [course_id]) VALUES (N'SDR34612', 4)
/****** Object:  ForeignKey [FK_Departments_Faculties]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([faculty_id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
/****** Object:  ForeignKey [FK_Students_Faculties1]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties1] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([faculty_id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties1]
GO
/****** Object:  ForeignKey [FK_Professors_Departments]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([department_id])
REFERENCES [dbo].[Departments] ([department_id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
/****** Object:  ForeignKey [FK_Professors_Titles]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Titles] FOREIGN KEY([title_id])
REFERENCES [dbo].[Titles] ([title_id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Titles]
GO
/****** Object:  ForeignKey [FK_Courses_Professors]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([professor_id])
REFERENCES [dbo].[Professors] ([professor_id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
/****** Object:  ForeignKey [FK_StudentsAndCourses_Courses]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[StudentsAndCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsAndCourses_Courses] FOREIGN KEY([course_id])
REFERENCES [dbo].[Courses] ([course_id])
GO
ALTER TABLE [dbo].[StudentsAndCourses] CHECK CONSTRAINT [FK_StudentsAndCourses_Courses]
GO
/****** Object:  ForeignKey [FK_StudentsAndCourses_Students]    Script Date: 07/13/2013 18:39:58 ******/
ALTER TABLE [dbo].[StudentsAndCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsAndCourses_Students] FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([student_id])
GO
ALTER TABLE [dbo].[StudentsAndCourses] CHECK CONSTRAINT [FK_StudentsAndCourses_Students]
GO
