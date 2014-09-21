CREATE TABLE [ContentManagement].[ArticleTag] (
    [ArticleTagId] INT           IDENTITY (1, 1) NOT NULL,
    [ArticleId]    INT           NULL,
    [Name]         NVARCHAR (50) NULL,
    [LanguageId]   INT           NULL,
    [PostDate]     DATETIME      NULL,
    CONSTRAINT [PK_ArticleTag] PRIMARY KEY CLUSTERED ([ArticleTagId] ASC),
    CONSTRAINT [FK_ArticleTag_Article] FOREIGN KEY ([ArticleId]) REFERENCES [ContentManagement].[Article] ([ArticleId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_ArticleTag_Language] FOREIGN KEY ([LanguageId]) REFERENCES [ContentManagement].[Language] ([LanguageId])
);

