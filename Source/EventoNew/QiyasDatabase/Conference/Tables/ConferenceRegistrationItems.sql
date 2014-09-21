CREATE TABLE [Conference].[ConferenceRegistrationItems] (
    [ConferenceRegistrationItemID] INT      IDENTITY (1, 1) NOT NULL,
    [ConferenceRegistrationTypeID] INT      NULL,
    [ConferenceRegistererId]       INT      NULL,
    [CreatedDate]                  DATETIME CONSTRAINT [DF_ConferenceRegistrationItems_CreatedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_ConferenceRegistrationItems] PRIMARY KEY CLUSTERED ([ConferenceRegistrationItemID] ASC)
);

