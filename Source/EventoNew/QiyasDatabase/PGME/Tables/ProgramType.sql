CREATE TABLE [PGME].[ProgramType] (
    [ProgramTypeId]   INT           IDENTITY (1, 1) NOT NULL,
    [ProgramTypeName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ProgramType] PRIMARY KEY CLUSTERED ([ProgramTypeId] ASC)
);

