
CREATE DATABASE [dbSalary]
 
USE [dbSalary]
GO
/****** Object:  Table [dbo].[tbBasic_Salary]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBasic_Salary](
	[Cas_ID] [varchar](5) NOT NULL,
	[Amount] [decimal](15, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cas_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCheck_In_Out]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCheck_In_Out](
	[chk_ID] [int] NOT NULL,
	[Staff] [char](6) NOT NULL,
	[check_in] [datetime] NOT NULL,
	[check_out] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[chk_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCreate_Account]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCreate_Account](
	[Cre_ID] [int] NOT NULL,
	[staff] [char](6) NOT NULL,
	[Position] [varchar](5) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cre_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDepartment]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDepartment](
	[Dep_ID] [varchar](5) NOT NULL,
	[Dep_Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Dep_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPosition]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPosition](
	[Po_ID] [varchar](5) NOT NULL,
	[Po_Name_Eng] [varchar](30) NOT NULL,
	[Po_Name_Lao] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Po_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbQualification]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbQualification](
	[Qua_ID] [varchar](5) NOT NULL,
	[Qua_Name_Lao] [nvarchar](30) NOT NULL,
	[Qua_Name_Eng] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Qua_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStaff]    Script Date: 09-07-2020 10:21:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStaff](
	[St_ID] [char](6) NOT NULL,
	[Name_Lao] [nvarchar](20) NOT NULL,
	[Surname_Lao] [nvarchar](20) NOT NULL,
	[Name_Eng] [varchar](20) NOT NULL,
	[Surname_Eng] [varchar](20) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Status] [varchar](10) NOT NULL,
	[Date_of_Brith] [date] NOT NULL,
	[Province_now] [varchar](25) NOT NULL,
	[District_now] [varchar](25) NOT NULL,
	[Village_now] [varchar](25) NOT NULL,
	[mobile] [varchar](15) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[Facbook] [varchar](30) NOT NULL,
	[Qua_ID] [varchar](5) NOT NULL,
	[Po_ID] [varchar](5) NOT NULL,
	[Dep_ID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[St_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
