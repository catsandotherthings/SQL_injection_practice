USE [Rosie]
GO

/****** Object:  Table [dbo].[People]    Script Date: 2/21/2021 12:34:46 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[People]') AND type in (N'U'))
DROP TABLE [dbo].[People]
GO

/****** Object:  Table [dbo].[People]    Script Date: 2/21/2021 12:34:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[Name] [VarChar](max) NOT NULL,
	[SSN] [VarChar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


insert into [dbo].[People] values ('shawn', '123456789')
insert into [dbo].[People] values ('sydney', '987654321')


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 2/21/2021 12:43:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[SKU] [int] NULL,
	[Description] [varchar](max) NULL,
	[Quantity] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


insert into [dbo].[Products] values (123, 'bicycles', 12)
insert into [dbo].[Products] values (123, 'wagons', 8)