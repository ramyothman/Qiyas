CREATE TABLE [ContentManagement].[SitePageLanguage] (
    [SitePageLanguageId] INT            IDENTITY (1, 1) NOT NULL,
    [SitePageId]         INT            NULL,
    [LanguageId]         INT            NULL,
    [PageName]           NVARCHAR (250) NULL,
    [PageContent]        NTEXT          NULL,
    [AuthorAlias]        NVARCHAR (50)  NULL,
    [PageAlias]          NVARCHAR (50)  NULL,
    [ModifiedDate]       DATETIME       CONSTRAINT [DF_SitePageLanguage_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_SitePageLanguage] PRIMARY KEY CLUSTERED ([SitePageLanguageId] ASC),
    CONSTRAINT [FK_SitePageLanguage_Language] FOREIGN KEY ([LanguageId]) REFERENCES [ContentManagement].[Language] ([LanguageId]),
    CONSTRAINT [FK_SitePageLanguage_SitePage] FOREIGN KEY ([SitePageId]) REFERENCES [ContentManagement].[SitePage] ([SitePageId]) ON DELETE CASCADE ON UPDATE CASCADE
);

