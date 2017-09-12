
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/12/2017 12:43:17
-- Generated from EDMX file: C:\Users\Windows\Documents\Soluciones\Gastronomia\Gastronomia\AccesoDatos\Gastronomia.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gastronomia];
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

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Apellido] nvarchar(250)  NOT NULL,
    [Nombre] nvarchar(250)  NOT NULL,
    [Cuil] nvarchar(11)  NOT NULL,
    [Domicilio] nvarchar(400)  NOT NULL,
    [Telefono] nvarchar(25)  NULL,
    [Celular] nvarchar(25)  NULL,
    [Email] nvarchar(250)  NULL,
    [FechaNacimiento] datetime  NOT NULL
);
GO

-- Creating table 'Personas_Empleado'
CREATE TABLE [dbo].[Personas_Empleado] (
    [Legajo] int  NOT NULL,
    [FechaIngreso] datetime  NOT NULL,
    [Id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [PK_Personas_Empleado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------