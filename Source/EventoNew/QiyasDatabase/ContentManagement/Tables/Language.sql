CREATE TABLE [ContentManagement].[Language] (
    [LanguageId]   INT           IDENTITY (1, 1) NOT NULL,
    [LanguageCode] NVARCHAR (5)  NULL,
    [Name]         NVARCHAR (50) NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED ([LanguageId] ASC)
);

