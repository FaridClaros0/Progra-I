CREATE TABLE [dbo].[Table] (
    [IdAlumno]  INT        NOT NULL,
    [Codigo]    CHAR (10)  NOT NULL,
    [Nombre]    CHAR (50)  NOT NULL,
    [Direccion] CHAR (150) NOT NULL,
    [Dui]       CHAR (10)  NULL,
    [Telefono]  CHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([IdAlumno] ASC)
);

