CREATE TABLE [ContentManagement].[SitePage] (
    [SitePageId]           INT              NOT NULL,
    [SectionId]            INT              NULL,
    [PageStatusId]         INT              NULL,
    [SecurityAccessTypeId] INT              NULL,
    [CreatorId]            INT              NULL,
    [UniquePageName]       NVARCHAR (50)    NULL,
    [IsMainPage]           BIT              NULL,
    [RowGuid]              UNIQUEIDENTIFIER CONSTRAINT [DF_SitePage_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [RevisionDate]         DATETIME         NULL,
    [ModifiedDate]         DATETIME         CONSTRAINT [DF_SitePage_ModifiedDate] DEFAULT (getdate()) NULL,
    [RevisionNumber]       INT              NULL,
    [PublishStart]         DATETIME         NULL,
    [PublishEnd]           DATETIME         NULL,
    CONSTRAINT [PK_SitePage] PRIMARY KEY CLUSTERED ([SitePageId] ASC),
    CONSTRAINT [FK_SitePage_ContentEntity] FOREIGN KEY ([SitePageId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId]),
    CONSTRAINT [FK_SitePage_PageStatus] FOREIGN KEY ([PageStatusId]) REFERENCES [ContentManagement].[PageStatus] ([PageStatusId]),
    CONSTRAINT [FK_SitePage_Person] FOREIGN KEY ([CreatorId]) REFERENCES [Person].[Person] ([BusinessEntityId]),
    CONSTRAINT [FK_SitePage_SecurityAccessType] FOREIGN KEY ([SecurityAccessTypeId]) REFERENCES [RoleSecurity].[SecurityAccessType] ([SecurityAccessTypeId]),
    CONSTRAINT [FK_SitePage_SiteSection] FOREIGN KEY ([SectionId]) REFERENCES [ContentManagement].[SiteSection] ([SiteSectionId]) ON DELETE CASCADE ON UPDATE CASCADE
);

