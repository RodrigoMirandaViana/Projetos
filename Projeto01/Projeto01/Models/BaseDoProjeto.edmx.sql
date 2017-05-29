
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2017 11:09:10
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CarroMarcas'
CREATE TABLE [dbo].[CarroMarcas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Modelos'
CREATE TABLE [dbo].[Modelos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ano] nvarchar(max)  NOT NULL,
    [CarroMarcaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CarroMarcas'
ALTER TABLE [dbo].[CarroMarcas]
ADD CONSTRAINT [PK_CarroMarcas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Modelos'
ALTER TABLE [dbo].[Modelos]
ADD CONSTRAINT [PK_Modelos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CarroMarcaId] in table 'Modelos'
ALTER TABLE [dbo].[Modelos]
ADD CONSTRAINT [FK_CarroMarcaModelo]
    FOREIGN KEY ([CarroMarcaId])
    REFERENCES [dbo].[CarroMarcas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroMarcaModelo'
CREATE INDEX [IX_FK_CarroMarcaModelo]
ON [dbo].[Modelos]
    ([CarroMarcaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------