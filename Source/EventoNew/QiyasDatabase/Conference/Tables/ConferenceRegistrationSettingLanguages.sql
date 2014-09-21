CREATE TABLE [Conference].[ConferenceRegistrationSettingLanguages] (
    [ConferenceRegistrationSettingLanguageID] INT            IDENTITY (1, 1) NOT NULL,
    [ConferenceRegistrationSettingID]         INT            NULL,
    [RegistrationShorInstructions]            NVARCHAR (500) NULL,
    [RegistrationInstructionsInFormPre]       NTEXT          NULL,
    [RegistrationInstructionsInFormPost]      NCHAR (10)     NULL,
    [PostRegistrationInstructions]            NTEXT          NULL,
    [LanguageID]                              INT            NULL,
    CONSTRAINT [PK_ConferenceRegistrationSettingLanguages] PRIMARY KEY CLUSTERED ([ConferenceRegistrationSettingLanguageID] ASC),
    CONSTRAINT [FK_ConferenceRegistrationSettingLanguages_ConferenceRegistrationSettings] FOREIGN KEY ([ConferenceRegistrationSettingID]) REFERENCES [Conference].[ConferenceRegistrationSettings] ([ConferenceRegistrationSettingID]) ON DELETE CASCADE ON UPDATE CASCADE
);

