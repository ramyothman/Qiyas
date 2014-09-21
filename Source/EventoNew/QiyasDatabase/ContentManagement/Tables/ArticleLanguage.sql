CREATE TABLE [ContentManagement].[ArticleLanguage] (
    [ArticleLanguageId] INT            IDENTITY (1, 1) NOT NULL,
    [ArticleId]         INT            NULL,
    [LanguageId]        INT            NULL,
    [ArticleName]       NVARCHAR (50)  NULL,
    [ArticleContent]    NTEXT          NULL,
    [ArticleAttachment] NVARCHAR (255) NULL,
    [AuthorAlias]       NVARCHAR (50)  NULL,
    [ArticleAlias]      NVARCHAR (50)  NULL,
    [PostDate]          DATETIME       NULL,
    [PublishStartDate]  DATETIME       NULL,
    [PublishEndDate]    DATETIME       NULL,
    [RevisionDate]      DATETIME       NULL,
    [ModifiedDate]      DATETIME       NULL,
    [ArticleSummary]    NVARCHAR (500) NULL,
    CONSTRAINT [PK_ArticleLanguage] PRIMARY KEY CLUSTERED ([ArticleLanguageId] ASC),
    CONSTRAINT [FK_ArticleLanguage_Article] FOREIGN KEY ([ArticleId]) REFERENCES [ContentManagement].[Article] ([ArticleId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_ArticleLanguage_Language] FOREIGN KEY ([LanguageId]) REFERENCES [ContentManagement].[Language] ([LanguageId])
);

