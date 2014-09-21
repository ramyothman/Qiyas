CREATE TABLE [Conference].[ConferencePrograms] (
    [ConferenceProgramId] INT           IDENTITY (1, 1) NOT NULL,
    [ProgramName]         NVARCHAR (50) NULL,
    [ConferenceId]        INT           NULL,
    CONSTRAINT [PK_ConferencePrograms] PRIMARY KEY CLUSTERED ([ConferenceProgramId] ASC)
);

