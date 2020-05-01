
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2020 23:03:43
-- Generated from EDMX file: D:\Collage Work\Second Year\Programming Year 2\Sem 2\OOP\BreakingAppCA2\BreakingAppCA2\CarAppData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WeatherConData];
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

-- Creating table 'VecicleTypes'
CREATE TABLE [dbo].[VecicleTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeOfVechicle] nvarchar(max)  NOT NULL,
    [Weather_Id] int  NOT NULL
);
GO

-- Creating table 'Weathers'
CREATE TABLE [dbo].[Weathers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Condition] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'VecicleTypes'
ALTER TABLE [dbo].[VecicleTypes]
ADD CONSTRAINT [PK_VecicleTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Weathers'
ALTER TABLE [dbo].[Weathers]
ADD CONSTRAINT [PK_Weathers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Weather_Id] in table 'VecicleTypes'
ALTER TABLE [dbo].[VecicleTypes]
ADD CONSTRAINT [FK_VecicleTypeWeather]
    FOREIGN KEY ([Weather_Id])
    REFERENCES [dbo].[Weathers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VecicleTypeWeather'
CREATE INDEX [IX_FK_VecicleTypeWeather]
ON [dbo].[VecicleTypes]
    ([Weather_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------