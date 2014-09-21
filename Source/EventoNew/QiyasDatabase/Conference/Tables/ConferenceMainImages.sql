CREATE TABLE [Conference].[ConferenceMainImages] (
    [ConferenceMainImageId] INT            IDENTITY (1, 1) NOT NULL,
    [PhotoPath]             NVARCHAR (250) NULL,
    [ConferenceId]          INT            NULL,
    [LanguageId]            INT            NULL,
    [PhotoLink]             NVARCHAR (250) NULL,
    [PhotoTitle]            NVARCHAR (50)  NULL,
    [PhotoDescription]      NVARCHAR (150) NULL,
    CONSTRAINT [PK_ConferenceMainImages] PRIMARY KEY CLUSTERED ([ConferenceMainImageId] ASC)
);

