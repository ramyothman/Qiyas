CREATE TABLE [Conference].[ConferenceScheduleLanguage] (
    [ScheduleId]            INT            IDENTITY (1, 1) NOT NULL,
    [ConferenceProgramId]   INT            NULL,
    [Title]                 NVARCHAR (500) NULL,
    [ScheduleSessionTypeId] INT            NULL,
    [StartTime]             DATETIME       NULL,
    [EndTime]               DATETIME       NULL,
    [SpeakerName]           NVARCHAR (50)  NULL,
    [ConferenceHallId]      INT            NULL,
    [Description]           NVARCHAR (250) NULL,
    [AllDescription]        NTEXT          NULL,
    [SpeakerID]             INT            NULL,
    [DocPath]               NVARCHAR (50)  NULL,
    [ScheduleparentID]      INT            NOT NULL,
    [LanguageID]            INT            NOT NULL,
    CONSTRAINT [PK_ConferenceScheduleLanguage] PRIMARY KEY CLUSTERED ([ScheduleId] ASC)
);

