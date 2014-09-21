CREATE TABLE [ContentManagement].[SectionFiles] (
    [SectionFileId]        INT            NOT NULL,
    [SectionFileName]      NVARCHAR (250) NULL,
    [SectionFilePath]      NVARCHAR (250) NULL,
    [SectionId]            INT            NULL,
    [SecurityAccessTypeId] INT            NULL,
    CONSTRAINT [PK_SectionFiles] PRIMARY KEY CLUSTERED ([SectionFileId] ASC),
    CONSTRAINT [FK_SectionFiles_ContentEntity] FOREIGN KEY ([SectionFileId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId]),
    CONSTRAINT [FK_SectionFiles_SiteSection1] FOREIGN KEY ([SectionId]) REFERENCES [ContentManagement].[SiteSection] ([SiteSectionId]) ON DELETE CASCADE ON UPDATE CASCADE
);

