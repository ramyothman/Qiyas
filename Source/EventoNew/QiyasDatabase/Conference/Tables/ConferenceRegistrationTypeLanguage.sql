CREATE TABLE [Conference].[ConferenceRegistrationTypeLanguage] (
    [ConferenceRegistrationTypeId]       INT             IDENTITY (1, 1) NOT NULL,
    [ConferenceId]                       INT             NULL,
    [Name]                               NVARCHAR (50)   NULL,
    [Fee]                                DECIMAL (18, 2) NULL,
    [ConferenceRegistrationTypeParentId] INT             NOT NULL,
    [LanguageID]                         INT             NOT NULL,
    [Description]                        NVARCHAR (500)  NULL,
    [OfferMessage]                       NTEXT           NULL,
    CONSTRAINT [PK_ConferenceRegistrationTypeLanguage] PRIMARY KEY CLUSTERED ([ConferenceRegistrationTypeId] ASC)
);

