SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE DATABASE ProjectDb

CREATE TABLE [dbo].[User] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NULL
);
GO

CREATE TABLE [dbo].[Project] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [StartDate] DATETIME NOT NULL,
    [EndDate]   DATETIME NOT NULL,
    [Credits]   INT      NOT NULL
);
GO

CREATE TABLE [dbo].[UserProject] (
    [UserId]      INT      NOT NULL,
    [ProjectId]   INT      NOT NULL,
    [IsActive]    BIT      NOT NULL,
    [AsignedDate] DATETIME NOT NULL
);


