CREATE TABLE [dbo].[Estudiante] (
    [Numero de Estudiante]               INT           NOT NULL IDENTITY,
    [Nombre]           NVARCHAR (50) NOT NULL,
    [Apellido]         NVARCHAR (50) NOT NULL,
    [Departamento]     NVARCHAR (50) NOT NULL,
    [Fecha de Ingreso] DATE          NOT NULL,
    [Pais]             NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Numero de Estudiante] ASC)
);

