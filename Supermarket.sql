USE [master]
GO
/****** Object:  Database [Supermarket]    Script Date: 2022/6/19 21:42:41 ******/
CREATE DATABASE [Supermarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Supermarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Supermarket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Supermarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Supermarket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Supermarket] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Supermarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Supermarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Supermarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Supermarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Supermarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Supermarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [Supermarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Supermarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Supermarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Supermarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Supermarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Supermarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Supermarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Supermarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Supermarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Supermarket] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Supermarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Supermarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Supermarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Supermarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Supermarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Supermarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Supermarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Supermarket] SET RECOVERY FULL 
GO
ALTER DATABASE [Supermarket] SET  MULTI_USER 
GO
ALTER DATABASE [Supermarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Supermarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Supermarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Supermarket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Supermarket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Supermarket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Supermarket', N'ON'
GO
ALTER DATABASE [Supermarket] SET QUERY_STORE = OFF
GO
USE [Supermarket]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 2022/6/19 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[管理员编号] [varchar](12) NOT NULL,
	[姓名] [varchar](12) NOT NULL,
	[性别] [varchar](4) NOT NULL,
	[年龄] [int] NOT NULL,
	[电话] [varchar](18) NOT NULL,
	[住址] [varchar](24) NOT NULL,
	[密码] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[管理员编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2022/6/19 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[客户编号] [varchar](12) NOT NULL,
	[姓名] [varchar](12) NOT NULL,
	[性别] [varchar](4) NOT NULL,
	[电话] [varchar](18) NOT NULL,
	[VIP] [bit] NULL,
	[备注] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[客户编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2022/6/19 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[员工编号] [varchar](12) NOT NULL,
	[姓名] [varchar](12) NOT NULL,
	[性别] [varchar](4) NOT NULL,
	[年龄] [int] NOT NULL,
	[电话] [varchar](18) NOT NULL,
	[住址] [varchar](24) NOT NULL,
	[职位] [varchar](12) NOT NULL,
	[密码] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[员工编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods]    Script Date: 2022/6/19 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods](
	[商品编号] [varchar](12) NOT NULL,
	[商品属性] [varchar](12) NOT NULL,
	[商品名称] [varchar](12) NOT NULL,
	[商品单价] [int] NOT NULL,
	[库存量] [int] NOT NULL,
	[生产厂商] [varchar](24) NOT NULL,
	[保质期] [date] NOT NULL,
	[备注] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[商品编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trade]    Script Date: 2022/6/19 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trade](
	[流水单号] [varchar](12) NOT NULL,
	[客户编号] [varchar](12) NOT NULL,
	[商品编号] [varchar](12) NOT NULL,
	[商品数量] [int] NOT NULL,
	[购买时间] [date] NOT NULL,
	[金额] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[流水单号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([管理员编号], [姓名], [性别], [年龄], [电话], [住址], [密码]) VALUES (N'10001', N'胡图图', N'男', 8, N'180610233', N'翻斗花园', N'11')
INSERT [dbo].[Admin] ([管理员编号], [姓名], [性别], [年龄], [电话], [住址], [密码]) VALUES (N'10002', N'牛爷爷', N'男', 22, N'122223000', N'翻斗花园', N'122313')
GO
INSERT [dbo].[Customers] ([客户编号], [姓名], [性别], [电话], [VIP], [备注]) VALUES (N'20001', N'张三', N'男', N'1222211', NULL, NULL)
INSERT [dbo].[Customers] ([客户编号], [姓名], [性别], [电话], [VIP], [备注]) VALUES (N'20002', N'李四', N'女', N'23333411', NULL, NULL)
INSERT [dbo].[Customers] ([客户编号], [姓名], [性别], [电话], [VIP], [备注]) VALUES (N'20003', N'王五', N'男', N'23123145', NULL, NULL)
INSERT [dbo].[Customers] ([客户编号], [姓名], [性别], [电话], [VIP], [备注]) VALUES (N'20004', N'赵六', N'女', N'1323712', NULL, NULL)
INSERT [dbo].[Customers] ([客户编号], [姓名], [性别], [电话], [VIP], [备注]) VALUES (N'20005', N'孙七', N'男', N'23123451', NULL, NULL)
GO
INSERT [dbo].[Employees] ([员工编号], [姓名], [性别], [年龄], [电话], [住址], [职位], [密码]) VALUES (N'30001', N'刻晴', N'女', 18, N'23125123', N'璃月', N'七星', N'31')
INSERT [dbo].[Employees] ([员工编号], [姓名], [性别], [年龄], [电话], [住址], [职位], [密码]) VALUES (N'30002', N'琴', N'女', 18, N'31245513', N'蒙德', N'骑士团团长', N'32')
INSERT [dbo].[Employees] ([员工编号], [姓名], [性别], [年龄], [电话], [住址], [职位], [密码]) VALUES (N'30003', N'神子', N'女', 518, N'312345132', N'稻妻', N'巫女', N'33')
GO
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40001', N'食品', N'日落果', 10, 969, N'果树', CAST(N'2024-10-01' AS Date), N'')
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40002', N'食品', N'草莓', 2, 413, N'丛林', CAST(N'2022-08-01' AS Date), NULL)
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40003', N'花卉', N'小灯草', 20, 100, N'花圃', CAST(N'2022-07-02' AS Date), NULL)
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40004', N'生鲜', N'路鳗鳗', 101, 50, N'海洋', CAST(N'2022-06-15' AS Date), N'')
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40005', N'武器', N'天空之翼', 100000, 2, N'祈愿', CAST(N'2099-01-01' AS Date), NULL)
INSERT [dbo].[Goods] ([商品编号], [商品属性], [商品名称], [商品单价], [库存量], [生产厂商], [保质期], [备注]) VALUES (N'40006', N'圣遗物', N'羽毛', 1000, 20, N'副本', CAST(N'2042-01-01' AS Date), NULL)
GO
INSERT [dbo].[Trade] ([流水单号], [客户编号], [商品编号], [商品数量], [购买时间], [金额]) VALUES (N'50001', N'20001', N'40001', 2, CAST(N'2022-05-06' AS Date), 50)
INSERT [dbo].[Trade] ([流水单号], [客户编号], [商品编号], [商品数量], [购买时间], [金额]) VALUES (N'50002', N'20004', N'40004', 4, CAST(N'2022-05-07' AS Date), 200)
INSERT [dbo].[Trade] ([流水单号], [客户编号], [商品编号], [商品数量], [购买时间], [金额]) VALUES (N'50003', N'20001', N'40001', 13, CAST(N'2022-06-13' AS Date), 24)
GO
ALTER TABLE [dbo].[Trade]  WITH CHECK ADD FOREIGN KEY([客户编号])
REFERENCES [dbo].[Customers] ([客户编号])
GO
ALTER TABLE [dbo].[Trade]  WITH CHECK ADD FOREIGN KEY([商品编号])
REFERENCES [dbo].[Goods] ([商品编号])
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [CK_sex1] CHECK  (([性别]='男' OR [性别]='女'))
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [CK_sex1]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CK_sex2] CHECK  (([性别]='男' OR [性别]='女'))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CK_sex2]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [CK_sex3] CHECK  (([性别]='男' OR [性别]='女'))
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [CK_sex3]
GO
USE [master]
GO
ALTER DATABASE [Supermarket] SET  READ_WRITE 
GO
