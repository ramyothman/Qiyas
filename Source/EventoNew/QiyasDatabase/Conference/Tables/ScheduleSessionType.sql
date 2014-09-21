CREATE TABLE [Conference].[ScheduleSessionType] (
    [ScheduleSessionTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]                  NVARCHAR (50) NULL,
    [ConferenceId]          INT           NULL,
    CONSTRAINT [PK_ScheduleSessionType] PRIMARY KEY CLUSTERED ([ScheduleSessionTypeId] ASC)
);

