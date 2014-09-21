CREATE TABLE [Conference].[ConferenceRegistrationSettings] (
    [ConferenceRegistrationSettingID] INT      IDENTITY (1, 1) NOT NULL,
    [ConferenceID]                    INT      NULL,
    [RegistrationEndDate]             DATETIME NULL,
    [RegistrationStartDate]           DATETIME NULL,
    [IsActive]                        BIT      NULL,
    CONSTRAINT [PK_ConferenceRegistrationSettings] PRIMARY KEY CLUSTERED ([ConferenceRegistrationSettingID] ASC),
    CONSTRAINT [FK_ConferenceRegistrationSettings_Conferences] FOREIGN KEY ([ConferenceID]) REFERENCES [Conference].[Conferences] ([ConferenceId]) ON DELETE CASCADE ON UPDATE CASCADE
);

