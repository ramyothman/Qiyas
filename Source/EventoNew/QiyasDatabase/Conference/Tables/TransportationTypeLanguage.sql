CREATE TABLE [Conference].[TransportationTypeLanguage] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [TypeName]   NVARCHAR (50) NOT NULL,
    [LanguageID] INT           NOT NULL,
    [ParentID]   INT           NOT NULL,
    CONSTRAINT [PK_TransportationTypeLanguage] PRIMARY KEY CLUSTERED ([ID] ASC)
);

