CREATE TABLE [ContentManagement].[SiteSection] (
    [SiteSectionId]        INT              NOT NULL,
    [Name]                 NVARCHAR (50)    NULL,
    [SiteSectionParentId]  INT              NULL,
    [SectionStatusId]      INT              NULL,
    [SiteId]               INT              NULL,
    [PersonId]             INT              NULL,
    [SecurityAccessTypeId] INT              NULL,
    [RowGuid]              UNIQUEIDENTIFIER CONSTRAINT [DF_SiteSection_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate]         DATETIME         CONSTRAINT [DF_SiteSection_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_SiteSection] PRIMARY KEY CLUSTERED ([SiteSectionId] ASC),
    CONSTRAINT [FK_SiteSection_ContentEntity] FOREIGN KEY ([SiteSectionId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_SiteSection_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person].[Person] ([BusinessEntityId]),
    CONSTRAINT [FK_SiteSection_SecurityAccessType] FOREIGN KEY ([SecurityAccessTypeId]) REFERENCES [RoleSecurity].[SecurityAccessType] ([SecurityAccessTypeId]),
    CONSTRAINT [FK_SiteSection_Site] FOREIGN KEY ([SiteId]) REFERENCES [ContentManagement].[Site] ([SiteId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_SiteSection_SiteSection] FOREIGN KEY ([SiteSectionParentId]) REFERENCES [ContentManagement].[SiteSection] ([SiteSectionId]),
    CONSTRAINT [FK_SiteSection_SiteSectionStatus] FOREIGN KEY ([SectionStatusId]) REFERENCES [ContentManagement].[SiteSectionStatus] ([SiteSectionStatusId])
);

