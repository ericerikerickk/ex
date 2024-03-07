USE [master]
GO

/****** Object: Table [dbo].[userTable] Script Date: 3/7/2024 10:16:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[userTable] (
    [userID]   INT            IDENTITY (1, 1) NOT NULL,
    [userName] NVARCHAR (50)  NULL,
    [password] NVARCHAR (100) NULL
);


