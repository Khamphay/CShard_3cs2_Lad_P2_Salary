USE [master]
GO
/****** Object:  Database [dbSalary]    Script Date: 31-07-2020 4:19:34 PM ******/
CREATE DATABASE [dbSalary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbSalary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbSalary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbSalary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbSalary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbSalary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbSalary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbSalary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbSalary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbSalary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbSalary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbSalary] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbSalary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbSalary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbSalary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbSalary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbSalary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbSalary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbSalary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbSalary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbSalary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbSalary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbSalary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbSalary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbSalary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbSalary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbSalary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbSalary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbSalary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbSalary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbSalary] SET  MULTI_USER 
GO
ALTER DATABASE [dbSalary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbSalary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbSalary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbSalary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbSalary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbSalary] SET QUERY_STORE = OFF
GO
USE [dbSalary]
GO
/****** Object:  Table [dbo].[tbDepartment]    Script Date: 31-07-2020 4:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDepartment](
	[Dep_ID] [varchar](5) NOT NULL,
	[Dep_Name_Lao] [nvarchar](50) NOT NULL,
	[Dep_Name_Eng] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Dep_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPosition]    Script Date: 31-07-2020 4:19:34 PM ******/
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
/****** Object:  Table [dbo].[tbQualification]    Script Date: 31-07-2020 4:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbQualification](
	[Qua_ID] [varchar](5) NOT NULL,
	[Qua_Name_Eng] [varchar](30) NOT NULL,
	[Qua_Name_Lao] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__tbQualif__2B02A6F40A5AB8D5] PRIMARY KEY CLUSTERED 
(
	[Qua_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStaff]    Script Date: 31-07-2020 4:19:34 PM ******/
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
	[Village_now] [varchar](25) NOT NULL,
	[District_now] [varchar](25) NOT NULL,
	[Province_now] [varchar](25) NOT NULL,
	[mobile] [varchar](15) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[Facbook] [varchar](30) NOT NULL,
	[Qua_ID] [varchar](5) NOT NULL,
	[Po_ID] [varchar](5) NOT NULL,
	[Dep_ID] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tbStaff__B9034F93AB16AB8C] PRIMARY KEY CLUSTERED 
(
	[St_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Staff]    Script Date: 31-07-2020 4:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Staff]
AS
SELECT        dbo.tbStaff.St_ID, dbo.tbStaff.Name_Lao, dbo.tbStaff.Surname_Lao, dbo.tbStaff.Name_Eng, dbo.tbStaff.Surname_Eng, dbo.tbStaff.Gender, dbo.tbStaff.Status, dbo.tbStaff.Date_of_Brith, dbo.tbStaff.Village_now, 
                         dbo.tbStaff.District_now, dbo.tbStaff.Province_now, dbo.tbStaff.mobile, dbo.tbStaff.email, dbo.tbStaff.Facbook, dbo.tbQualification.Qua_Name_Eng, dbo.tbQualification.Qua_Name_Lao, dbo.tbPosition.Po_Name_Eng, 
                         dbo.tbPosition.Po_Name_Lao, dbo.tbDepartment.Dep_Name_Lao, dbo.tbDepartment.Dep_Name_Eng
FROM            dbo.tbStaff INNER JOIN
                         dbo.tbDepartment ON dbo.tbStaff.Dep_ID = dbo.tbDepartment.Dep_ID INNER JOIN
                         dbo.tbPosition ON dbo.tbStaff.Po_ID = dbo.tbPosition.Po_ID INNER JOIN
                         dbo.tbQualification ON dbo.tbStaff.Qua_ID = dbo.tbQualification.Qua_ID
GO
/****** Object:  Table [dbo].[tbCheck_In_Out]    Script Date: 31-07-2020 4:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCheck_In_Out](
	[chk_ID] [int] NOT NULL,
	[Staff] [char](6) NOT NULL,
	[check_in] [datetime] NOT NULL,
	[check_out] [datetime] NULL,
 CONSTRAINT [PK__tbCheck___3BCCB515AE827E36] PRIMARY KEY CLUSTERED 
(
	[chk_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Check_In_Out]    Script Date: 31-07-2020 4:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Check_In_Out]
AS
SELECT dbo.tbCheck_In_Out.chk_ID, dbo.tbCheck_In_Out.Staff, dbo.tbStaff.Name_Lao, dbo.tbStaff.Surname_Lao, dbo.tbStaff.Name_Eng, dbo.tbStaff.Surname_Eng, dbo.tbCheck_In_Out.check_in, dbo.tbCheck_In_Out.check_out
FROM   dbo.tbCheck_In_Out INNER JOIN
             dbo.tbStaff ON dbo.tbCheck_In_Out.Staff = dbo.tbStaff.St_ID
GO
/****** Object:  Table [dbo].[tbBasic_Salary]    Script Date: 31-07-2020 4:19:34 PM ******/
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
/****** Object:  Table [dbo].[tbCreate_Account]    Script Date: 31-07-2020 4:19:34 PM ******/
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
ALTER TABLE [dbo].[tbCheck_In_Out]  WITH CHECK ADD  CONSTRAINT [FK__tbCheck_I__Staff__46E78A0C] FOREIGN KEY([Staff])
REFERENCES [dbo].[tbStaff] ([St_ID])
GO
ALTER TABLE [dbo].[tbCheck_In_Out] CHECK CONSTRAINT [FK__tbCheck_I__Staff__46E78A0C]
GO
ALTER TABLE [dbo].[tbCreate_Account]  WITH CHECK ADD FOREIGN KEY([Position])
REFERENCES [dbo].[tbPosition] ([Po_ID])
GO
ALTER TABLE [dbo].[tbCreate_Account]  WITH CHECK ADD  CONSTRAINT [FK__tbCreate___staff__4316F928] FOREIGN KEY([staff])
REFERENCES [dbo].[tbStaff] ([St_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbCreate_Account] CHECK CONSTRAINT [FK__tbCreate___staff__4316F928]
GO
ALTER TABLE [dbo].[tbStaff]  WITH CHECK ADD  CONSTRAINT [FK__tbStaff__Dep_ID__403A8C7D] FOREIGN KEY([Dep_ID])
REFERENCES [dbo].[tbDepartment] ([Dep_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbStaff] CHECK CONSTRAINT [FK__tbStaff__Dep_ID__403A8C7D]
GO
ALTER TABLE [dbo].[tbStaff]  WITH CHECK ADD  CONSTRAINT [FK__tbStaff__Po_ID__3F466844] FOREIGN KEY([Po_ID])
REFERENCES [dbo].[tbPosition] ([Po_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbStaff] CHECK CONSTRAINT [FK__tbStaff__Po_ID__3F466844]
GO
ALTER TABLE [dbo].[tbStaff]  WITH CHECK ADD  CONSTRAINT [FK__tbStaff__Qua_ID__3E52440B] FOREIGN KEY([Qua_ID])
REFERENCES [dbo].[tbQualification] ([Qua_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbStaff] CHECK CONSTRAINT [FK__tbStaff__Qua_ID__3E52440B]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbCheck_In_Out"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 265
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbStaff"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 277
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Check_In_Out'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Check_In_Out'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[35] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbStaff"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "tbDepartment"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 152
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbPosition"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 179
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbQualification"
            Begin Extent = 
               Top = 9
               Left = 894
               Bottom = 179
               Right = 1122
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 20
         Width = 284
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
         Width = 1005
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 5100
         Alias = 900
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Staff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Staff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Staff'
GO
USE [master]
GO
ALTER DATABASE [dbSalary] SET  READ_WRITE 
GO
