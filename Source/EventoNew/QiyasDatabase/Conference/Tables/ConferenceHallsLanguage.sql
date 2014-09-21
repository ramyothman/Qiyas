CREATE TABLE [Conference].[ConferenceHallsLanguage] (
    [ConferenceHallsId]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]                    NVARCHAR (50)  NULL,
    [ConferenceId]            INT            NULL,
    [MapPath]                 NVARCHAR (500) NULL,
    [LanguageID]              INT            NOT NULL,
    [ConferenceHallsParentID] INT            NOT NULL,
    CONSTRAINT [PK_ConferenceHallsLanguage] PRIMARY KEY CLUSTERED ([ConferenceHallsId] ASC)
);

