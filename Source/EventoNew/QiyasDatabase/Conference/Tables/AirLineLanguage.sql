CREATE TABLE [Conference].[AirLineLanguage] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50) NULL,
    [LanguageID]      INT           NOT NULL,
    [AirLineParentID] INT           NOT NULL,
    CONSTRAINT [PK_AirLineLanguage] PRIMARY KEY CLUSTERED ([ID] ASC)
);

