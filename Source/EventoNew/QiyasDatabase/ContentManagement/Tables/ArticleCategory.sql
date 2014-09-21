CREATE TABLE [ContentManagement].[ArticleCategory] (
    [ArticleCategoryId] INT      IDENTITY (1, 1) NOT NULL,
    [SiteCategoryId]    INT      NULL,
    [ArticleId]         INT      NULL,
    [PostDate]          DATETIME CONSTRAINT [DF_ArticleCategory_PostDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_ArticleCategory] PRIMARY KEY CLUSTERED ([ArticleCategoryId] ASC),
    CONSTRAINT [FK_ArticleCategory_Article] FOREIGN KEY ([ArticleId]) REFERENCES [ContentManagement].[Article] ([ArticleId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_ArticleCategory_SiteCategory] FOREIGN KEY ([SiteCategoryId]) REFERENCES [ContentManagement].[SiteCategory] ([SiteCategoryId]) ON DELETE CASCADE ON UPDATE CASCADE
);

