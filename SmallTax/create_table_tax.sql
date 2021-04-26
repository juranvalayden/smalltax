USE [Dummy]
GO

/****** Object:  Table [dbo].[techass.tax]    Script Date: 4/26/2021 12:31:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[techass.tax](
	[id] [int] NOT NULL,
	[rate] [decimal](18, 0) NULL,
	[lower] [decimal](18, 0) NULL,
	[upper] [decimal](18, 0) NULL
) ON [PRIMARY]
GO


