
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2020 00:26:08
-- Generated from EDMX file: D:\Collage Work\Second Year\Programming Year 2\Sem 2\OOP\BreakingAppCA2\BreakingAppCA2\Weather.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WeatherConditions];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WeatherTypes'
CREATE TABLE [dbo].[WeatherTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Weather] nvarchar(max)  NOT NULL,
    [Condition_Id] int  NOT NULL
);
GO

-- Creating table 'Conditions'
CREATE TABLE [dbo].[Conditions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Mulitiplyer] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WeatherTypes'
ALTER TABLE [dbo].[WeatherTypes]
ADD CONSTRAINT [PK_WeatherTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Conditions'
ALTER TABLE [dbo].[Conditions]
ADD CONSTRAINT [PK_Conditions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Condition_Id] in table 'WeatherTypes'
ALTER TABLE [dbo].[WeatherTypes]
ADD CONSTRAINT [FK_WeatherTypeCondition]
    FOREIGN KEY ([Condition_Id])
    REFERENCES [dbo].[Conditions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WeatherTypeCondition'
CREATE INDEX [IX_FK_WeatherTypeCondition]
ON [dbo].[WeatherTypes]
    ([Condition_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------