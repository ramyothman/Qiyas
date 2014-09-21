CREATE TABLE [Conference].[ScheduleSessionTypeLanguage] (
    [ScheduleSessionTypeId]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]                        NVARCHAR (50) NULL,
    [ConferenceId]                INT           NULL,
    [LanguageID]                  INT           NOT NULL,
    [ScheduleSessionTypeParentId] INT           NOT NULL,
    CONSTRAINT [PK_ScheduleSessionTypeLanguage] PRIMARY KEY CLUSTERED ([ScheduleSessionTypeId] ASC)
);

