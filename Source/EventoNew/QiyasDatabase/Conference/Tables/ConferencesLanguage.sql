CREATE TABLE [Conference].[ConferencesLanguage] (
    [ConferenceId]       INT             IDENTITY (1, 1) NOT NULL,
    [SiteId]             INT             NULL,
    [ConferenceName]     NVARCHAR (500)  NULL,
    [ConferenceLogo]     NVARCHAR (500)  NULL,
    [StartDate]          DATETIME        NULL,
    [EndDate]            DATETIME        NULL,
    [IsActive]           BIT             NULL,
    [Location]           NVARCHAR (500)  NULL,
    [LocationName]       NVARCHAR (500)  NULL,
    [LocationLogo]       NVARCHAR (500)  NULL,
    [LocationLongitude]  DECIMAL (18, 2) NULL,
    [LocationLatitude]   DECIMAL (18, 2) NULL,
    [ConferenceDomain]   NVARCHAR (50)   NULL,
    [ConferenceParentId] INT             NOT NULL,
    [LanguageID]         INT             NOT NULL,
    CONSTRAINT [PK_Conferenceslanguage] PRIMARY KEY CLUSTERED ([ConferenceId] ASC)
);

