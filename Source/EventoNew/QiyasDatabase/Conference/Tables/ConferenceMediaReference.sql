CREATE TABLE [Conference].[ConferenceMediaReference] (
    [ConferenceMediaReferenceId] INT            IDENTITY (1, 1) NOT NULL,
    [ConferenceId]               INT            NULL,
    [LanguageId]                 INT            NULL,
    [ReferenceOrder]             INT            NULL,
    [Title]                      NVARCHAR (250) NULL,
    [ReferenceUrl]               NVARCHAR (250) NULL,
    [ReferenceName]              NVARCHAR (150) NULL,
    [ReferenceLogo]              NVARCHAR (250) NULL,
    [PublishingDate]             DATETIME       NULL,
    CONSTRAINT [PK_ConferenceMediaReference] PRIMARY KEY CLUSTERED ([ConferenceMediaReferenceId] ASC)
);

