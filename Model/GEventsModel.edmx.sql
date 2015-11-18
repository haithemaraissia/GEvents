
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/16/2015 16:15:02
-- Generated from EDMX file: C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\Model\GEventsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_33736_events];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Agenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agenda];
GO
IF OBJECT_ID(N'[dbo].[Booths]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Booths];
GO
IF OBJECT_ID(N'[dbo].[Buyers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyers];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[EventTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventTypes];
GO
IF OBJECT_ID(N'[dbo].[FeedBacks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FeedBacks];
GO
IF OBJECT_ID(N'[dbo].[Invitations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invitations];
GO
IF OBJECT_ID(N'[dbo].[InvitationSchedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvitationSchedules];
GO
IF OBJECT_ID(N'[dbo].[InvitationsRefused]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvitationsRefused];
GO
IF OBJECT_ID(N'[dbo].[Sellers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sellers];
GO
IF OBJECT_ID(N'[dbo].[Speakers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Speakers];
GO
IF OBJECT_ID(N'[dbo].[SpeakerSchedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SpeakerSchedules];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UserTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Agenda'
CREATE TABLE [dbo].[Agenda] (
    [AgendaId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AgendaDate] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [AgendaTitle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Speakers'
CREATE TABLE [dbo].[Speakers] (
    [SpeakerId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Company] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [Bio] nvarchar(max)  NOT NULL,
    [ScheduleId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sellers'
CREATE TABLE [dbo].[Sellers] (
    [SellerId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [CompanyId] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Buyers'
CREATE TABLE [dbo].[Buyers] (
    [BuyerId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [CompanyId] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Booths'
CREATE TABLE [dbo].[Booths] (
    [BoothId] int IDENTITY(1,1) NOT NULL,
    [BoothIdentifier] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [UserTypeId] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [CompanyId] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserTypes'
CREATE TABLE [dbo].[UserTypes] (
    [TypeId] int IDENTITY(1,1) NOT NULL,
    [TypeValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EventDate] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [EventTitle] nvarchar(max)  NOT NULL,
    [EventTypeId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FeedBacks'
CREATE TABLE [dbo].[FeedBacks] (
    [FeedBackId] int IDENTITY(1,1) NOT NULL,
    [FeebBack] nvarchar(max)  NOT NULL,
    [Rate] nvarchar(max)  NOT NULL,
    [Section] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [CompanyId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SpeakerSchedules'
CREATE TABLE [dbo].[SpeakerSchedules] (
    [ScheduleId] int IDENTITY(1,1) NOT NULL,
    [EventId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EventTypes'
CREATE TABLE [dbo].[EventTypes] (
    [EventTypeId] int IDENTITY(1,1) NOT NULL,
    [EventTypeValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Invitations'
CREATE TABLE [dbo].[Invitations] (
    [InvitationId] int IDENTITY(1,1) NOT NULL,
    [BuyerId] nvarchar(max)  NOT NULL,
    [SellerId] nvarchar(max)  NOT NULL,
    [BoothId] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InvitationSchedules'
CREATE TABLE [dbo].[InvitationSchedules] (
    [InvitationScheduleId] int IDENTITY(1,1) NOT NULL,
    [BuyerId] nvarchar(max)  NOT NULL,
    [SellerId] nvarchar(max)  NOT NULL,
    [BoothId] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InvitationsRefuseds'
CREATE TABLE [dbo].[InvitationsRefuseds] (
    [InvitationId] int IDENTITY(1,1) NOT NULL,
    [BuyerId] nvarchar(max)  NOT NULL,
    [SellerId] nvarchar(max)  NOT NULL,
    [BoothId] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AgendaId] in table 'Agenda'
ALTER TABLE [dbo].[Agenda]
ADD CONSTRAINT [PK_Agenda]
    PRIMARY KEY CLUSTERED ([AgendaId] ASC);
GO

-- Creating primary key on [SpeakerId] in table 'Speakers'
ALTER TABLE [dbo].[Speakers]
ADD CONSTRAINT [PK_Speakers]
    PRIMARY KEY CLUSTERED ([SpeakerId] ASC);
GO

-- Creating primary key on [SellerId] in table 'Sellers'
ALTER TABLE [dbo].[Sellers]
ADD CONSTRAINT [PK_Sellers]
    PRIMARY KEY CLUSTERED ([SellerId] ASC);
GO

-- Creating primary key on [BuyerId] in table 'Buyers'
ALTER TABLE [dbo].[Buyers]
ADD CONSTRAINT [PK_Buyers]
    PRIMARY KEY CLUSTERED ([BuyerId] ASC);
GO

-- Creating primary key on [BoothId] in table 'Booths'
ALTER TABLE [dbo].[Booths]
ADD CONSTRAINT [PK_Booths]
    PRIMARY KEY CLUSTERED ([BoothId] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [TypeId] in table 'UserTypes'
ALTER TABLE [dbo].[UserTypes]
ADD CONSTRAINT [PK_UserTypes]
    PRIMARY KEY CLUSTERED ([TypeId] ASC);
GO

-- Creating primary key on [EventId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [FeedBackId] in table 'FeedBacks'
ALTER TABLE [dbo].[FeedBacks]
ADD CONSTRAINT [PK_FeedBacks]
    PRIMARY KEY CLUSTERED ([FeedBackId] ASC);
GO

-- Creating primary key on [CompanyId] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([CompanyId] ASC);
GO

-- Creating primary key on [ScheduleId] in table 'SpeakerSchedules'
ALTER TABLE [dbo].[SpeakerSchedules]
ADD CONSTRAINT [PK_SpeakerSchedules]
    PRIMARY KEY CLUSTERED ([ScheduleId] ASC);
GO

-- Creating primary key on [EventTypeId] in table 'EventTypes'
ALTER TABLE [dbo].[EventTypes]
ADD CONSTRAINT [PK_EventTypes]
    PRIMARY KEY CLUSTERED ([EventTypeId] ASC);
GO

-- Creating primary key on [InvitationId] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [PK_Invitations]
    PRIMARY KEY CLUSTERED ([InvitationId] ASC);
GO

-- Creating primary key on [InvitationScheduleId] in table 'InvitationSchedules'
ALTER TABLE [dbo].[InvitationSchedules]
ADD CONSTRAINT [PK_InvitationSchedules]
    PRIMARY KEY CLUSTERED ([InvitationScheduleId] ASC);
GO

-- Creating primary key on [InvitationId] in table 'InvitationsRefuseds'
ALTER TABLE [dbo].[InvitationsRefuseds]
ADD CONSTRAINT [PK_InvitationsRefuseds]
    PRIMARY KEY CLUSTERED ([InvitationId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------