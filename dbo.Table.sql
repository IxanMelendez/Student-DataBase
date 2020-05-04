CREATE TABLE [dbo].[Estudiante]
(
	[Numero de estudiante] INT NOT NULL PRIMARY KEY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Apellido] NVARCHAR(50) NOT NULL, 
    [Departamento] NVARCHAR(50) NOT NULL, 
    [Fecha de ingreso] DATE NOT NULL, 
    [Pais] NVARCHAR(50) NOT NULL
)
