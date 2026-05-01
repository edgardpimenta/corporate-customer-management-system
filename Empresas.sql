CREATE TABLE [dbo].[Empresas] (
    [Id]   UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
    [Nome] NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    TipoDeCliente INT NOT NULL,
    Status INT NOT NULL 
);

