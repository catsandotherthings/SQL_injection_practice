-- This is a test
USE [Rosie]
GO

/****** Object:  Table [dbo].[People]    Script Date: 2/6/2021 2:06:27 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[People]') AND type in (N'U'))
DROP TABLE [dbo].[People]
GO

/****** Object:  Table [dbo].[People]    Script Date: 2/6/2021 2:06:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[Name] [varchar(max)] NOT NULL,
	[SSN] [varchar(max)] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


