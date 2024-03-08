USE [master]
GO

/****** Object: Table [dbo].[userTable] Script Date: 3/8/2024 3:44:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[userTable] (
    [userID]         INT            IDENTITY (1, 1) NOT NULL,
    [userName]       NVARCHAR (50)  NULL,
    [password]       NVARCHAR (100) NULL,
    [email]          NVARCHAR (50)  NULL,
    [stepDepartment] NVARCHAR (50)  NULL,
    [firstName]      NVARCHAR (50)  NULL,
    [lastName]       NVARCHAR (50)  NULL,
    [contact]        INT            NULL,
    [address]        NVARCHAR (50)  NULL,
    [gender]         NVARCHAR (50)  NULL
);


