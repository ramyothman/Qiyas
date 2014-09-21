CREATE TABLE [ContentManagement].[SitePageCategory] (
    [SitePageCategoryId] INT      IDENTITY (1, 1) NOT NULL,
    [SiteCategoryId]     INT      NULL,
    [SitePageId]         INT      NULL,
    [ModifiedDate]       DATETIME CONSTRAINT [DF_SitePageCategory_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_SitePageCategory] PRIMARY KEY CLUSTERED ([SitePageCategoryId] ASC),
    CONSTRAINT [FK_SitePageCategory_SiteCategory] FOREIGN KEY ([SiteCategoryId]) REFERENCES [ContentManagement].[SiteCategory] ([SiteCategoryId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_SitePageCategory_SitePage] FOREIGN KEY ([SitePageId]) REFERENCES [ContentManagement].[SitePage] ([SitePageId]) ON DELETE CASCADE ON UPDATE CASCADE
);

