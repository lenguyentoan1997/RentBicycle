USE [master]
GO
/****** Object:  Database [RentBicycle]    Script Date: 11/15/2021 11:58:10 AM ******/
CREATE DATABASE [RentBicycle]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentBicycle', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentBicycle.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentBicycle_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentBicycle_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RentBicycle] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentBicycle].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentBicycle] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentBicycle] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentBicycle] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentBicycle] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentBicycle] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentBicycle] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentBicycle] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentBicycle] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentBicycle] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentBicycle] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentBicycle] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentBicycle] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentBicycle] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentBicycle] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentBicycle] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentBicycle] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentBicycle] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentBicycle] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentBicycle] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentBicycle] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentBicycle] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentBicycle] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentBicycle] SET RECOVERY FULL 
GO
ALTER DATABASE [RentBicycle] SET  MULTI_USER 
GO
ALTER DATABASE [RentBicycle] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentBicycle] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentBicycle] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentBicycle] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentBicycle] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RentBicycle', N'ON'
GO
ALTER DATABASE [RentBicycle] SET QUERY_STORE = OFF
GO
USE [RentBicycle]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CitizensIdentity] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CitizensIdentity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerIdentity] [varchar](20) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerPhone] [nvarchar](20) NULL,
	[EmployeeId] [int] NULL,
	[Date] [datetime] NULL,
	[Total] [decimal](18, 0) NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersDetail]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[ProductName] [nvarchar](50) NULL,
	[RentHours] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Img] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](120) NULL,
	[Email] [varchar](120) NULL,
	[Password] [varchar](max) NULL,
	[Role] [varchar](10) NULL,
	[Avatar] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
	[Phone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1', N'LE NGUYEN TOAN', N'0935123321')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1111', N'Nguyen van teo', N'0905566521')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'11111', N'aaaa', N'2222')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'111111', N'a', N'1')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'11111111111', N'aaaaaaaa', N'11111111111111')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'111111aaa', N'aaa', N'1')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1111abca', N'nguyen', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1123123', N'bnnn', N'123312')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'11231a77', N'aaa1', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'11a', N'bbb', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'11ca', N'bbbb', N'33333')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'12311', N'bbb', N'1111')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'12311aa', N'aaa', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123123', N'Nguyen Van A', N'0935123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1231231', N'aaaaa', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123123111', N'aa aa aa', N'0935123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'12312315', N'aaaa', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'1231231a', N'1231aaa', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'12312332', N'Nguyen Van A', N'0935123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123123a', N'123', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123123aaaa', N'bbbbb', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123321', N'aaaaa', N'123123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123aaa', N'aabb', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'123avv', N'aaaa', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'2', N'a', N'2')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'22222', N'aaaa', N'2222')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'22222222', N'aaaaaaaa', N'111111111')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'22223', N'aaaa', N'1111')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'223', N'a', N'223')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'3', N'a', N'3')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'32112', N'aaab', N'123')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'4', N'a', N'4')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'5', N'a', N'5')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'55', N'a', N'55')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'aaaa', N'111a', N'123321')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'aaaa1', N'11122annn', N'123321')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'aaaa2', N'222aaa', N'222222')
INSERT [dbo].[Customers] ([CitizensIdentity], [Name], [Phone]) VALUES (N'bbbb1111', N'aaaa', N'123123')
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (5, N'22222222', N'aaaaaaaa', N'111111111', 1, CAST(N'2021-11-03T10:15:59.120' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (6, N'22222', N'aaaa', N'2222', 1, CAST(N'2021-11-03T11:26:20.477' AS DateTime), CAST(50000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (7, N'22223', N'aaaa', N'1111', 1, CAST(N'2021-11-03T11:31:14.340' AS DateTime), CAST(80000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (8, N'aaaa2', N'222aaa', N'222222', 1, CAST(N'2021-11-03T11:32:19.403' AS DateTime), CAST(65000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (9, N'1111', N'aaa', N'11', 1, CAST(N'2021-11-03T11:52:43.083' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (10, N'11111', N'aaaa', N'2222', 1, CAST(N'2021-11-03T11:55:30.203' AS DateTime), CAST(25000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (11, N'1', N'1', N'1', 1, CAST(N'2021-11-03T11:56:52.757' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (12, N'111111', N'a', N'1', 1, CAST(N'2021-11-03T12:00:00.700' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (13, N'111111aaa', N'aaa', N'1', 1, CAST(N'2021-11-03T12:04:25.193' AS DateTime), CAST(30000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (14, N'2', N'a', N'2', 1, CAST(N'2021-11-03T12:08:41.620' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (15, N'3', N'a', N'3', 1, CAST(N'2021-11-03T12:09:10.597' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (16, N'4', N'a', N'4', 1, CAST(N'2021-11-03T12:11:01.957' AS DateTime), CAST(25000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (17, N'5', N'a', N'5', 1, CAST(N'2021-11-03T12:14:22.123' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (18, N'55', N'a', N'55', 1, CAST(N'2021-11-03T12:17:09.153' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (19, N'223', N'a', N'223', 1, CAST(N'2021-11-03T12:19:10.947' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (20, N'1', N'1', N'1', 1, CAST(N'2021-11-03T12:42:30.643' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (21, N'1', N'a', N'1', 1, CAST(N'2021-11-04T16:48:24.933' AS DateTime), CAST(25000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (22, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (23, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-02-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (24, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-03-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (25, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-04-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (26, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-05-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (27, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-06-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (28, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-07-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (29, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-08-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (30, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-09-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (31, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-10-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (32, N'1', N'Le Nguyen Toan', N'0935123321', 7, CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(20000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (33, N'123321', N'aaaaa', N'123123', 7, CAST(N'2021-11-08T15:49:34.520' AS DateTime), CAST(45000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (34, N'1231231', N'aaaaa', N'123', 7, CAST(N'2021-11-08T15:50:21.743' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (35, N'32112', N'aaab', N'123', 7, CAST(N'2021-11-08T16:20:05.820' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (36, N'12311', N'bbb', N'1111', 7, CAST(N'2021-11-08T16:26:59.223' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (37, N'11ca', N'bbbb', N'33333', 7, CAST(N'2021-11-08T16:29:19.927' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (38, N'aaaa1', N'11122annn', N'123321', 7, CAST(N'2021-11-08T16:30:00.940' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (39, N'aaaa', N'111a', N'123321', 7, CAST(N'2021-11-08T16:35:38.580' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (40, N'1123123', N'bnnn', N'123312', 7, CAST(N'2021-11-08T16:38:46.117' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (41, N'11a', N'aaaa', N'123', 7, CAST(N'2021-11-08T16:41:43.573' AS DateTime), CAST(25000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (42, N'123avv', N'aaaa', N'123', 7, CAST(N'2021-11-08T16:59:13.677' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (43, N'123aaa', N'aabb', N'123', 7, CAST(N'2021-11-08T16:59:49.797' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (44, N'1111abca', N'nguyen', N'123123', 7, CAST(N'2021-11-08T17:18:50.987' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'done')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (45, N'11231a77', N'aaa1', N'123123', 7, CAST(N'2021-11-08T17:20:47.877' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (46, N'12311aa', N'aaa', N'123', 7, CAST(N'2021-11-08T17:22:44.427' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (47, N'1231231a', N'1231aaa', N'123123', 7, CAST(N'2021-11-08T17:24:56.530' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (48, N'bbbb1111', N'aaaa', N'123123', 7, CAST(N'2021-11-08T17:43:05.337' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (49, N'123123a', N'123', N'123123', 7, CAST(N'2021-11-08T17:53:40.697' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (50, N'12312315', N'aaaa', N'123123', 7, CAST(N'2021-11-08T17:56:27.777' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (51, N'123123aaaa', N'bbbbb', N'123123', 7, CAST(N'2021-11-08T17:58:52.097' AS DateTime), CAST(10000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (52, N'123123', N'Nguyen Van A', N'0935123123', 7, CAST(N'2021-11-08T19:29:02.140' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (53, N'123123111', N'aa aa aa', N'0935123123', 7, CAST(N'2021-11-08T19:40:22.917' AS DateTime), CAST(240000 AS Decimal(18, 0)), N'renting')
INSERT [dbo].[Orders] ([Id], [CustomerIdentity], [CustomerName], [CustomerPhone], [EmployeeId], [Date], [Total], [Status]) VALUES (54, N'12312332', N'Nguyen Van A', N'0935123123', 7, CAST(N'2021-11-10T16:32:45.043' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'renting')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdersDetail] ON 

INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (3, 8, 3, 1, CAST(40000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (4, 8, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (5, 9, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (6, 10, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (7, 11, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (8, 12, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (9, 13, 2, 1, CAST(30000 AS Decimal(18, 0)), N'Road Fornix F8', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (10, 14, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (11, 15, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (12, 16, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (13, 17, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (14, 18, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (15, 19, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (16, 20, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (17, 21, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (18, 22, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (19, 23, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (20, 24, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (21, 25, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (22, 26, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (23, 27, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (24, 28, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (25, 29, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (26, 30, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (27, 31, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (28, 32, 3, 1, CAST(20000 AS Decimal(18, 0)), N'Touring Giant ESCAPE', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (29, 33, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (30, 33, 5, 2, CAST(20000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (31, 34, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (32, 35, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (33, 35, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (34, 36, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (35, 36, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (36, 37, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (37, 37, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (38, 38, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (39, 38, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (40, 39, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (41, 39, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (42, 40, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (43, 41, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (44, 42, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (45, 43, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (46, 44, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (47, 45, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (48, 46, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (49, 47, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (50, 48, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (51, 49, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (52, 49, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (53, 50, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (54, 50, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (55, 51, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (56, 52, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (57, 52, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (58, 53, 5, 6, CAST(240000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (59, 54, 4, 1, CAST(25000 AS Decimal(18, 0)), N'Hahoo 1997', CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[OrdersDetail] ([Id], [OrderId], [ProductId], [Quantity], [Price], [ProductName], [RentHours]) VALUES (60, 54, 5, 1, CAST(10000 AS Decimal(18, 0)), N'Hahoo Fake', CAST(1 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[OrdersDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [Img]) VALUES (1, N'MTB Fornix C26', 6, CAST(50000 AS Decimal(18, 0)), N'mtb-fornix-c26.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [Img]) VALUES (2, N'Road Fornix F8', 17, CAST(30000 AS Decimal(18, 0)), N'fornix-f8.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [Img]) VALUES (3, N'Touring Giant ESCAPE', 60, CAST(20000 AS Decimal(18, 0)), N'defaultPhone.jpg')
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [Img]) VALUES (4, N'Hahoo 1997', 15, CAST(25000 AS Decimal(18, 0)), N'hahoo12.png')
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [Img]) VALUES (5, N'Hahoo Fake', 19, CAST(10000 AS Decimal(18, 0)), N'hahoo12.png')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [Role], [Avatar], [DOB], [Phone]) VALUES (1, N'Le Nguyen Toan', N'admin01', N'admin', N'admin', N'lenguyentoan.jpg', NULL, NULL)
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [Role], [Avatar], [DOB], [Phone]) VALUES (6, N'Nguyen Van Teo', N'employee01', N'3724923114850596956133245243127987711', N'Employee', N'hulk.jpg', CAST(N'2013-11-13T00:00:00.000' AS DateTime), N'0935123321')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [Role], [Avatar], [DOB], [Phone]) VALUES (7, N'Le Nguyen Toan', N'admin', N'33354741122871651676713774147412831195', N'admin', N'hulk.jpg', CAST(N'2002-11-18T00:00:00.000' AS DateTime), N'0935123321')
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [Role], [Avatar], [DOB], [Phone]) VALUES (8, NULL, N'employee02', N'2251022057731868917119086224872421513662', N'Employee', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D105345F99267A]    Script Date: 11/15/2021 11:58:10 AM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerIdentity])
REFERENCES [dbo].[Customers] ([CitizensIdentity])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[usp_Login]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Login] @Email varchar(120),@Password varchar(120)
as

select * from users where Email = @Email AND [Password] = @Password
GO
/****** Object:  StoredProcedure [dbo].[usp_RegisterAccount]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_RegisterAccount] @Email varchar(120),@Password varchar(max)
as
insert into Users(Email,Password,Role) values(@Email,@Password,'Employee')
GO
/****** Object:  StoredProcedure [dbo].[usp_SelectMonthTotalByOrders1]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_SelectMonthTotalByOrders1] @Year int
as
select MONTH(Orders.Date)as Month ,SUM(Orders.Total)as Total from Orders where  YEAR(Orders.Date) = @Year and Orders.Status ='done' group by MONTH(Orders.Date)
GO
/****** Object:  StoredProcedure [dbo].[usp_SelectProductIdQuanityByYear2]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[usp_SelectProductIdQuanityByYear2] @Year int
as

select OrdersDetail.ProductId ,SUM(Quantity)as Quantity from OrdersDetail  inner join Orders on OrdersDetail.OrderId = Orders.Id where YEAR(Orders.Date) = @Year group by OrdersDetail.ProductId
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateAccount]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_UpdateAccount] @id int ,@name varchar(120),@avtar nvarchar(50),@dob datetime ,@phone varchar(20)
as
update Users set [Name] = @name, [Avatar] = @avtar , [DOB] =@dob,Phone = @phone where Id =@id  
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePassword]    Script Date: 11/15/2021 11:58:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_UpdatePassword] @id int, @pass varchar(max)
as
update Users set Password = @pass where Id =@id
GO
USE [master]
GO
ALTER DATABASE [RentBicycle] SET  READ_WRITE 
GO
