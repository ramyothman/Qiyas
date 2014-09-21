CREATE TABLE [ContentManagement].[MenuEntityItemLanguage] (
    [MenuEntityItemId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50) NULL,
    [LanguageID]       INT           NULL,
    [ParentId]         INT           NULL,
    CONSTRAINT [PK_SiteMenuLanguage] PRIMARY KEY CLUSTERED ([MenuEntityItemId] ASC)
);

