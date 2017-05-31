
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 10:31:46
-- Generated from EDMX file: C:\Users\1615580\Source\Repos\Projetos\Projeto01\Projeto01\Models\BaseDoProjeto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjetoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarroModelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Modelos] DROP CONSTRAINT [FK_CarroModelo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Modelos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Modelos];
GO
IF OBJECT_ID(N'[dbo].[Carros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Modelos'
CREATE TABLE [dbo].[Modelos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Ano] nvarchar(10)  NOT NULL,
    [CarroId] int  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Popular] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Modelos'
ALTER TABLE [dbo].[Modelos]
ADD CONSTRAINT [PK_Modelos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CarroId] in table 'Modelos'
ALTER TABLE [dbo].[Modelos]
ADD CONSTRAINT [FK_CarroModelo]
    FOREIGN KEY ([CarroId])
    REFERENCES [dbo].[Carros]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroModelo'
CREATE INDEX [IX_FK_CarroModelo]
ON [dbo].[Modelos]
    ([CarroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------