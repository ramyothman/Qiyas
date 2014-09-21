CREATE TABLE [PGME].[Program] (
    [ProgramId]          INT            IDENTITY (1, 1) NOT NULL,
    [ProgramTypeId]      INT            NULL,
    [DepartmentId]       INT            NULL,
    [ProgramName]        NVARCHAR (150) NULL,
    [ProgramDescription] NTEXT          NULL,
    CONSTRAINT [PK_Program] PRIMARY KEY CLUSTERED ([ProgramId] ASC)
);

