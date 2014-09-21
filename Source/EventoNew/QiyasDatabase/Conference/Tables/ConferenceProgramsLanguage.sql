CREATE TABLE [Conference].[ConferenceProgramsLanguage] (
    [ConferenceProgramId]       INT           IDENTITY (1, 1) NOT NULL,
    [ProgramName]               NVARCHAR (50) NULL,
    [ConferenceId]              INT           NULL,
    [LanguageID]                INT           NOT NULL,
    [ConferenceProgramParentID] INT           NOT NULL,
    CONSTRAINT [PK_ConferenceProgramsLanguage] PRIMARY KEY CLUSTERED ([ConferenceProgramId] ASC)
);

