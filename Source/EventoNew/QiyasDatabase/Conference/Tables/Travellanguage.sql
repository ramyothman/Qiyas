CREATE TABLE [Conference].[Travellanguage] (
    [ID]                   INT            IDENTITY (1, 1) NOT NULL,
    [Name]                 NVARCHAR (50)  NULL,
    [TransportationTypeID] INT            NULL,
    [Description]          NVARCHAR (200) NULL,
    [ParentID]             INT            NOT NULL,
    [LanguageID]           INT            NOT NULL,
    CONSTRAINT [PK_TravelLanguage] PRIMARY KEY CLUSTERED ([ID] ASC)
);

